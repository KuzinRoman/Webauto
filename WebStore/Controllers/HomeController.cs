using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult blogsingle()
        {
            return View();
        }

        public IActionResult error()
        {
            return View();
        }

        public IActionResult cart()
        {
            return View();
        }
        public IActionResult checkout()
        {
            return View();
        }
        public IActionResult contactus()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }

        public IActionResult productdetails()
        {
            return View();
        }

        public IActionResult shop()
        {
            return View();
        }
    }
}
