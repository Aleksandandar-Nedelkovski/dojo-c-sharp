#pragma checksum "C:\Users\Aleksandar\Downloads\CD\C#\ASP.NET\MVC2\ViewModelsFun\Views\Home\numbers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7817de9c039c6fe035352fe704ab0188bac6d57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_numbers), @"mvc.1.0.view", @"/Views/Home/numbers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/numbers.cshtml", typeof(AspNetCore.Views_Home_numbers))]
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
#line 1 "C:\Users\Aleksandar\Downloads\CD\C#\ASP.NET\MVC2\ViewModelsFun\Views\_ViewImports.cshtml"
using ViewModelsFun;

#line default
#line hidden
#line 2 "C:\Users\Aleksandar\Downloads\CD\C#\ASP.NET\MVC2\ViewModelsFun\Views\_ViewImports.cshtml"
using ViewModelsFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7817de9c039c6fe035352fe704ab0188bac6d57", @"/Views/Home/numbers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a81a75cfaf1d772b53b0c424a0286222e9a36db2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_numbers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 32, true);
            WriteLiteral("<h1>Here are some numbers</h1>\r\n");
            EndContext();
#line 3 "C:\Users\Aleksandar\Downloads\CD\C#\ASP.NET\MVC2\ViewModelsFun\Views\Home\numbers.cshtml"
 foreach(var num in Model)
{

#line default
#line hidden
            BeginContext(77, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(85, 3, false);
#line 5 "C:\Users\Aleksandar\Downloads\CD\C#\ASP.NET\MVC2\ViewModelsFun\Views\Home\numbers.cshtml"
  Write(num);

#line default
#line hidden
            EndContext();
            BeginContext(88, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 6 "C:\Users\Aleksandar\Downloads\CD\C#\ASP.NET\MVC2\ViewModelsFun\Views\Home\numbers.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
