#pragma checksum "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Product\TestDynamic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86fbcd0ca099206fff4a55dd4908fc93cb2c4d07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_TestDynamic), @"mvc.1.0.view", @"/Views/Product/TestDynamic.cshtml")]
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
#line 1 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Product\TestDynamic.cshtml"
using lecture_1.Classes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86fbcd0ca099206fff4a55dd4908fc93cb2c4d07", @"/Views/Product/TestDynamic.cshtml")]
    public class Views_Product_TestDynamic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<script src=\"https://code.jquery.com/jquery-3.6.0.min.js\"\r\n        integrity=\"sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4=\"\r\n        crossorigin=\"anonymous\"></script>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Product\TestDynamic.cshtml"
  
    var vrFormatted = ((int)Model.rank).ToString("N0");

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>");
#nullable restore
#line 15 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Product\TestDynamic.cshtml"
   Write(vrFormatted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Product\TestDynamic.cshtml"
  
    //var vrFormatted2 = ((int)Model.Rank).ToString("N0"); this would throw run time error RuntimeBinderException since there is not field or property  named as Rank
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>time before Component.InvokeAsync ");
#nullable restore
#line 24 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Product\TestDynamic.cshtml"
                                  Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 26 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Product\TestDynamic.cshtml"
Write(Component.InvokeAsync(nameof(testComponent), new { idOfProduct = 321 , delay = false }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>time before await Component.InvokeAsyncc ");
#nullable restore
#line 28 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Product\TestDynamic.cshtml"
                                         Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 30 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Product\TestDynamic.cshtml"
Write(await Component.InvokeAsync(nameof(testComponent), new { idOfProduct = 321, delay = false }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\nhere we are async calling view component with ajax\r\n\r\n<div>time before ajax ");
#nullable restore
#line 34 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Product\TestDynamic.cshtml"
                 Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<script>\r\n    $.get(\"/product/GetMyViewComponent?idofproduct=38132012&delay=true\", function (data) {\r\n        $(document.body).append(data);\r\n    });\r\n</script>\r\n\r\n<div>time after ajax ");
#nullable restore
#line 42 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\Product\TestDynamic.cshtml"
                Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
