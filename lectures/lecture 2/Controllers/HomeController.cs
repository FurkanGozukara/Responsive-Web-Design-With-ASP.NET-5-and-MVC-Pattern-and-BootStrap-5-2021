using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_1.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //   // return Content("Hello, MVC world!");
        //}

        public IActionResult Index()
        {
            Models.Movie movie = new Models.Movie()
            {
                Title = "The Godfather",
                ReleaseDate = new DateTime(1972, 3, 24)
            };

            List<string> Student = new List<string>();
            Student.Add("Jignesh");
            Student.Add("Tejas");
            Student.Add("Rakesh");

            ViewData["Student"] = Student;
            ViewBag.Student = Student;

            return View(movie);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            Models.Movie movie = new Models.Movie()
            {
                Title = "editing window",
                ReleaseDate = new DateTime(2000, 3, 24)
            };

            List<string> Student = new List<string>();
            Student.Add("Jignesh");
            Student.Add("Tejas");
            Student.Add("Rakesh");

            ViewData["Student"] = Student;
            ViewBag.Student = Student;

            return View("Index",movie);
        }

        [HttpPost]
        public IActionResult Edit(string srText)
        {
            return Content($"Product updated! with text: {srText}");
        }
    }
}
