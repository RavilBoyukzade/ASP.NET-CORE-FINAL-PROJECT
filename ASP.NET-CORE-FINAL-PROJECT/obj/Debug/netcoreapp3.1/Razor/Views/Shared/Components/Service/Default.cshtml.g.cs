#pragma checksum "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\Shared\Components\Service\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13a5a7219f5cb39ccac1f56aa6fbc2b51fe38b8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Service_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Service/Default.cshtml")]
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
#line 1 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\_ViewImports.cshtml"
using ASP.NET_CORE_FINAL_PROJECT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\_ViewImports.cshtml"
using ASP.NET_CORE_FINAL_PROJECT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13a5a7219f5cb39ccac1f56aa6fbc2b51fe38b8e", @"/Views/Shared/Components/Service/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd944af40feaedc2dd2a1e11d916a816e0f019e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Service_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ServiceViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2 col-sm-10 col-sm-offset-1"">
        <div class=""section-title-s2"">
            <span>Our best services</span>
            <h2>Best insurance services for our client’s</h2>
        </div>
    </div>
    <div class=""col col-xs-12"">
        <div class=""service-slider"">
");
#nullable restore
#line 36 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\Shared\Components\Service\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"grid\">\r\n            <a href=\"#\">\r\n                <i");
            BeginWriteAttribute("class", " class=\"", 1357, "\"", 1375, 1);
#nullable restore
#line 40 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\Shared\Components\Service\Default.cshtml"
WriteAttributeValue("", 1365, item.Logo, 1365, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                <h3>");
#nullable restore
#line 41 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\Shared\Components\Service\Default.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </a>\r\n        </div>\r\n");
#nullable restore
#line 44 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\Shared\Components\Service\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ServiceViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
