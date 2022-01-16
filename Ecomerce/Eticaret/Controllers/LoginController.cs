using Eticaret.Filters;
using Eticaret.Models.Context;
using Eticaret.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.Controllers
{
    [AuthorizationLoginFilter]
    public class LoginController : Controller
    {
        DbTradeContext DbTradeContext = new DbTradeContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Customer customer)
        {
            Customer _customer = DbTradeContext.Customers.SingleOrDefault(x => x.UserName == customer.UserName && x.Password == customer.Password);
            ActionResult actionResult;
            if (_customer != null)
            {
                if (_customer.IsActive!=false)
                {
                    Session["User"] = _customer;
                    actionResult = RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["BasarisizGiris"] = "Hesabınız Onaylanmamış. Eposta Adresinize Giderek Hesabınızı Onaylayın.";
                    actionResult = View();
                }
            }
            else
            {
                TempData["BasarisizGiris"] = "Kullanıcı Adı veya Parolanız Yanlış.";
                actionResult = View();
            }
            return actionResult;
        }

    }
}