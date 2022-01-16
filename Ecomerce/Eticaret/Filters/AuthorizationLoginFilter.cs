using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.Filters
{
    public class AuthorizationLoginFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["User"]!=null)
            {
                filterContext.Result = new RedirectResult("~/Home/Index");
            }
        }
    }
}