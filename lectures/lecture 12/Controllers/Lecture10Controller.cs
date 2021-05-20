using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lecture_9.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace lecture_9.Controllers
{
    [Route("/", Name ="/")]
    public class Lecture10Controller : Controller
    {
        private readonly IConfiguration _configuration;
        private MyOptions _options;

        // Dependency Injection (DI) - with this way when this class is initialized it will get config automatically
        public Lecture10Controller(IConfiguration configuration, IOptions<MyOptions> websiteOptions)
        {
            _configuration = configuration;
            _options = websiteOptions.Value;
        }

        [HttpGet]
        public IActionResult Index()
        {
            Lecture10 myModel = new Lecture10 { srTitle = "Welcome to Lecture 10" };
            if (TempData.ContainsKey("updatedData"))
                myModel = TempData.Get<Lecture10>("updatedData");

            return View("Lecture10", myModel);
        }

        [HttpGet]
        [Route("/lecture10/index2")]
        public IActionResult indexv2()
        {
            Lecture10 myModel = new Lecture10 { srTitle = "Welcome to Lecture 10" };
            if (TempData.ContainsKey("updatedData"))
                myModel = TempData.Get<Lecture10>("updatedData");

            return View("Lecture10", myModel);
        }

        [HttpGet]
        [Route("/lecture10/index3")]
        public IActionResult indexv3()
        {
            Convert.ToInt32("sadasdas");

            Lecture10 myModel = new Lecture10 { srTitle = "Welcome to Lecture 10" };
            if (TempData.ContainsKey("updatedData"))
                myModel = TempData.Get<Lecture10>("updatedData");

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
            {
                var errors = ModelState.Select(x => x.Value.Errors)
                          .Where(y => y.Count > 0)
                          .ToList();

                var result = Content($"<html>error! invalid data is sent to the server<br/>{string.Join("<br/>", errors.Select(pr => pr.FirstOrDefault().ErrorMessage))}</html>");
                result.ContentType = "text/html; charset=UTF-8";

                return result;
            }


            myModel.srTitle += ". Data is received v2.";

            var vrValidationNumericValue = (int)myModel.validationStatus;

            TempData.Put("updatedData", myModel);
            return RedirectToAction("Index");
            //return View("Lecture10", myModel);
        }

        [Route("/lecture10/moviedetails/{srMoveId?}", Name = "listMovieDetails")]
        public IActionResult listMovieDetails(string srMoveId)
        {
            Lecture10 myModel = new Lecture10();

            var vrVal = myModel.MoviesList.Where(pr => pr.Value == srMoveId).FirstOrDefault()?.Text;


            vrVal = vrVal == null ? "no such movie is found" : vrVal;

            return Content(vrVal);
        }

        [Route("/lecture10/configTest")]
        public IActionResult configTest()
        {
            return Content(_configuration.GetValue<string>("OurSiteTitleCustom"));
        }

        [Route("/lecture10/optionTest")]
        public IActionResult optionTest()
        {
            return Content(_options.Title);
        }
    }
}
