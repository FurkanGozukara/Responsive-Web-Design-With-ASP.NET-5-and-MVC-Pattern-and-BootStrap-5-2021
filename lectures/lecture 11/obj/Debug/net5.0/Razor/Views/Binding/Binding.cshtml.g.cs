#pragma checksum "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 11\Views\Binding\Binding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "785027125d51ea0935843c1729946d1ff2c2401d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Binding_Binding), @"mvc.1.0.view", @"/Views/Binding/Binding.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"785027125d51ea0935843c1729946d1ff2c2401d", @"/Views/Binding/Binding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f8963dd94f09a0a3323d1afa72f0224d7bb5a50", @"/Views/_ViewImports.cshtml")]
    public class Views_Binding_Binding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<lecture_9.Models.Lecture7>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 11\Views\Binding\Binding.cshtml"
 using (var form = Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 12 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 11\Views\Binding\Binding.cshtml"
   Write(Html.LabelFor(m => m.srFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 11\Views\Binding\Binding.cshtml"
   Write(Html.TextBoxFor(m => m.srFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 16 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 11\Views\Binding\Binding.cshtml"
   Write(Html.LabelFor(m => m.srLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 11\Views\Binding\Binding.cshtml"
   Write(Html.TextBoxFor(m => m.srLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Submit\" />\r\n");
#nullable restore
#line 21 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 11\Views\Binding\Binding.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 11\Views\Binding\Binding.cshtml"
 if (Model.srPostMessage != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"color:red;\">");
#nullable restore
#line 25 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 11\Views\Binding\Binding.cshtml"
                       Write(Model.srPostMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 26 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 11\Views\Binding\Binding.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<lecture_9.Models.Lecture7> Html { get; private set; }
    }
}
#pragma warning restore 1591
