using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProductManager.NongPhanManhHung.Models
{
    public class Product
    {
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
