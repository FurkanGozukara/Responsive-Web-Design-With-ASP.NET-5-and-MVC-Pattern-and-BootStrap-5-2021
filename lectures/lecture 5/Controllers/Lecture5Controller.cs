using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_1.Controllers
{
    public class Lecture5Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListBooks()//this matching views/lecture5/listbooks.cshtml
        {
            return View();
        }

        public IActionResult List()//this does not matching views/lecture5/list.cshtml therefore provide view name
        {
            ViewBag.Title = "this is iteration page title set in controller";
            Models.SchoolLibrary lib = new Models.SchoolLibrary
            {
                srManagerName = "Furkan",
                lstNameofBooks = new List<string> { "Book A", "Book B", "Book C" }
            };

            DataRow _book = lib.dtSomeVals.NewRow();
            _book["price"] = 31231;
            _book["name"] = "introduction to programming";
            lib.dtSomeVals.Rows.Add(_book);

            return View("Iteration", lib);
        }

        public IActionResult Test()//this will call another view but i provide full path
        {
            return View("/Unconventional/Test.cshtml");
        }
    }
}
