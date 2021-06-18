using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lecture_9.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.Extensions.Caching.Memory;

namespace lecture_9.Controllers
{
    public class Lecture13Controller : Controller
    {
        private IMemoryCache _memoryCache;

        public Lecture13Controller(IMemoryCache memoryCache)
        {
            this._memoryCache = memoryCache;
        }

        [Route("/lecture13/index", Name = "lecture13")]
        [OutputCache(Duration = 15)]
        public IActionResult Index()
        {
            Lecture13 myModel = new Lecture13();

            foreach (var item in HttpContext.Request.Query)
            {
                myModel.HttpContext_Request_Query += "parameter name: " + item.Key + " parameter value: " + item.Value + "<br/>";
            }

            if (!String.IsNullOrEmpty(HttpContext.Request.QueryString.ToString()))
                myModel.HttpContext_Request_QueryString = HttpContext.Request.QueryString.ToString();

            if (!HttpContext.Request.Cookies.ContainsKey("pathCookie"))
            {
                CookieOptions cookieOptions = new CookieOptions();
                cookieOptions.Path = "/lecture13/";
                cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(30));
                HttpContext.Response.Cookies.Append("pathCookie","this cookie will be valid for only lecture13 pages", cookieOptions);
            }

            if (!HttpContext.Request.Cookies.ContainsKey("first_request"))
            {
                CookieOptions cookieOptions = new CookieOptions();
                cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(30));
                HttpContext.Response.Cookies.Append("first_request", DateTime.Now.ToString(), cookieOptions);
            }
            else
            {
               myModel.firstTimeVisitDate = DateTime.Parse(HttpContext.Request.Cookies["first_request"]);
            }

            var vrTest = HttpContext.Request.Cookies["first_requestv2"];

            if(HttpContext.Session.IsAvailable)
            {
                //myModel.CarName = HttpContext.Session.Keys.Any(pr => pr == "CarName") == true ? HttpContext.Session.GetString("CarName") : "";
                //myModel.CarId = HttpContext.Session.Keys.Any(pr => pr == "CarId") == true ? BitConverter.ToInt32(HttpContext.Session.Get("CarId")) : 0;

                var vrModel = HttpContext.Session.GetString("_myModel");
                if(!string.IsNullOrEmpty(vrModel))
                myModel = JsonConvert.DeserializeObject<Lecture13>(vrModel);
            }

            return View(myModel);
        }

        //this is the modern model binding method
        [Route("/lecture13/update", Name = "lecture13update")]
        public IActionResult Update(Lecture13 myModel)
        {
            if (!ModelState.IsValid)
                return View(new Lecture13());

            HttpContext.Session.SetString("CarName", myModel.CarName);
            HttpContext.Session.Set("CarId", BitConverter.GetBytes(myModel.CarId));


            return View("index", myModel);
        }

        [Route("/lecture13/updateLegacy")]
        public IActionResult updateLegacy()
        {
            Lecture13 myModel = new Lecture13
            {
                CarName = HttpContext.Request.Form["CarName"]          
            };

            Int32.TryParse(HttpContext.Request.Form["CarId"], out myModel.CarId);

            foreach (var item in HttpContext.Request.Form)
            {
                myModel.FormProperties += "parameter name: " + item.Key + " parameter value: " + item.Value + "<br/>";
            }

            HttpContext.Session.SetString("_myModel", JsonConvert.SerializeObject(myModel));

            return View("index", myModel);
        }

        [Route("/lecture13/slidingcache")]
        public IActionResult slidingcache()
        {
            string cacheKey = "dateCacheKey";

            string cachedMessage = this._memoryCache.GetOrCreate(cacheKey, entry =>
            {
                // Create a fake delay of 3 seconds to simulate heavy processing...
                System.Threading.Thread.Sleep(3000);

               // entry.SetSlidingExpiration(TimeSpan.FromSeconds(15));


                entry.SetAbsoluteExpiration(TimeSpan.FromSeconds(15));

                return "Cache was last refreshed @ " + DateTime.Now+" seconds: " + DateTime.Now.Second;
            });

            return Content(cachedMessage);
        }
    }
}
