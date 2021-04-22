using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return View("/Views/Home/Index.cshtml"); this is full path by asp.net looks for the same path when just view is called
            return View();//since we use default routing, it will look for Views/Home/Index.cshtml
            return Content("test");
        }

        [Route("/test2")]
        public IActionResult Test()
        {
            return Content("test");
        }

        public IActionResult Something()
        {
            return Content("Something ");
        }

        public IActionResult parameterPass(int id)
        {
            return Content("passed id is : "+ id);
        }
    }
}
