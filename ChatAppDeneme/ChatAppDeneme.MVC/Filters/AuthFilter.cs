using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatAppDeneme.MVC.Filters
{
    public class AuthFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["User"]==null)
            {
                filterContext.Controller.TempData["Kontrol"] = "Bu Alanı Görüntüleyemezsiniz.";
                filterContext.Result = new RedirectResult("/User/Index");
            }
        }
    }
}