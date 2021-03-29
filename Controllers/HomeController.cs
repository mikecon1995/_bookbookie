using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using bookbookie.Models;

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
    }
}
