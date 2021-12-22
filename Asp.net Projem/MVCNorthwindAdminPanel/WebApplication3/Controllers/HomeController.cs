using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        ViewModel ViewModel = new ViewModel();
        public ActionResult Index()
        {
            return View(ViewModel);
        }

        public ActionResult OrderDetail(int id)
        {
            return View(ViewModel.Orders.SingleOrDefault(p=>p.OrderID==id));
        }
    }
}