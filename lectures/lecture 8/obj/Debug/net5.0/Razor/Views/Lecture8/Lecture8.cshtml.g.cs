#pragma checksum "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df3c522984113f0624098adda6c5944f601c3330"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lecture8_Lecture8), @"mvc.1.0.view", @"/Views/Lecture8/Lecture8.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df3c522984113f0624098adda6c5944f601c3330", @"/Views/Lecture8/Lecture8.cshtml")]
    public class Views_Lecture8_Lecture8 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<lecture_6.Models.Lecture8>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Lecture 8 Main Page</h1>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
 using (var form = Html.BeginForm("updateLecture8Model", "Lecture8"))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 15 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
Write(Html.LabelFor(m => m.irUserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 16 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
Write(Html.TextBoxFor(m => m.irUserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 17 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
Write(Html.ValidationMessageFor(m => m.irUserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 20 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
Write(Html.LabelFor(m => m.srFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 21 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
Write(Html.TextBoxFor(m => m.srFirstName, null, new { @placeholder = "enter your name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 22 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
Write(Html.ValidationMessageFor(m => m.srFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 25 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
Write(Html.LabelFor(m => m.srLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 26 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
Write(Html.TextBoxFor(m => m.srLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 27 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
Write(Html.ValidationMessageFor(m => m.srLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 30 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
Write(Html.LabelFor(m => m.srEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 31 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
Write(Html.TextBoxFor(m => m.srEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    ");
#nullable restore
#line 34 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
Write(Html.LabelFor(m => m.srEmailRepeated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 35 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
Write(Html.TextBoxFor(m => m.srEmailRepeated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <span style=\"background-color:blueviolet\">  ");
#nullable restore
#line 37 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
                                           Write(Html.ValidationMessageFor(m => m.srEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</div>\r\n");
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 41 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
Write(Html.LabelFor(m => m.dtBirthDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 42 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
Write(Html.TextBoxFor(m => m.dtBirthDay, "{0:yyyy-MM-dd}", new { type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 43 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
Write(Html.ValidationMessageFor(m => m.dtBirthDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Submit\" />\r\n");
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 51 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
   Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 53 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
 if (Model.srPostMessage != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"color:red;\">");
#nullable restore
#line 57 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
                       Write(Model.srPostMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 58 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 8\Views\Lecture8\Lecture8.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<lecture_6.Models.Lecture8> Html { get; private set; }
    }
}
#pragma warning restore 1591
