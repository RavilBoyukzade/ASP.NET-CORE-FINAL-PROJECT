#pragma checksum "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\Shared\Components\AboutCard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9c19997a9447c6ba3ea5f797c6894f7ff594c62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutCard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutCard/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9c19997a9447c6ba3ea5f797c6894f7ff594c62", @"/Views/Shared/Components/AboutCard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd944af40feaedc2dd2a1e11d916a816e0f019e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AboutCard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AboutCardViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\Shared\Components\AboutCard\Default.cshtml"
 foreach (var item in Model)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t  <div class=\"grid\">\r\n                <div class=\"icon\">\r\n                    <i");
            BeginWriteAttribute("class", " class=\"", 158, "\"", 176, 1);
#nullable restore
#line 7 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\Shared\Components\AboutCard\Default.cshtml"
WriteAttributeValue("", 166, item.Icon, 166, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                </div>\r\n                <h3>");
#nullable restore
#line 9 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\Shared\Components\AboutCard\Default.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <p>");
#nullable restore
#line 10 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\Shared\Components\AboutCard\Default.cshtml"
              Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 12 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\Shared\Components\AboutCard\Default.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AboutCardViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
