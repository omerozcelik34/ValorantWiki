#pragma checksum "C:\Users\AÇILDIM KANKS\source\repos\ValorantWikiSon\ValorantWikiSon\Views\Ajan\Detay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "792308757ea4a698cac6959b00983f0380b1391f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ajan_Detay), @"mvc.1.0.view", @"/Views/Ajan/Detay.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"792308757ea4a698cac6959b00983f0380b1391f", @"/Views/Ajan/Detay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0412a31395dbcb11c340dddd58c44a8173200c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Ajan_Detay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ajan>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""clients parallax"" id=""about"">
        <!-- Block Title -->
        <div class=""overlay"">
            <div class=""wrapper-block-clients"">
                <div class=""element-title"">
                    <div class=""row"">
                        <div class=""container"">
                            <h1 class=""main-color wow fadeInDown"" data-wow-duration=""1s"" data-wow-delay=""300ms"">");
#nullable restore
#line 9 "C:\Users\AÇILDIM KANKS\source\repos\ValorantWikiSon\ValorantWikiSon\Views\Ajan\Detay.cshtml"
                                                                                                           Write(Model.Isim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <h3 class=\"white-color wow fadeInUp\" data-wow-duration=\"1s\" data-wow-delay=\"300ms\">");
#nullable restore
#line 10 "C:\Users\AÇILDIM KANKS\source\repos\ValorantWikiSon\ValorantWikiSon\Views\Ajan\Detay.cshtml"
                                                                                                          Write(Model.Rol);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        </div>
                    </div>
                </div>
                <!-- End Block Title -->
                <div class=""row"">
                    <div class=""container"">
                        <div class=""wrapper-clients wow fadeInDown"" data-wow-duration=""1s"" data-wow-delay=""500ms"">
                            <!-- Start Testimonial Slider -->
                            <div class=""carousel slide carousel-mod"" data-ride=""carousel"" id=""testimonial"">
                                <div class=""carousel-inner"">
                                    <!-- Testimonial #1  -->
                                    <div class=""item active"">
                                        <div class=""row"">
                                            <div class=""col-lg-12 col-sm-12"">
                                                <div class=""testimonial-inner"">
                                                    <img class=""img-circle""");
            BeginWriteAttribute("src", " src=\"", 1536, "\"", 1551, 1);
#nullable restore
#line 26 "C:\Users\AÇILDIM KANKS\source\repos\ValorantWikiSon\ValorantWikiSon\Views\Ajan\Detay.cshtml"
WriteAttributeValue("", 1542, Model.Pp, 1542, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1552, "\"", 1558, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1559, "\"", 1567, 0);
            EndWriteAttribute();
            WriteLiteral(" /><!-- Testimonial Image  -->\r\n                                                    <p>");
#nullable restore
#line 27 "C:\Users\AÇILDIM KANKS\source\repos\ValorantWikiSon\ValorantWikiSon\Views\Ajan\Detay.cshtml"
                                                  Write(Model.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><!-- Tesimonial  -->\r\n                                                </div>\r\n                                                <h5>-- Valorant, ");
#nullable restore
#line 29 "C:\Users\AÇILDIM KANKS\source\repos\ValorantWikiSon\ValorantWikiSon\Views\Ajan\Detay.cshtml"
                                                            Write(Model.Isim);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" --</h5>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- End Testimonial #1  -->
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""wrapper-why-us"" style=""margin-bottom: 30%;"">
        <div class=""col-lg-3 col-sm-3 wow fadeInDown"" data-wow-duration=""1s"" data-wow-delay=""300ms"">
            <i class=""hovicon effect-1 sub-a""><img");
            BeginWriteAttribute("src", " src=\"", 2470, "\"", 2511, 2);
            WriteAttributeValue("", 2476, "/images/ajanlar/yetenekler/", 2476, 27, true);
#nullable restore
#line 44 "C:\Users\AÇILDIM KANKS\source\repos\ValorantWikiSon\ValorantWikiSon\Views\Ajan\Detay.cshtml"
WriteAttributeValue("", 2503, Model.C, 2503, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></i>\r\n            <h2>C YETENEĞİ</h2>\r\n            <p></p>\r\n        </div>\r\n        <div class=\"col-lg-3 col-sm-3 wow fadeInDown\" data-wow-duration=\"1s\" data-wow-delay=\"450ms\">\r\n            <i class=\"hovicon effect-1 sub-a\"><img");
            BeginWriteAttribute("src", " src=\"", 2743, "\"", 2784, 2);
            WriteAttributeValue("", 2749, "/images/ajanlar/yetenekler/", 2749, 27, true);
#nullable restore
#line 49 "C:\Users\AÇILDIM KANKS\source\repos\ValorantWikiSon\ValorantWikiSon\Views\Ajan\Detay.cshtml"
WriteAttributeValue("", 2776, Model.Q, 2776, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></i>\r\n            <h2>Q YETENEĞİ</h2>\r\n            <p></p>\r\n        </div>\r\n        <div class=\"col-lg-3 col-sm-3 wow fadeInDown\" data-wow-duration=\"1s\" data-wow-delay=\"600ms\">\r\n            <i class=\"hovicon effect-1 sub-a\"><img");
            BeginWriteAttribute("src", " src=\"", 3016, "\"", 3057, 2);
            WriteAttributeValue("", 3022, "/images/ajanlar/yetenekler/", 3022, 27, true);
#nullable restore
#line 54 "C:\Users\AÇILDIM KANKS\source\repos\ValorantWikiSon\ValorantWikiSon\Views\Ajan\Detay.cshtml"
WriteAttributeValue("", 3049, Model.E, 3049, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></i>\r\n            <h2>E YETENEĞİ</h2>\r\n            <p></p>\r\n        </div>\r\n        <div class=\"col-lg-3 col-sm-3 wow fadeInDown\" data-wow-duration=\"1s\" data-wow-delay=\"300ms\">\r\n            <i class=\"hovicon effect-1 sub-a\"><img");
            BeginWriteAttribute("src", " src=\"", 3289, "\"", 3330, 2);
            WriteAttributeValue("", 3295, "/images/ajanlar/yetenekler/", 3295, 27, true);
#nullable restore
#line 59 "C:\Users\AÇILDIM KANKS\source\repos\ValorantWikiSon\ValorantWikiSon\Views\Ajan\Detay.cshtml"
WriteAttributeValue("", 3322, Model.X, 3322, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></i>\r\n            <h2>X YETENEĞİ</h2>\r\n            <p></p>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ajan> Html { get; private set; }
    }
}
#pragma warning restore 1591
