#pragma checksum "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\CaseStudies\CaseSingle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5e85684d02ca81ddd98679361ad8a9c941ef9b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CaseStudies_CaseSingle), @"mvc.1.0.view", @"/Views/CaseStudies/CaseSingle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5e85684d02ca81ddd98679361ad8a9c941ef9b6", @"/Views/CaseStudies/CaseSingle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd944af40feaedc2dd2a1e11d916a816e0f019e5", @"/Views/_ViewImports.cshtml")]
    public class Views_CaseStudies_CaseSingle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CaseStudViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Page/_Title", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\CaseStudies\CaseSingle.cshtml"
  
    ViewData["Title"] = "CaseSingle";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f5e85684d02ca81ddd98679361ad8a9c941ef9b63813", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<!-- start project-single-section -->
<section class=""project-single-section section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-md-6"">
                <div class=""img-holder"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f5e85684d02ca81ddd98679361ad8a9c941ef9b65195", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 371, "~/uploads/", 371, 10, true);
#nullable restore
#line 13 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\CaseStudies\CaseSingle.cshtml"
AddHtmlAttributeValue("", 381, Model.Image, 381, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 13 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\CaseStudies\CaseSingle.cshtml"
AddHtmlAttributeValue("", 400, Model.Image, 400, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col col-md-6\">\r\n                <div class=\"project-details\">\r\n                    <h2>");
#nullable restore
#line 18 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\CaseStudies\CaseSingle.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h3>");
#nullable restore
#line 19 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\CaseStudies\CaseSingle.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 20 "D:\ASP.NET-CORE-FINAL-PROJECT\ASP.NET-CORE-FINAL-PROJECT\Views\CaseStudies\CaseSingle.cshtml"
                  Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"project-info\">\r\n");
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col col-xs-12\">\r\n                <div class=\"project-single-tab clearfix\">\r\n");
            WriteLiteral(@"                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col col-xs-12"">
                <div class=""related-case-studies"">
                    <h2>Related Case Studies</h2>
                    <div class=""case-studies-grids"">
                        <div class=""grid"">
                            <div class=""img-holder"">
                                <img src=""assets/images/case-studies/img-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2429, "\"", 2435, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""overlay"">
                                <div class=""content"">
                                    <p class=""cat"">Insurance</p>
                                    <h3><a href=""#"">Life insurance</a></h3>
                                </div>
                            </div>
                        </div>
                        <div class=""grid"">
                            <div class=""img-holder"">
                                <img src=""assets/images/case-studies/img-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3009, "\"", 3015, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""overlay"">
                                <div class=""content"">
                                    <p class=""cat"">Insurance</p>
                                    <h3><a href=""#"">Life insurance</a></h3>
                                </div>
                            </div>
                        </div>
                        <div class=""grid"">
                            <div class=""img-holder"">
                                <img src=""assets/images/case-studies/img-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3589, "\"", 3595, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""overlay"">
                                <div class=""content"">
                                    <p class=""cat"">Insurance</p>
                                    <h3><a href=""#"">Life insurance</a></h3>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div> <!-- end container -->
</section>
<!-- end project-single-section -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CaseStudViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
