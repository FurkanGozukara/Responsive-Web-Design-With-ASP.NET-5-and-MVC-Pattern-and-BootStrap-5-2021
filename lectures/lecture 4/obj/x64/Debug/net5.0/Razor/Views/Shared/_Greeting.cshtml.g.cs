#pragma checksum "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Shared\_Greeting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0042f90e01282110af09cc6ee7e032fb10dae617"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Greeting), @"mvc.1.0.view", @"/Views/Shared/_Greeting.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0042f90e01282110af09cc6ee7e032fb10dae617", @"/Views/Shared/_Greeting.cshtml")]
    public class Views_Shared__Greeting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>Hello, world!</div>\r\n<div>Today is ");
#nullable restore
#line 2 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Shared\_Greeting.cshtml"
         Write(DateTime.Now.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Shared\_Greeting.cshtml"
  
    if (Model != null)
        if (Model is lecture_1.Models.Product)
        {
            var vrModel = Model as lecture_1.Models.Product;


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>model type is product and product price = ");
#nullable restore
#line 10 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Shared\_Greeting.cshtml"
                                                      Write(vrModel.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 11 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Shared\_Greeting.cshtml"
        }

    if (ViewData != null)
    {
        if (ViewData.ContainsKey("index"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>iteration count is ");
#nullable restore
#line 17 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Shared\_Greeting.cshtml"
                               Write(ViewData["index"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 18 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Shared\_Greeting.cshtml"
        }
        if (ViewData.ContainsKey("test"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>test is ");
#nullable restore
#line 21 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Shared\_Greeting.cshtml"
                    Write(ViewData["test"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 22 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Shared\_Greeting.cshtml"
        }
    }

    if (Model != null)
        if (Model is lecture_1.Models.Movie)
        {
            var vrModel = Model as lecture_1.Models.Movie;


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>model type is movie and movie release date = ");
#nullable restore
#line 30 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Shared\_Greeting.cshtml"
                                                         Write(vrModel.ReleaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 31 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Shared\_Greeting.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
