#pragma checksum "C:\Users\AÇILDIM KANKS\source\repos\ValorantWikiSon\ValorantWikiSon\Views\Home\Forum.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5898c287b787d91fe07689c24b7f73ab82e34f5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Forum), @"mvc.1.0.view", @"/Views/Home/Forum.cshtml")]
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
#line 1 "C:\Users\AÇILDIM KANKS\source\repos\ValorantWikiSon\ValorantWikiSon\Views\_ViewImports.cshtml"
using ValorantWikiSon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AÇILDIM KANKS\source\repos\ValorantWikiSon\ValorantWikiSon\Views\_ViewImports.cshtml"
using ValorantWikiSon.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5898c287b787d91fe07689c24b7f73ab82e34f5a", @"/Views/Home/Forum.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0412a31395dbcb11c340dddd58c44a8173200c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Forum : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("sign-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Forum"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""stay-in parallax"" id=""about"">
    <!-- Block Title -->
    <div class=""overlay"">
        <div class=""wrapper-block-stay-in"">
            <div class=""element-title"">
                <div class=""row"">
                    <div class=""container"">
                        <h1 class=""main-color wow fadeInDown"" data-wow-duration=""1s"" data-wow-delay=""300ms"">FORUM</h1>
                        <h3 class=""white-color wow fadeInUp"" data-wow-duration=""1s"" data-wow-delay=""300ms"">İletişimde Kal</h3>
                    </div>
                </div>
            </div>
            <!-- End Block Title -->
            <div class=""signup"">
                <div class=""row"">
                    <div class=""container"">
                        <div class=""sign_form wow fadeInLeft"" data-wow-duration=""1s"" data-wow-delay=""300ms"">
                            <!-- SUBSCRIPTION FORM -->
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5898c287b787d91fe07689c24b7f73ab82e34f5a5213", async() => {
                WriteLiteral(@"
                                <input type=""email"" name=""email"" placeholder=""E-Posta"" class=""form-control input-box"">
                                <input type=""submit"" value=""Kayıt Ol"">
                                <div id=""signup-error""></div>
                                <p>lütfen forumlarda spam yapmayın :)</p>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <!-- / END SUBSCRIPTION FORM -->
                        </div>
                    </div>
                </div>
            </div>

            <div class=""row"">
                <div class=""container"">
                    <div class=""wrapper-tweet"">
                        <!-- Twitter -->
                        <div class=""tweet wow fadeInRight"" data-wow-duration=""1s"" data-wow-delay=""700ms"">
                            <div class=""col-sm-8 col-sm-offset-2"">
                                <div class=""home-icon text-center"">
                                    <i class=""fa fa-home""></i>
                                    <h4>Benim sitem</h4>
                                </div>
                                <div id=""twitter-carousel"" class=""carousel slide"" data-ride=""carousel"">
                                    <ol class=""carousel-indicators"">
                                        <li data-target=""#twitter-carousel"" data-slide-to=""0"" class=""active""><");
            WriteLiteral(@"/li>
                                        <li data-target=""#twitter-carousel"" data-slide-to=""1""></li>
                                        <li data-target=""#twitter-carousel"" data-slide-to=""2""></li>
                                    </ol><!-- /.carousel-indicators -->

                                    <div class=""carousel-inner"">
                                        <div class=""item active"">
                                            Kolay Ve Anlaşılır
                                        </div>
                                        <div class=""item"">
                                            Hızlı Ve Güvenli
                                        </div>
                                        <div class=""item"">
                                            Sorunsuz Ve Gelişmeye Açık
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </");
            WriteLiteral("div>\r\n                        <!-- End Twitter -->\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
