using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using bookbookie.Models;
using System.Web;
using System.Web;
using bookbookie.Models;
using System.Net.Mail;
using System.Net;

namespace bookbookie.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewData["book"] = new BookModel() { Id = 1 };

            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult Checkout()
        {
            return View();
        }
        public ViewResult Authentication()
        {
            return View();
        }
        //Get Emailsetup
        [HttpPost]
        public ActionResult Index(bookbookie.Models.MailModel model)
        {
            MailMessage mm = new MailMessage("bookbookie2021@gmail.com", model.To);
            mm.Subject = model.Subject;
            mm.Body = model.Body;
            mm.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            NetworkCredential nc = new NetworkCredential("bookbookie2021@gmail.com", "B00kies$");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = nc;
            smtp.Send(mm);
            ViewBag.Message = "Mail Has Been Sent Successfully!";

            return View();
        }
    }
}
