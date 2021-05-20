using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_9.Controllers
{
    public class GlobalController : Controller
    {

        [Route("/Error", Name = "ErrorPage", Order = 0)]
        public IActionResult Index()
        {
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            if ((exceptionHandlerPathFeature != null) && (exceptionHandlerPathFeature.Error != null))
            {

                GlobalMethods.logErrors( _exceptionHandlerPathFeature: exceptionHandlerPathFeature);

                // In our example, the ExceptionHelper.LogException() method will take care of   
                // logging the exception to the database and perhaps even alerting the webmaster  
                // Make sure that this method doesn't throw any exceptions or you might end  
                // in an endless loop!  

            }

            return View("/Views/Error.cshtml");
        }

        [Route("/Error404", Name = "Error404", Order = 0)]
        public IActionResult Error404(int? irErrorCode = null)
        {
            var feature = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            myStatusCodeHandling myHandler = new myStatusCodeHandling(feature, irErrorCode);
            GlobalMethods.logErrors(_statusProblem: myHandler);

            return View("/Views/Error404.cshtml");
        }

        public class myStatusCodeHandling : IStatusCodeReExecuteFeature
        {
            public int? irStatusCode { get; set; }
            public string OriginalPathBase { get; set; }
            public string OriginalPath { get; set; }
            public string OriginalQueryString { get; set; }

            public myStatusCodeHandling(IStatusCodeReExecuteFeature _statusCode, int? _StatusCode)
            {
                OriginalPathBase = _statusCode.OriginalPathBase;
                OriginalPath = _statusCode.OriginalPath;
                OriginalQueryString = _statusCode.OriginalQueryString;
                irStatusCode = _StatusCode;
            }
        }


    }
}
