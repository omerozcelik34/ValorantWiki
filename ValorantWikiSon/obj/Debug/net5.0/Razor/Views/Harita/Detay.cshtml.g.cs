#pragma checksum "C:\Users\AÇILDIM KANKS\source\repos\ValorantWikiSon\ValorantWikiSon\Views\Harita\Detay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b01d10b9ac649b0bbce6e012ffe619ae8ca788d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Harita_Detay), @"mvc.1.0.view", @"/Views/Harita/Detay.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b01d10b9ac649b0bbce6e012ffe619ae8ca788d7", @"/Views/Harita/Detay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0412a31395dbcb11c340dddd58c44a8173200c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Harita_Detay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Harita>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container"" style=""margin-top: 100px;"" id=""about"">
    <div class=""news-content wow fadeInLeft animated"" data-wow-duration=""1s"" data-wow-delay=""600ms"" style=""visibility: visible; animation-duration: 1s; animation-delay: 600ms; animation-name: fadeInLeft;"">
        <div class=""entry-header"">
            <div class=""blog-image"" style=""width: 900px;"">
                <a href=""#""><img");
            BeginWriteAttribute("alt", " alt=\"", 413, "\"", 419, 0);
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 420, "\"", 438, 1);
#nullable restore
#line 6 "C:\Users\AÇILDIM KANKS\source\repos\ValorantWikiSon\ValorantWikiSon\Views\Harita\Detay.cshtml"
WriteAttributeValue("", 426, Model.Resim, 426, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\"></a>\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"entry-content\">\r\n            <h2 class=\"entry-title\">\r\n                <a href=\"blog.html\">");
#nullable restore
#line 12 "C:\Users\AÇILDIM KANKS\source\repos\ValorantWikiSon\ValorantWikiSon\Views\Harita\Detay.cshtml"
                               Write(Model.Isim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </h2>\r\n            <p>");
#nullable restore
#line 14 "C:\Users\AÇILDIM KANKS\source\repos\ValorantWikiSon\ValorantWikiSon\Views\Harita\Detay.cshtml"
          Write(Model.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Harita> Html { get; private set; }
    }
}
#pragma warning restore 1591
