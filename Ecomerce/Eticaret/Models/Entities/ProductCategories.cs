using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eticaret.Models.Entities
{
    public class ProductCategories
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}