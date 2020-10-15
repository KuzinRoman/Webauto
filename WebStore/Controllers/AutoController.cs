using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    public class AutoController : Controller
    {
        private readonly List<AutoViewModel> _auto = new List<AutoViewModel>
        {
            new AutoViewModel
            {
                Id = 1,
                Regnomer = "b123tn",
                Autoname = "Shkoda Octavia",
                Crash = false,
                Age = 5,
                Numbercrash = 0
            },
           
            new AutoViewModel
            {
                Id = 2,
                Regnomer = "c674te",
                Autoname = "Hyundai Tucson",
                Crash = true,
                Age = 4,
                Numbercrash = 3
            }
        };

        // /home/index
        public IActionResult Index()
        {
            return View();
        }

        // /home/Autos
        public IActionResult Autos()
        {
            return View(_auto);
        }

        // /home/AutoDetails/1
        public IActionResult AutosDetails(int id)
        {
            var autoViewModel = _auto.FirstOrDefault(x => x.Id == id);

            //Если такого не существует
            if (autoViewModel == null)
                return NotFound(); // возвращаем результат 404 Not Found

            return View(autoViewModel);
        }
    }
}
