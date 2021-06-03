using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_9.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View("Details");
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
