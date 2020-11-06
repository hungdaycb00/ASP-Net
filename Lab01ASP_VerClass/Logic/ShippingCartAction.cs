﻿using Lab01ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;


namespace Lab01ASP.Logic
{
    public class ShippingCartAction : IDisposable
    {
        public string ShoppingCartId { get; set; }
        private ProductContext _db = new ProductContext();

        public const string CartSessionKey = "CartId";

        public void AddToCart(int id)
        {
            ShoppingCartId = GetCartId();

            var cartItem = _db.ShoppingCartItems.SingleOrDefault(
                c => c.CartId == ShoppingCartId
                && c.ProductId == id);
            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    ItemId = Guid.NewGuid().ToString(),
                    ProductId = id,
                    CartId = ShoppingCartId,
                    Product = _db.Products.SingleOrDefault(
                    p => p.ProductID == id),
                    Quantity = 1,
                    DateCreated = DateTime.Now
                };
                _db.ShoppingCartItems.Add(cartItem);
            }
            else
            {
                cartItem.Quantity++;
            }
            _db.SaveChanges();
        } 



        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
                _db = null;
            }
        }
        public string GetCartId()
        {
            if (HttpContext.Current.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
                {
                    HttpContext.Current.Session[CartSessionKey] = HttpContext.Current.User.Identity.Name;
                }
                else
                {
                    Guid tempCartId = Guid.NewGuid();
                    HttpContext.Current.Session[CartSessionKey] = tempCartId.ToString();
                }
            }
            return HttpContext.Current.Session[CartSessionKey].ToString();
        }

        public List<CartItem> GetCastItems()
        {
            ShoppingCartId = GetCartId();
            return _db.ShoppingCartItems.Where(c => c.CartId == ShoppingCartId).ToList();

        }
        public decimal GetTotal()
        {
            ShoppingCartId = GetCartId();
            decimal? total = decimal.Zero;
            total = (decimal?)(from CartItem in _db.ShoppingCartItems
                               where CartItem.CartId == ShoppingCartId
                               select (int?)CartItem.Quantity *
                               CartItem.Product.UnitPrice).Sum();
            return total ?? decimal.Zero;
        }
        public ShippingCartAction  GetCart(HttpContext context)
        {
            using (var cart = new ShippingCartAction())
            {
                cart.ShoppingCartId = cart.GetCartId();
                return cart; 
            }
        }

        public void UpdateShoppingCartDatabase(String CartId, ShoppingCartUpdates[] CartItemUpdates)
        {
            using (var db = new Lab01ASP.Models.ProductContext())
            {
                try
                {
                    int CartItemCount = CartItemUpdates.Count();
                    List<CartItem> myCart = GetCastItems();
                    foreach (CartItem) myCart = GetCastItems()
                            {
                        for(int i = 0; i < CartItemCount; i++)
                        {
                            if(CartItemUpdates[i].PurchaseQuantity < 1|| CartItemUpdates[i].RemoveItem == true)
                            {
                                RemoveItem(cartId, cartItem.ProductId);
                            }
                            else
                            {
                                UpdateItem(cartId, cartItem.ProductId, CartItemUpdates[i].PurchaseQuantity);
                            }
                        }
                    }

                }
                catch(Exception exp)
                {
                    throw new Exception("ERROR: Unable to Update Cart Database - " + exp.Message.ToString(), exp);
                }
            }
            
        }
        public void RemoveItem(string removeCartID, int removeProductID)
        {
            using(var _db = new Lab01ASP.Models.ProductContext())
            {
                try
                {
                    var myItem = (from c in _db.ShoppingCartItems where c.CartId ==
                                  removeCartID && c.Product.ProductID == removeProductID select c).FirstOrDefault();
                    if(myItem != null)
                    {
                        _db.ShoppingCartItems.Remove(myItem);
                        _db.SaveChanges();
                    }
                }
                catch(Exception exp)
                {
                    throw new Exception("ERROR: Unable to Remove Cart Item - " + exp.Message.ToString(), exp);
                }
            }
        }
        public void UpdateItem(string updateCartID, int updateProductID, int quantity)
        {
            using (var _db = new Lab01ASP.Models.ProductContext())
            {
                try
                {
                    var myItem = (from c in _db.ShoppingCartItems where c.CartId == updateCartID && c.Product.ProductID == updateProductID select
                                  c).FirstOrDefault();
                    if(myItem != null)
                    {
                        myItem.Quantity = quantity;
                        _db.SaveChanges();
                    }
                }
                catch(Exception exp)
                {
                    throw new Exception("ERROR: Unable to Update Cart Item - " + exp.Message.ToString(), exp);
                }
            }
        }
        public void EmptyCart()
        {
            ShoppingCartId = GetCartId();
            var cartItems = _db.ShoppingCartItems.Where(
                c => c.CartId == ShoppingCartId);
            foreach(var cartItem in cartItems)
            {
                _db.ShoppingCartItems.Remove(cartItem);
            }
            _db.SaveChanges();
        }

        public int GetCount()
        {
            ShoppingCartId = GetCartId();

            int? count = (from CartItem in _db.ShoppingCartItems
                          where CartItem.CartId == ShoppingCartId
                          select (int?)CartItem.Quantity).Sum();
            return count ?? 0;
        }
        public struct ShoppingCartUpdates
        {
            public int ProductId;
            public int PurchaseQuantity;
            public bool RemoveItem; 
        }


    }
}