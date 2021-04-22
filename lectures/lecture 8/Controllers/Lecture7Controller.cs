using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lecture_6.Models;

namespace lecture_6.Controllers
{
    public class Lecture7Controller : Controller
    {

        [Route("/lecture7/{userid?}", Order = 2)]
        [HttpGet]
        public IActionResult Index(int userid = 1)
        {
            var myModel = GlobalMethods.refreshModel(userid);

            return View("Lec7_Index", myModel);
        }



        [HttpPost]
        [Route("/Lecture7/UpdateUser", Order = 1)]
        public IActionResult UpdateUser(int userid = 1)
        {
            TblUsers myUser = new TblUsers
            {
                FirstName = Request.Form["txtFirstName"],
                LastName = Request.Form["txtLastName"],
                UserId = userid
            };

            if (Int32.TryParse(Request.Form["txtUserId"], out userid))
            {
                myUser.UserId = userid;
            }

            GlobalMethods.updateUser(myUser);

            var myModel = GlobalMethods.refreshModel(userid);

            return View("Lec7_Index", myModel);

            // return RedirectToAction("Index");
        }
    }
}
