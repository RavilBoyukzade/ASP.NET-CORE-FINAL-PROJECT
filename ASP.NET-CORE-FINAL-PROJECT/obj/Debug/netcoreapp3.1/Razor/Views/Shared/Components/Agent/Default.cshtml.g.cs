#pragma checksum "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\Shared\Components\Agent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37a9ae685db11afc25471d9ef9c15ecec62a3978"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Agent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Agent/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37a9ae685db11afc25471d9ef9c15ecec62a3978", @"/Views/Shared/Components/Agent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd944af40feaedc2dd2a1e11d916a816e0f019e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Agent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AgentViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- start agents-section -->
<section class=""agents-section p-b-0 section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-xs-12"">
                <div class=""agents-area-with-title"">
                    <div class=""agents-grids clearfix"">
                        <div class=""grid"">
                            <div class=""section-title"">
                                <span>Agents</span>
                                <h2>Our Agents</h2>
                            </div>
                                <div class=""info"">
                                    <h3>+994505431392</h3>
                                    <h4>ravil@mail.ru</h4>
                                    <a href=""#"" class=""theme-btn"">More about us</a>
                                </div>
                        </div>
");
#nullable restore
#line 21 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\Shared\Components\Agent\Default.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"grid\">\r\n                                <div class=\"img-holder\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1133, "\"", 1158, 2);
            WriteAttributeValue("", 1139, "uploads/", 1139, 8, true);
#nullable restore
#line 25 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\Shared\Components\Agent\Default.cshtml"
WriteAttributeValue("", 1147, item.Photo, 1147, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1159, "\"", 1165, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </div>\r\n                                <div class=\"agent-info\">\r\n                                    <h4>");
#nullable restore
#line 28 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\Shared\Components\Agent\Default.cshtml"
                                   Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <p>");
#nullable restore
#line 29 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\Shared\Components\Agent\Default.cshtml"
                                  Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 32 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\Shared\Components\Agent\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div> <!-- end container -->\r\n</section>\r\n<!-- end agents-section -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AgentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
