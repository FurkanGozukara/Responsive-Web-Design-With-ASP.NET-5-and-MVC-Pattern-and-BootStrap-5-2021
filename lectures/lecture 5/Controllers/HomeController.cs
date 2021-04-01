using Grpc.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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

        public IActionResult PartialWait()
        {
            System.Threading.Thread.Sleep(3333);
            return View("/Views/Shared/_Greeting.cshtml");
        }


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

            return View("Index", movie);
        }

        [HttpPost]
        public IActionResult Edit(string srText)
        {
            return Content($"Product updated! with text: {srText}");
        }


        public IActionResult ContentExample(string srText)
        {
            return Content($"Product updated! with text = {srText}");
        }

        public IActionResult FileExample()
        {
            var fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files/banner.jpg");
            return PhysicalFile(fullPath, "image/jpeg");
        }

        public IActionResult RedirectExample()
        {
            return Redirect("/Home/Examples");
        }

        public IActionResult StatusCodeEx()
        {
            return StatusCode(505);
        }

        public IActionResult Details(int id)
        {
            if (id == 32)
                return Content("id 32 is found");
            return NotFound();
        }

        public IActionResult Examples()
        {
            return View("Examples");
        }

        public IActionResult Test()
        {
            return View("/Unconventional/Test.cshtml");
        }
    }
}
