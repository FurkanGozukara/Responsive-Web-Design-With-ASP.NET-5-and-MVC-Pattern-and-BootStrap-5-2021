﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_9.Controllers
{
 
    public class Lecture16Controller : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Welcome to our MVC Course";
            return View("Index");
        }
    }
}