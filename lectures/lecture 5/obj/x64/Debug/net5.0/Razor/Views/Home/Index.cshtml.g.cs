#pragma checksum "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d507c37e95c24a217e118ca11ea9825ce733603"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\_ViewImports.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\_ViewImports.cshtml"
using lecture_1.Classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
using lecture_1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d507c37e95c24a217e118ca11ea9825ce733603", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfb3352262b30da3a3228afaeb92576bb9c43fe5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<lecture_1.Models.Movie>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d507c37e95c24a217e118ca11ea9825ce7336033758", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
#nullable restore
#line 13 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
      Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d507c37e95c24a217e118ca11ea9825ce7336035053", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 17 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
      
        ViewData["test"] = "this is home controller";
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
     for (int i = 0; i < 3; i++)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
   Write(await Html.PartialAsync("_Greeting", Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br />\r\n");
#nullable restore
#line 25 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n\r\n    <span style=\"font-size:25px; color:rebeccapurple;\">The movie <b>");
#nullable restore
#line 29 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                                                               Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b> was released ");
#nullable restore
#line 29 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                                                                                             Write(Model.ReleaseDate.ToLongDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n\r\n    <br />\r\n");
#nullable restore
#line 32 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
      
        string name = "Furkan Gözükara";
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <p>Hello, world - my name is ");
#nullable restore
#line 35 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                            Write(name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" and the current date is: ");
#nullable restore
#line 35 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                                                           Write(DateTime.Now.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 37 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
     if (Context.Request.Query["test"].ToString().Length > 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>Lots of markup here...</p>\r\n        <p>Test value: <b>");
#nullable restore
#line 40 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                     Write(Context.Request.Query["test"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></p>\r\n        <p>And even more here...</p>\r\n");
#nullable restore
#line 42 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
      
        var helloWorld = "<b>Hello, world!</b><script>alert('you are hacked!')</script>";
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <p>");
#nullable restore
#line 48 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
  Write(helloWorld);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
                WriteLiteral("\r\n    Hello, ");
#nullable restore
#line 51 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
       Write(name.Substring(0, 6));

#line default
#line hidden
#nullable disable
                WriteLiteral(". Your age is: <b>");
#nullable restore
#line 51 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                                                Write(17 + 5 + 3 + 4 + 5);

#line default
#line hidden
#nullable disable
                WriteLiteral(".</b>\r\n\r\n");
#nullable restore
#line 53 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
      
        var sum = 32 + 10;
        var greeting = "Hello, world!";
        var text = "";
        for (int i = 0; i < 5; i++)
        {
            text += greeting + " The result is: " + sum + i + "\n<br/>";
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <h2>CodeBlocks</h2>\r\n    Text: ");
#nullable restore
#line 64 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
     Write(Html.Raw(text));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 66 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
      
        var helloWorld2 = "This is a code block...";


#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>This is a tag with plain text and <b>markup</b> inside of it... ");
#nullable restore
#line 69 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                                                                        Write(helloWorld2);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </div>\r\n");
#nullable restore
#line 70 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"

        //This is plain text! this is invalid because you can not type plain text inside code block


#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                WriteLiteral("This is plain text! ");
                WriteLiteral("\r\n");
                WriteLiteral("This is plain text as well, and we can <br />\r\n            even span multiple lines, if needed!");
                WriteLiteral("\r\n");
#nullable restore
#line 151 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
          

        // C# style single-line comment

        /*
        C# style multiline comment
        It can span multiple lines
        */
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("\r\n    <hr>\r\n    <hr>\r\n\r\n");
#nullable restore
#line 166 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
      
        List<string> listofNames = new List<string> { "toros", "university", "mersin", "school" };
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <span>");
#nullable restore
#line 170 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
     Write(listofNames[0]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n\r\n    <div>");
#nullable restore
#line 172 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
    Write(listofNames[2]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n");
                WriteLiteral("        <ol>\r\n");
#nullable restore
#line 176 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
             foreach (var item in listofNames)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>something ");
#nullable restore
#line 178 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                         Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 179 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </ol>\r\n");
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 184 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
     if (DateTime.Now.Year == 2042)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <span>The year 2042 has finally arrived!</span>\r\n");
#nullable restore
#line 187 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 189 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
     if (DateTime.Now.Year == 2021)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <span style=\"display:block;\">The year 2021 has finally arrived!</span>\r\n");
                WriteLiteral("this means that");
#nullable restore
#line 193 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                                    
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 196 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
     if (DateTime.Now.Year >= 2042)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <span>The year 2042 has finally arrived!</span>\r\n");
#nullable restore
#line 199 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <span>We\'re still waiting for the year of 2042...</span>\r\n");
#nullable restore
#line 203 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br>\r\n    <hr>\r\n\r\n");
#nullable restore
#line 208 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
      
        List<string> names = new List<string>()
{
        "John Doe",
        "Jane Doe",
        "Joe Doe",
        "Jenna Doe",
        "Doggy Doe"
        };

        int counter = 0;
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <ul>\r\n        <li>following is for loop</li>\r\n");
#nullable restore
#line 223 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
         for (int i = 0; i < names.Count; i++)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li>");
#nullable restore
#line 225 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
           Write(names[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 226 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n\r\n    <ul>\r\n        <li>following is while loop</li>\r\n");
#nullable restore
#line 231 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
         while (counter < names.Count)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li>");
#nullable restore
#line 233 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
           Write(names[counter++]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 234 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n\r\n    <ul>\r\n        <li>following is do while loop</li>\r\n");
#nullable restore
#line 239 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
          
            counter = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 242 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
         do
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li>");
#nullable restore
#line 244 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
           Write(names[counter++]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 245 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
        } while (counter < names.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n\r\n\r\n    <ul>\r\n");
#nullable restore
#line 250 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
         for (int i = 0; i < names.Count; i++)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li>");
#nullable restore
#line 252 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
           Write(names[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 254 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
             if (i >= 2)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>...and so on</li>\r\n");
#nullable restore
#line 257 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"

                break;
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 259 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n\r\n");
#nullable restore
#line 263 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
     for (int i = 0; i < 100; i++)
    {
        switch (i)
        {
            case 1:

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div>number is 1</div>\r\n");
#nullable restore
#line 269 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                break;
            case 42:

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div>number is 42</div>\r\n");
#nullable restore
#line 272 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                break;
        }
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 277 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
     switch (DateTime.Now.DayOfWeek)
    {
        case DayOfWeek.Monday:

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span>Uh-oh... Monday</span>\r\n");
#nullable restore
#line 281 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
            break;
        case DayOfWeek.Friday:

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span>Weekend coming up!</span>\r\n");
#nullable restore
#line 284 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
            break;
        case DayOfWeek.Saturday:
        case DayOfWeek.Sunday:

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span>Finally weekend!</span>\r\n");
#nullable restore
#line 288 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
            break;
        default:

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span>Nothing special about this day...</span>\r\n");
#nullable restore
#line 291 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
            break;
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 295 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
      

        List<webUser> myWebUsers = new List<webUser>
{
                new webUser { Birthday = new DateTime(2000, 12, 1), FirstName = "Ayşe", LastName = "Demirci" },
                new webUser { FirstName = "Mehmet", LastName = "Boyacı" },
                new webUser { Birthday = new DateTime(1997, 3, 5), FirstName = "Hale", LastName = "Güçlü" }
        };

        void RenderUserInfo(webUser user)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"user-info\" style=\"color:brown;\">\r\n                ");
#nullable restore
#line 307 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
           Write(user.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 307 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                           Write(user.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" [");
#nullable restore
#line 307 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                                            Write(user.Birthday.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("]\r\n            </div>\r\n");
#nullable restore
#line 309 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
        }

    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <h2>Users [sorted asc by first name]</h2>\r\n\r\n");
#nullable restore
#line 315 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
     foreach (webUser myUser in myWebUsers.OrderBy(x => x.FirstName))
    {
        RenderUserInfo(myUser);
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <h2>Users [sorted asc by last name]</h2>\r\n");
#nullable restore
#line 321 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
     foreach (webUser myUser in myWebUsers.OrderBy(x => x.LastName))
    {
        RenderUserInfo(myUser);
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <h2>Users [sorted asc by birth date]</h2>\r\n");
#nullable restore
#line 327 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
     foreach (webUser myUser in myWebUsers.OrderBy(x => x.Birthday))
    {
        RenderUserInfo(myUser);
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 333 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
      
        ViewData["Title"] = "TemplatedDelegate";


#line default
#line hidden
#nullable disable
                WriteLiteral("        <h1>view data title = ");
#nullable restore
#line 336 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                         Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n");
#nullable restore
#line 337 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"

        Func<dynamic, object> movieTemplate = 

#line default
#line hidden
#nullable disable
                item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
                    PushWriter(__razor_template_writer);
                    WriteLiteral("<div>");
#nullable restore
#line 338 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                                               Write(item.Title);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" [");
#nullable restore
#line 338 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                                                            Write(item.ReleaseDate.ToShortDateString());

#line default
#line hidden
#nullable disable
                    WriteLiteral("]</div>");
                    PopWriter();
                }
                )
#nullable restore
#line 338 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                                                                                                             ;

string formatMovie(Movie myMovie)
{
return $"<div>{myMovie.Title.ToString()} [{myMovie.ReleaseDate.ToShortDateString()}]</div>";
}

List<Movie> movies = new List<Movie>();
movies.Add(new Movie() { Title = "The Godfather", ReleaseDate = new DateTime(1972, 3, 24) });
movies.Add(new Movie() { Title = "Forrest Gump", ReleaseDate = new DateTime(1994, 7, 6) });
movies.Add(new Movie() { Title = "Fight Club", ReleaseDate = new DateTime(1999, 10, 15) });

    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 352 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
     foreach (var movie in movies)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 354 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
   Write(movieTemplate(movie));

#line default
#line hidden
#nullable disable
#nullable restore
#line 354 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                             
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div>students in ViewData</div>\r\n    <ul>\r\n");
#nullable restore
#line 359 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
         foreach (var student in ViewData["Student"] as List<string>)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li>");
#nullable restore
#line 361 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
           Write(student);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 362 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n\r\n    <div>students in ViewBag</div>\r\n    <ul>\r\n");
#nullable restore
#line 367 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
         foreach (var student in ViewBag.Student)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li>");
#nullable restore
#line 369 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
           Write(student);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 370 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n\r\n");
#nullable restore
#line 373 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
      
        GlobalClasses.customGlobalClass csGClass = new GlobalClasses.customGlobalClass();
        csGClass.setRank(34545342);

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div style=\"font-size:22px;\">");
#nullable restore
#line 376 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                                Write(csGClass.returnRank());

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
                WriteLiteral("\r\n    <div>method way of movies - default html encoded</div>\r\n");
#nullable restore
#line 380 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
     foreach (var movie in movies)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 382 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
   Write(formatMovie(movie));

#line default
#line hidden
#nullable disable
#nullable restore
#line 382 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                           ;
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div>method way of movies - html raw</div>\r\n");
#nullable restore
#line 386 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
     foreach (var movie in movies)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 388 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
   Write(Html.Raw(formatMovie(movie)));

#line default
#line hidden
#nullable disable
#nullable restore
#line 388 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
                                     ;
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 392 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
     using (Html.BeginForm("Edit", "Home", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"hidden\" value=\"our first method action example\" name=\"srText\" />\r\n        <input type=\"submit\" value=\"post example\" />\r\n");
#nullable restore
#line 396 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 398 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
     using (Html.BeginForm("ContentExample", "Home", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"hidden\" value=\"test of ContentExample\" name=\"srText\" />\r\n        <input type=\"submit\" value=\"post example of ContentExample\" />\r\n");
#nullable restore
#line 402 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <hr /><hr />

    <div style=""text-align:center; padding:10px;"">

        <form action=""/Home/ContentExample"" method=""post"">
            <input type=""hidden"" name=""srText"" value=""test of ContentExample with html form - post method""><br>
            <input type=""submit"" value=""submit form example with classic html post method"">
        </form>

        <form action=""/Home/ContentExample"" method=""get"">
            <input type=""hidden"" name=""srText"" value=""test of ContentExample with html form - get method""><br>
            <input type=""submit"" value=""submit form example with classic html get method"">
        </form>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<lecture_1.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591