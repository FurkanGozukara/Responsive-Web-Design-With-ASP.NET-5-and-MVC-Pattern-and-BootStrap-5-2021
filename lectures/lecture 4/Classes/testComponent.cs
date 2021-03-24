using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lecture_1.Models;

namespace lecture_1.Classes
{
    //[ViewComponent(Name = "TestComponent")]
    public class testComponent : ViewComponent//it will look views/shared/components/parsedcontroller/default
    {
        public async Task<IViewComponentResult> InvokeAsync(int idOfProduct = 100, bool delay = true)
        {
            Product myProduct = new Product { Id = idOfProduct, Price = 900, Title = "test product" };
            //return View("/Views/Shared/Components/testComponent/Parse.cshtml", myProduct);
            if (delay)
                System.Threading.Thread.Sleep(5000);
            return View("Parse", myProduct);
        }
    }
}
