#pragma checksum "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\CRUDeliciousC\CRUDelicious\Views\Home\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6136169e28a173019b39c20ba7e3a0eea421627"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_All), @"mvc.1.0.view", @"/Views/Home/All.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/All.cshtml", typeof(AspNetCore.Views_Home_All))]
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
#line 1 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\CRUDeliciousC\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 1 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\CRUDeliciousC\CRUDelicious\Views\Home\All.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6136169e28a173019b39c20ba7e3a0eea421627", @"/Views/Home/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\CRUDeliciousC\CRUDelicious\Views\Home\All.cshtml"
  
    ViewData["Title"] = "All Dishes";

#line default
#line hidden
            BeginContext(89, 92, true);
            WriteLiteral("\r\n<h3>Check out some recent dishes!</h3>\r\n<hr>\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n");
            EndContext();
#line 12 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\CRUDeliciousC\CRUDelicious\Views\Home\All.cshtml"
         for(int i= @ViewBag.AllDishes.Count-1; i >=0; i--)
        {

#line default
#line hidden
            BeginContext(253, 17, true);
            WriteLiteral("            <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 270, "\"", 305, 1);
#line 14 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\CRUDeliciousC\CRUDelicious\Views\Home\All.cshtml"
WriteAttributeValue("", 277, ViewBag.AllDishes[i].DishId, 277, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(306, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(308, 25, false);
#line 14 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\CRUDeliciousC\CRUDelicious\Views\Home\All.cshtml"
                                                 Write(ViewBag.AllDishes[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(333, 8, true);
            WriteLiteral("</a> by ");
            EndContext();
            BeginContext(342, 25, false);
#line 14 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\CRUDeliciousC\CRUDelicious\Views\Home\All.cshtml"
                                                                                   Write(ViewBag.AllDishes[i].Chef);

#line default
#line hidden
            EndContext();
            BeginContext(367, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 15 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\CRUDeliciousC\CRUDelicious\Views\Home\All.cshtml"
        }

#line default
#line hidden
            BeginContext(384, 100, true);
            WriteLiteral("    </div>\r\n    <div class=\"col-6\">\r\n        <a href=\"/new\">Add a Dish</a>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
