#pragma checksum "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ce19885d25f183d444d5d62902a85789e44f74a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ce19885d25f183d444d5d62902a85789e44f74a", @"/Views/Product/Index.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<lecture_1.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>thread id ");
#nullable restore
#line 7 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Product\Index.cshtml"
          Write(System.Threading.Thread.CurrentThread.ManagedThreadId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\nbefore calling greeting async ");
#nullable restore
#line 8 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Product\Index.cshtml"
                         Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n");
#nullable restore
#line 10 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Product\Index.cshtml"
Write(Html.PartialAsync("_Greeting"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\nafter calling greeting async ");
#nullable restore
#line 12 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Product\Index.cshtml"
                        Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\nbefore calling greeting awaiting ");
#nullable restore
#line 14 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Product\Index.cshtml"
                            Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n");
#nullable restore
#line 16 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Product\Index.cshtml"
Write(await Html.PartialAsync("_Greeting"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\nafter calling greeting awaiting ");
#nullable restore
#line 18 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Product\Index.cshtml"
                           Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\ndefault product cshtml\r\n<hr />\r\n");
#nullable restore
#line 22 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Product\Index.cshtml"
  

    string vrTitle = (Model == null ? ViewBag.Title : Model.Title);
    double vrPrice = (Model == null ? ViewBag.Price : Model.Price);
    int vrId = (Model == null ? ViewBag.Id : Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br>\r\n<h1>");
#nullable restore
#line 30 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Product\Index.cshtml"
Write(vrTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\nPrice: ");
#nullable restore
#line 31 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Product\Index.cshtml"
  Write(vrPrice.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br>\r\nId=");
#nullable restore
#line 33 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Product\Index.cshtml"
Write(vrId.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br>\r\n");
#nullable restore
#line 35 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Product\Index.cshtml"
Write(ViewBag?.OtherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 39 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Product\Index.cshtml"
 for (int i = 0; i < 3; i++)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Product\Index.cshtml"
Write(await Html.PartialAsync("_Greeting", Model, new ViewDataDictionary(ViewData) { { "index", i } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 4\Views\Product\Index.cshtml"
                                                                                                     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<lecture_1.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
