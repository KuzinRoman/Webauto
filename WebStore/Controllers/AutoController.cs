using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Interface;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    [Route("autonew/[action]")]
    public class AutoController : Controller
    {
        private readonly IAutoService _autoService;

        public AutoController(IAutoService autoService)
            {
            _autoService = autoService;
        }

        //[Route("all")]
        // /home/index
        [Route("idx")]
        public IActionResult Index()
        {
            return View();
        }

        // /home/Autos
        [Route("ats")]
        public IActionResult Autos()
        {
            return View(_autoService.GetAll());
        }

        // /home/AutoDetails/1
        [Route("{id}")]
        public IActionResult AutosDetails(int id)
        {
            var autoViewModel = _autoService.GetById(id);

            //Если такого не существует
            if (autoViewModel == null)
                return NotFound(); // возвращаем результат 404 Not Found

            return View(autoViewModel);
        }

    

        [HttpGet]
        [Route("edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue)
                return View(new AutoViewModel());

            var model = _autoService.GetById(id.Value);
            if (model == null)
                return NotFound();// возвращаем результат 404 Not Found

            return View(model);
        }

       
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _autoService.Delete(id);
            return RedirectToAction(nameof(Autos));
        }

        [HttpPost]
        [Route("edit/{id?}")]
        public IActionResult Edit(AutoViewModel model)
        {
            var dbItem = _autoService.GetById(model.Id);
            if ( dbItem != null) // если есть Id, то редактируем модель
            {
               // var dbItem = _autoService.GetById(model.Id);

                if (ReferenceEquals(dbItem, null))
                    return NotFound();// возвращаем результат 404 Not Found
                dbItem.Id = model.Id;
                dbItem.Regnomer = model.Regnomer;
                dbItem.Autoname = model.Autoname;
                dbItem.Age = model.Age;
                dbItem.Crash = model.Crash;
                dbItem.Numbercrash = model.Numbercrash;
            }
            else // иначе добавляем модель в список
            {
                _autoService.AddNew(model);
            }

            _autoService.Commit();

            return RedirectToAction(nameof(Autos));
        }
    }
    }

