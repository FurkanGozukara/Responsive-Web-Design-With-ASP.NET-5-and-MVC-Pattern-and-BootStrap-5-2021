#pragma checksum "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db19fd1296cc7ddb74de23a3a7b85d0cd0cdae7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lecture14__ListTaskItems), @"mvc.1.0.view", @"/Views/Lecture14/_ListTaskItems.cshtml")]
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
#line 9 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\_ViewImports.cshtml"
using static lecture_9.GlobalMethods;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db19fd1296cc7ddb74de23a3a7b85d0cd0cdae7c", @"/Views/Lecture14/_ListTaskItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"726bffed9337dbeef8f2b70d93e13c12af941aa8", @"/Views/_ViewImports.cshtml")]
    public class Views_Lecture14__ListTaskItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<lecture_9.Models.Lecture14>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div> this below table is fully asynchronous with ajax</div>\r\n\r\n<table>\r\n");
#nullable restore
#line 13 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml"
     foreach (var item in Model.lstAllToDoItems)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <input type=\"checkbox\"");
            BeginWriteAttribute("checked", " checked=\"", 371, "\"", 393, 1);
#nullable restore
#line 17 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml"
WriteAttributeValue("", 381, item.IsDone, 381, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 394, "\"", 456, 5);
            WriteAttributeValue("", 404, "window.location.href", 404, 20, true);
            WriteAttributeValue(" ", 424, "=", 425, 2, true);
            WriteAttributeValue(" ", 426, "\'/lecture14/IsDone/", 427, 20, true);
#nullable restore
#line 17 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml"
WriteAttributeValue("", 446, item.Id, 446, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 454, "\';", 454, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 480, "\"", 515, 2);
            WriteAttributeValue("", 487, "/lecture14/EditTask/", 487, 20, true);
#nullable restore
#line 18 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml"
WriteAttributeValue("", 507, item.Id, 507, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 19 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </td>\r\n            <td class=\"text-right\">\r\n                ");
#nullable restore
#line 23 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml"
           Write(item.AddDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 25 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml"
              
                var deleteMsg = "Are you sure to delete " + item.Title + " ?";
                deleteMsg = "'" + System.Web.HttpUtility.JavaScriptStringEncode(deleteMsg) + "'";
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <td class=\"text-center\">\r\n                <a data-ajax=\"true\"  data-ajax-complete=\"loadListOfItems\"");
            BeginWriteAttribute("href", " href=\"", 1023, "\"", 1056, 2);
            WriteAttributeValue("", 1030, "/lecture14/Delete/", 1030, 18, true);
#nullable restore
#line 31 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml"
WriteAttributeValue("", 1048, item.Id, 1048, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1057, "\"", 1094, 4);
            WriteAttributeValue("", 1067, "return", 1067, 6, true);
            WriteAttributeValue(" ", 1073, "confirm(", 1074, 9, true);
#nullable restore
#line 31 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml"
WriteAttributeValue("", 1082, deleteMsg, 1082, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1092, ");", 1092, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-danger\">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<div> this below table is not fully asynchronous with ajax</div>\r\n\r\n<table>\r\n");
#nullable restore
#line 40 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml"
     foreach (var item in Model.lstAllToDoItems)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <input type=\"checkbox\"");
            BeginWriteAttribute("checked", " checked=\"", 1395, "\"", 1417, 1);
#nullable restore
#line 44 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml"
WriteAttributeValue("", 1405, item.IsDone, 1405, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1418, "\"", 1480, 5);
            WriteAttributeValue("", 1428, "window.location.href", 1428, 20, true);
            WriteAttributeValue(" ", 1448, "=", 1449, 2, true);
            WriteAttributeValue(" ", 1450, "\'/lecture14/IsDone/", 1451, 20, true);
#nullable restore
#line 44 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml"
WriteAttributeValue("", 1470, item.Id, 1470, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1478, "\';", 1478, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1504, "\"", 1539, 2);
            WriteAttributeValue("", 1511, "/lecture14/EditTask/", 1511, 20, true);
#nullable restore
#line 45 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml"
WriteAttributeValue("", 1531, item.Id, 1531, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 46 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </td>\r\n            <td class=\"text-right\">\r\n                ");
#nullable restore
#line 50 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml"
           Write(item.AddDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 52 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml"
              
                var deleteMsg = "Are you sure to delete " + item.Title + " ?";
                deleteMsg = "'" + System.Web.HttpUtility.JavaScriptStringEncode(deleteMsg) + "'";
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <td class=\"text-center\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1992, "\"", 2025, 2);
            WriteAttributeValue("", 1999, "/lecture14/Delete/", 1999, 18, true);
#nullable restore
#line 58 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml"
WriteAttributeValue("", 2017, item.Id, 2017, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2026, "\"", 2063, 4);
            WriteAttributeValue("", 2036, "return", 2036, 6, true);
            WriteAttributeValue(" ", 2042, "confirm(", 2043, 9, true);
#nullable restore
#line 58 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml"
WriteAttributeValue("", 2051, deleteMsg, 2051, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2061, ");", 2061, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-danger\">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 61 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 14 v2\Views\Lecture14\_ListTaskItems.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<lecture_9.MyOptions> OptionsAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<lecture_9.Models.Lecture14> Html { get; private set; }
    }
}
#pragma warning restore 1591
