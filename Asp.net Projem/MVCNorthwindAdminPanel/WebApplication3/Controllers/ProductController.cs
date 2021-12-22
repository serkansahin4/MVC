using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ProductController : Controller
    {
        private NorthwindEntities northwindEntities = new NorthwindEntities();
        // GET: Product
        [HttpGet]
        public ActionResult Index()
        {
            
            return View(northwindEntities.Products.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(northwindEntities.Categories.ToList());
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            northwindEntities.Products.Add(product);
            northwindEntities.SaveChanges();
            return RedirectToAction("Index");
        }
     

       

        
    }
}