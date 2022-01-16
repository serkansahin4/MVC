using Eticaret.Filters;
using Eticaret.Models.Context;
using Eticaret.Models.Entities;
using Eticaret.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.Controllers
{
    [AuthorizationLoginFilter]
    public class RegisterController : Controller
    {
        DbTradeContext dbTradeContext = new DbTradeContext();
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Customer customer)
        {
            Guid guid = Guid.NewGuid();
            customer.ActivationKey = guid;
            dbTradeContext.Customers.Add(customer);
            dbTradeContext.SaveChanges();
            MailSender.GmailMessage(customer.Email, "Üyelik Aktivasyonu", $"http://localhost:56944/Register/AktivationApprove/{guid}");
            return View("MailAktivasyon");
        }


        public ActionResult MailAktivasyon()
        {
            return View();
        }

        
        public ActionResult AktivationApprove(Guid id)
        {
            bool kontrol = dbTradeContext.Customers.Any(x=>x.ActivationKey==id);
            if (kontrol)
            {
                Customer customer = dbTradeContext.Customers.SingleOrDefault(x=>x.ActivationKey==id);
                customer.IsActive =true;
                dbTradeContext.Entry(customer).State = EntityState.Modified;
                dbTradeContext.SaveChanges();
                TempData["UyelikOnaylandi"] = "Üyeliğiniz Onaylandı. Giriş Yapabilirsiniz.";
                return RedirectToAction("Index", "Login");
            }
            else
            {
                TempData["GecersizAktivasyonLinki"] = "Aktivasyon Linki Geçersiz Veya Süresi Dolmuş.";
                Thread.Sleep(3000);
                return View();
            }
            
        }
        
        
        
    }
}