using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lecture_6.Models;

namespace lecture_6.Controllers
{
    public class BindingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var myModel = GlobalMethods.refreshModel(1);

            return View("Binding", myModel);
        }

        [HttpPost]
        public IActionResult Index(Lecture7 myModel)
        {
            TblUsers myUser = new TblUsers
            {
                FirstName = myModel.srFirstName,
                LastName = myModel.srLastName,
                UserId = 1
            };

            GlobalMethods.updateUser(myUser);
            myModel.srPostMessage = "user 1 first name and last name successfully updated in the database";
            return View("Binding", myModel);
        }
    }
}
