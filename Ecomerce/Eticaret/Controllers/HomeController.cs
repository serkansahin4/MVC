using Eticaret.Filters;
using Eticaret.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.Controllers
{
    [AuthorizationHomeFilter]
    public class HomeController : Controller
    {
        DbTradeContext dbTradeContext = new DbTradeContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(dbTradeContext.Products.ToList());
        }
       


    }
}