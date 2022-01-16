using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eticaret.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public virtual List<ProductCategories> ProductCategories { get; set; }
    }
}