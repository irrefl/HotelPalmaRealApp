#pragma checksum "C:\Users\Ariel\source\repos\HotelPalmaReal\HotelPalmaReal\Views\Hospedaje\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b71265740d0c31e91284747ef6db99b17f903343"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hospedaje_Index), @"mvc.1.0.view", @"/Views/Hospedaje/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Hospedaje/Index.cshtml", typeof(AspNetCore.Views_Hospedaje_Index))]
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
#line 1 "C:\Users\Ariel\source\repos\HotelPalmaReal\HotelPalmaReal\Views\_ViewImports.cshtml"
using HotelPalmaReal;

#line default
#line hidden
#line 2 "C:\Users\Ariel\source\repos\HotelPalmaReal\HotelPalmaReal\Views\_ViewImports.cshtml"
using HotelPalmaReal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b71265740d0c31e91284747ef6db99b17f903343", @"/Views/Hospedaje/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"422eaf8d030a1dd09b45948e9fc232d5c1eb4fc8", @"/Views/_ViewImports.cshtml")]
    public class Views_Hospedaje_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/food/rom1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/food/rom2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Ariel\source\repos\HotelPalmaReal\HotelPalmaReal\Views\Hospedaje\Index.cshtml"
  
    ViewData["Title"] = "Hospedaje";

#line default
#line hidden
            BeginContext(47, 368, true);
            WriteLiteral(@"
<section class=""section "" style=""margin-top:10em;"">
    <h1 class=""text-dark"">Nuestras Suits</h1>
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-6 col-lg-4 mb-5 aos-init aos-animate"" data-aos=""fade-up"">
                <a href=""#"" class=""room"">
                    <figure class=""img-wrap"">
                        ");
            EndContext();
            BeginContext(415, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b71265740d0c31e91284747ef6db99b17f9033434981", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(472, 790, true);
            WriteLiteral(@"
                    </figure>
                    <div class=""p-3 text-center room-info"">
                        <h2>Suit Personal</h2>
                        <span class=""text-uppercase letter-spacing-1"">90$ / por noche</span>
                    </div>


                </a>

                <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
                    <button type=""button"" class=""btn btn-primary"">Reservar</button>
                    <button type=""button"" class=""btn btn-secondary"">Ver</button>
                </div>
            </div>

            <div class=""col-md-6 col-lg-4 mb-5 aos-init aos-animate"" data-aos=""fade-up"">
                <a href=""#"" class=""room"">
                    <figure class=""img-wrap"">
                        ");
            EndContext();
            BeginContext(1262, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b71265740d0c31e91284747ef6db99b17f9033437051", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1319, 775, true);
            WriteLiteral(@"
                    </figure>
                    <div class=""p-3 text-center room-info"">
                        <h2>Suit Familiar</h2>
                        <span class=""text-uppercase letter-spacing-1"">120$ / por noche</span>
                    </div>
                </a>

                <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
                    <button type=""button"" class=""btn btn-primary"">Reservar</button>
                    <button type=""button"" class=""btn btn-secondary"">Ver</button>
                </div>
            </div>

            <div class=""col-md-6 col-lg-4 mb-5 aos-init"" data-aos=""fade-up"">
                <a href=""#"" class=""room"">
                    <figure class=""img-wrap"">
                        ");
            EndContext();
            BeginContext(2094, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b71265740d0c31e91284747ef6db99b17f9033439107", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2151, 637, true);
            WriteLiteral(@"
                    </figure>
                    <div class=""p-3 text-center room-info"">
                        <h2>Suit Presidencial</h2>
                        <span class=""text-uppercase letter-spacing-1"">250$ / por noche</span>
                    </div>
                </a>
                <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
                    <button type=""button"" class=""btn btn-primary"">Reservar</button>
                    <button type=""button"" class=""btn btn-secondary"">Ver</button>
                </div>
            </div>



        </div>
    </div>
</section>




");
            EndContext();
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
