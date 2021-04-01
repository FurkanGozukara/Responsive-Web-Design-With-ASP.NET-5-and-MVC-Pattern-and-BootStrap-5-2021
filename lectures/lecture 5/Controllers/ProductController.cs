using lecture_1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Details(int id)
        {
            Product product = new Product()
            {
                Title = "Toilet Paper",
                Price = 1.99,
                Id = (id == 0 ? 32 : id)
            };
            return View("Index", product);//since the action name (Details) not matching the view name, i have to provide view name (Index)
        }

        public IActionResult Dynamic()
        {
            Dynamic myModel = new Dynamic();
            return View("TestDynamic", myModel);
        }

        public IActionResult DetailsViewData(int id = 432)
        {
            ViewBag.Title = "Newspaper";
            ViewBag.Price = 21.99;
            ViewBag.Id = id;
            return View("Index");
        }

        public IActionResult GetMyViewComponent(int _idOfProduct = 100,bool _delay=true)
        {
            return ViewComponent("testComponent", new { idOfProduct = _idOfProduct , delay = _delay });
        }
    }
}
