using ChatAppDeneme.Business.Abstract;
using ChatAppDeneme.Business.Concrete;
using ChatAppDeneme.DataAccess.Concrete.EntityFramework;
using ChatAppDeneme.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ChatAppDeneme.MVC.Controllers
{
    public class UserController : Controller
    {
        IUserService _userService = new UserManager(new UserDal());
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            var loginUser = _userService.Get(user.UserName);
            if (loginUser == null)
            {
                TempData["Kontrol"] = "Kullanıcı Adı Veya Parolanız Yanlış.";
                return View();
            }
            else
            {
                Session["User"] = loginUser.Id;
                return RedirectToAction("Index", "Friend");
            }

        }

        public ActionResult Member()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Member(User user)
        {
            _userService.Add(user);
            return RedirectToAction("Index");
        }
    }
}