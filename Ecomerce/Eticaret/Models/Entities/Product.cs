using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eticaret.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int UnitInStock { get; set; }
        public string UnitPrice { get; set; }
        public virtual List<ProductCategories> ProductCategories { get; set; }
    }
}