using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lecture_9.Models;

namespace lecture_9.Controllers
{
    [Route("/", Name = "/")]
    public class Lecture17Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/lecture/login")]
        public IActionResult Index2()
        {
            Login userLogin = new Login();
            if (HttpContext.Session.Keys.Contains("UserLogin"))
            {
                userLogin.userValues = JsonConvert.DeserializeObject<TblUsers>(HttpContext.Session.GetString("UserLogin"));
            }

            return View("Login", userLogin);
        }

        [Route("/lecture/loginOp" , Name = "loginRoute")]
        public IActionResult Login(Models.Login myLogin)
        {
            using (MVCContext myContext = new MVCContext())
            {
                var vrUserInfo = myContext.TblUsers.Where(pr => pr.Email == myLogin.srEmail && pr.FirstName == myLogin.srFirstName).FirstOrDefault();

                if(vrUserInfo == null)
                {
                    return Content("invalid first name and email combination entered");
                }

                if (vrUserInfo != null)
                {
                    HttpContext.Session.SetString("UserLogin", JsonConvert.SerializeObject(vrUserInfo));
                }
            }

            return RedirectToAction("Index2");
        }

        [Route("/lecture/logOut", Name = "logoutRoute")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserLogin");

            return RedirectToAction("Index2");
        }
    }
}
