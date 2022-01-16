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
    public class FriendController : Controller
    {
        IFriendService _friendService = new FriendManager(new FriendDal());
        IMessageService _messageService = new MessageManager(new MessageDal());
        // GET: Friend
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult _MessagesGetir()
        {
            ViewBag.Idf = Session["FriendId"];
            return View(_friendService.GetAllLazy("Friend", Convert.ToInt32(Session["User"])).ToList());
        }
        public PartialViewResult _MessageChatGetir()
        {
            return PartialView();
        }
        
    }
}