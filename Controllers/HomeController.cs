using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HomeWork02.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }

    //public void SendEmail(string name, string email, string subject, string comments)
    //{
    //    var emailMsg = new MailMessage();
    //    emailMsg.From = new MailAddress("square.estate.agency@gmail.com");
    //    emailMsg.To.Add(new MailAddress(email, name));
    //    emailMsg.Subject = subject;
    //    emailMsg.IsBodyHtml = true;
    //    emailMsg.Body = comments;

    //    using (var client = new SmtpClient())
    //    {
    //        client.Host = "smtp.gmail.com";
    //        client.Port = 587;
    //        client.EnableSsl = true;
    //        client.DeliveryMethod = SmtpDeliveryMethod.Network;
    //        client.UseDefaultCredentials = false;
    //        client.Credentials = new NetworkCredential("square.estate.agency@gmail.com", "testingasp");
    //        client.Send(emailMsg);
    //    }
    //}

    //public void SendEmail(string subjict)
    //{
    //    MailAddress from = new MailAddress("saparbek28@gmail.com");
    //    MailAddress to = new MailAddress("SaparbekShag@gmail.com");
    //    MailAddress Subject = subjict;
    //}





}