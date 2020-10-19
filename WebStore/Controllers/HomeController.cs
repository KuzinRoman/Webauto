using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        [SimpleActionFilter]
        public IActionResult Index()
        {
            //return new FileContentResult();
            //return new EmptyResult();
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
