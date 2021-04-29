using lecture_9.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_9.Controllers
{
    public class Lecture9Controller : Controller
    {
        [HttpGet]
        [Route("/{irUser?}")]
        public IActionResult Index(int irUser = 1)
        {
            var myModel = GlobalMethods.refreshModel_v9(irUser);

            return View("Lecture9", myModel);
        }

        [HttpPost]
        [Route("/")]
        [ActionName("updateLecture9Model")]
        public IActionResult Index(Lecture9 myModel)
        {
            if (!ModelState.IsValid)
            {
                myModel.srPostMessage = "The values you have entered are invalid therefore please fix the errors and try again";
                return View("Lecture9", myModel);
            }

            TblUsers myUser = new TblUsers
            {
                FirstName = myModel.srFirstName,
                LastName = myModel.srLastName,
                Email = myModel.srEmail,
                UserId = myModel.irUserId,
                BirthDay = myModel.dtBirthDay
            };

            GlobalMethods.updateUser(myUser);
            myModel.srPostMessage = "user 1 first name and last name successfully updated in the database";
            return View("Lecture9", myModel);
        }
    }
}
