#pragma checksum "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\_ViewStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd956b0c83643e5e95c8aced238c5ad81472a64e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__ViewStart), @"mvc.1.0.view", @"/Views/_ViewStart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd956b0c83643e5e95c8aced238c5ad81472a64e", @"/Views/_ViewStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfb3352262b30da3a3228afaeb92576bb9c43fe5", @"/Views/_ViewImports.cshtml")]
    public class Views__ViewStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Furkan Gözükara\Desktop\mvc asp.net bootstrap\lectures\lecture 5\Views\_ViewStart.cshtml"
  
    Layout = "_MasterLayout";//this is working because layout is placed under views/shared with cshtml extension. therefore, i didnt have to provide full path ~/Views/Shared/_MasterLayout.cshtml

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>some values</div>");
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
