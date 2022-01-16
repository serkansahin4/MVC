using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eticaret.Models.Entities
{
    public class Order
    {
        public Order()
        {
            OrderDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }

        public int ProductId { get; set; }
        public int UserId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Customer User { get; set; }
    }
}