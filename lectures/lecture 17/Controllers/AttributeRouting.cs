using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_9.Controllers
{
    [Route("/Items")]
    public class AttributeRouting : Controller
    {
        //https://localhost:44383/items/665
        [Route("{productid}")]
        public IActionResult Index(int productid)
        {
            Models.Product myproduct = new Models.Product();
            myproduct.itemid = productid;
            return View("/Views/attributes.cshtml", myproduct);
        }

        //https://localhost:44383/items/a32
        [Route("a{productid}")]
        public IActionResult Index2(int productid)
        {
            Models.Product myproduct = new Models.Product();
            myproduct.itemid = productid * productid;
            return View("/Views/attributes.cshtml", myproduct);
        }

        //https://localhost:44383/items/b100
        [Route("/items/b{productid}")]
        public IActionResult Index3(int productid)
        {
            Models.Product myproduct = new Models.Product();
            myproduct.itemid = productid / 5;
            return View("/Views/attributes.cshtml", myproduct);
        }

        //https://localhost:44383/items/product/32
        //https://localhost:44383/items/item/32
        [Route("/items/product/{productid}")]
        [Route("item/{productid}")]
        public IActionResult whateverthename(int productid)
        {
            Models.Product myproduct = new Models.Product();
            myproduct.itemid = productid * productid * productid;
            return View("/Views/attributes.cshtml", myproduct);
        }

        [Route("/blog/{entryId}/{slug}")]
        public IActionResult Blog(int entryId, string slug)
        {
            Models.Product myproduct = new Models.Product();
            myproduct.itemid = entryId;
            myproduct.slug = slug;
            return View("/Views/attributes.cshtml", myproduct);
        }

        [Route("/article/{key1}/{*key2}")]//https://localhost:44383/article/routing/routing/v2
        [Route("/article/{key1}/{key2?}")]//https://localhost:44383/article/routing
        public IActionResult entry(string key1, string key2)
        {
            var vrValue = DB.returnContent(key1, key2);
            if (string.IsNullOrEmpty(vrValue))
                return Content("no such article is found");

            return View("/Views/" + vrValue);
        }

        //        //action these words are not allowed as parameter names such as below
        //        area
        //        controller
        //handler
        //page
        //[Route("/article2/{action}/{key2?}")]//this will not work since have parameter named as action 
        //public IActionResult entry2(string action, string key2)
        //{
        //    var vrValue = DB.returnContent(action, key2);
        //    if (string.IsNullOrEmpty(vrValue))
        //        return Content("no such article is found");

        //    return View("/Views/" + vrValue);

        //}

        [Route("/cons/{key1}/{key2?}", Order = 3)]
        public IActionResult case1(string key1, string key2)
        {
            return Content ($"case1 {key1} : {key2}");
        }
        [Route("/cons/{key1:int}/{key2?}", Order = 4)]
        public IActionResult case2(int key1, string key2)
        {
            return Content($"case2 {key1} : {key2}");
        }

        [Route("/cons/{key1:bool}/{key2?}", Order = 5)]
        public IActionResult case3(bool key1, string key2)
        {
            return Content($"case3 {key1} : {key2}");
        }
        //        full list of constraints
        //        {entryId:int}
        //{isVisible:bool}
        //{entryDate:datetime}
        //{weight:double}
        //{weight:float}
        //{price:decimal}
        //{id:guid}
        //{postId:long}

        [Route("/cons/{key1:min(1)}/{key2?}", Order = 1)]
        public IActionResult case4(int key1, string key2)
        {
            return Content($"case4 {key1} : {key2}");
        }

        [Route("/cons/{key1:max(1)}/{key2?}", Order = 2)]
        public IActionResult case5(int key1, string key2)
        {
            return Content($"case5 {key1} : {key2}");
        }


        //https://asp.mvc-tutorial.com/routing/routing-constraints/
        //Length/range constraints
        //[Route("blog/{entryId:range(1, 999999)}/{slug}")]
        //[Route("blog/{entryId:range(1, 999999)}/{slug:minlength(3)}")]

        //Combining multiple constraints
        //[Route("blog/{entryId:int:range(1, 999999)}/{slug:minlength(3):maxlength(50)}")]

        //Regular Expression constraints
        //[Route(@"blog/{slug:regex(^[[0-9]]{{1,7}}\-[[a-z0-9\-]]{{3,50}}$)}")]  



        //https://devblogs.microsoft.com/aspnet/attribute-routing-in-asp-net-mvc-5/

        //        Constraint	Description	Example
        //alpha	Matches uppercase or lowercase Latin alphabet characters (a-z, A-Z)	{x:alpha}
        //bool	Matches a Boolean value.	{x:bool}
        //datetime	Matches a DateTime value.	{x:datetime}
        //decimal	Matches a decimal value.	{x:decimal}
        //double	Matches a 64-bit floating-point value.	{x:double}
        //float	Matches a 32-bit floating-point value.	{x:float}
        //guid	Matches a GUID value.	{x:guid}
        //int	Matches a 32-bit integer value.	{x:int}
        //length	Matches a string with the specified length or within a specified range of lengths.	{x:length(6)}
        //{x:length(1,20)}
        //long	Matches a 64-bit integer value.	{x:long}
        //max	Matches an integer with a maximum value.	{x:max(10)}
        //maxlength	Matches a string with a maximum length.	{x:maxlength(10)}
        //min	Matches an integer with a minimum value.	{x:min(10)}
        //minlength	Matches a string with a minimum length.	{x:minlength(10)}
        //range	Matches an integer within a range of values.	{x:range(10,50)}
        //regex	Matches a regular expression.	{x:regex(^\d{3}-\d{3}-\d{4}$)}
    }
}
