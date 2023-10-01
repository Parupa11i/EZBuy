using System;
using Microsoft.AspNetCore.Mvc;

namespace EZBuy.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View("Contactus");
        }
    }
}
