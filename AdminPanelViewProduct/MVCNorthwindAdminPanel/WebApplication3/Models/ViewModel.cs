using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class ViewModel
    {
        private NorthwindEntities _northwindEntities = new NorthwindEntities();
        private int AlinanSiparisler()
        {
            return _northwindEntities.Orders.ToList().Where(p => p.OrderDate <= DateTime.Now).Count();
        }
        private double GununGelirleri()
        {
            return _northwindEntities.Order_Details.ToList().Sum(p => (Convert.ToDouble(p.UnitPrice)*Convert.ToDouble(p.Quantity))*(1-p.Discount));
        }
        private int ToplamUrunAdedi()
        {
            return _northwindEntities.Products.ToList().Sum(p=>Convert.ToInt32(p.UnitsInStock));
        }
        private int KargoSayi()
        {
            return _northwindEntities.Orders.Where(p => p.ShippedDate < p.RequiredDate).ToList().Count();
        }

        public int AlinanSiparis { get { return AlinanSiparisler(); } }
        public double GununGelir {get { return GununGelirleri(); } }
        public int ToplamUrunAdet { get { return ToplamUrunAdedi(); } }
        public int KargoSayisi { get { return KargoSayi(); } }
        public List<Order> Orders { get { return _northwindEntities.Orders.ToList(); }}
    }
}