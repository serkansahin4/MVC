using Eticaret.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.Controllers
{
    public class ProductCategoriesController : Controller
    {
        DbTradeContext dbTradeContext = new DbTradeContext();
        // GET: ProductCategories
        public PartialViewResult _Categories()
        {
            return PartialView(dbTradeContext.Categories.ToList());
        }
       

        
    }
}