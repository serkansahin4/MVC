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
    public class MessageController : Controller
    {
        IMessageService _messageService = new MessageManager(new MessageDal());
        // GET: Message
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult _MessageAll(int id)
        {
            Session["FriendId"]=id;
            return View(_messageService.GetMessages(Convert.ToInt32(Session["User"]),id));
        }

        public ActionResult _MessageChatGetir()
        {
            return View();
        }
        [HttpPost]
        public ActionResult _MessageChatGetir(Message message)
        {
            message.AliciId = (int)Session["FriendId"];
            message.UserId = (int)Session["User"];
            _messageService.Add(message);
            return RedirectToAction("Index","Friend");
        }

        
    }
}