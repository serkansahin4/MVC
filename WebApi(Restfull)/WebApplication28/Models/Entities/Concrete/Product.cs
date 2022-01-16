using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication28.Models.Entities.Abstract;

namespace WebApplication28.Models
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }

    }
}