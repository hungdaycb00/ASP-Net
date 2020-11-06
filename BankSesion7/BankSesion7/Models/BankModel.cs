using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankSesion7.Models
{
    public class BankModel
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
    }
}