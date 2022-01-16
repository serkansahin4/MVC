using Eticaret.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.Controllers
{
    public class SharedController : Controller
    {
        DbTradeContext dbTradeContext = new DbTradeContext();
        // GET: Shared
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Categories()
        {
            return PartialView();
        }
    }
}