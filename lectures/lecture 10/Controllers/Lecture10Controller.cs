using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lecture_9.Models;

namespace lecture_9.Controllers
{
    [Route("/")]
    public class Lecture10Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            Lecture10 myModel = new Lecture10 { srTitle = "Welcome to Lecture 10" };
            if(TempData.ContainsKey("updatedData"))
                myModel =  TempData.Get<Lecture10>("updatedData");
               

            return View("Lecture10", myModel);
        }

        [HttpPost]
        //[ActionName("updateModelTitle")]
        public IActionResult updateModelTitle(Lecture10 myModel)
        {
            if (!ModelState.IsValid)
                return Content("error! invalid data is sent to the server");

            myModel.srTitle += ". Data is received.";
            return View("Lecture10", myModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/lecture10/update", Name = "updateV2")]
        public IActionResult updateModelTitleV2(Lecture10 myModel, int irTest = 0)
        {
            if (!ModelState.IsValid)
                return Content("error! invalid data is sent to the server");

            myModel.srTitle += ". Data is received v2.";
            TempData.Put("updatedData", myModel);
            return RedirectToAction("Index");
            //return View("Lecture10", myModel);
        }
    }
}
