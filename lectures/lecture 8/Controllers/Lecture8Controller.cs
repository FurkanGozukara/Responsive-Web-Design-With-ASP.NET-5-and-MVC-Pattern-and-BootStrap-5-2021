using lecture_6.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_6.Controllers
{
    public class Lecture8Controller : Controller
    {
        [HttpGet]
        [Route("/{irUser?}")]
        public IActionResult Index(int irUser=1)
        {
            var myModel = GlobalMethods.refreshModel_v8(irUser);

            return View("Lecture8", myModel);
        }

        [HttpPost]
        [Route("/")]
        [ActionName("updateLecture8Model")]
        public IActionResult Index(Lecture8 myModel)
        {
            if (!ModelState.IsValid)
            {
                myModel.srPostMessage = "The values you have entered are invalid therefore please fix the errors and try again";
                return View("Lecture8", myModel);
            }

            TblUsers myUser = new TblUsers
            {
                FirstName = myModel.srFirstName,
                LastName = myModel.srLastName,
                Email = myModel.srEmail,
                UserId =  myModel.irUserId,
                BirthDay = myModel.dtBirthDay
            };

            GlobalMethods.updateUser(myUser);
            myModel.srPostMessage = "user 1 first name and last name successfully updated in the database";
            return View("Lecture8", myModel);
        }
    }
}
