#pragma checksum "C:\Users\Aleksandar\Downloads\CD\C#\ASP.NET\MVC2\ViewModelsFun\Views\Home\user.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fff8239f86cf4250d169e04e641fd1be99349be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_user), @"mvc.1.0.view", @"/Views/Home/user.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/user.cshtml", typeof(AspNetCore.Views_Home_user))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fff8239f86cf4250d169e04e641fd1be99349be", @"/Views/Home/user.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a81a75cfaf1d772b53b0c424a0286222e9a36db2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_user : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 29, true);
            WriteLiteral("<h1>Here us a User</h1>\r\n<p> ");
            EndContext();
            BeginContext(43, 15, false);
#line 3 "C:\Users\Aleksandar\Downloads\CD\C#\ASP.NET\MVC2\ViewModelsFun\Views\Home\user.cshtml"
Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(58, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(60, 14, false);
#line 3 "C:\Users\Aleksandar\Downloads\CD\C#\ASP.NET\MVC2\ViewModelsFun\Views\Home\user.cshtml"
                Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(74, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
