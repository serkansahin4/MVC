using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace Eticaret.Utils
{
    public class MailSender
    {
        public static void GmailMessage(string email,string subject,string message)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("serkana607@gmail.com","Activation");
            mailMessage.Subject =subject;
            mailMessage.To.Add(email);
            mailMessage.Body = message;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("serkana607@gmail.com", "64720176216+bjk");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";

            smtp.Send(mailMessage);
        }
    }
}