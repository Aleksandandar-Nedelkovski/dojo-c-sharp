#pragma checksum "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\Login_RegisBella\Login_Regis\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "664b6b709d1a5c9ce47efa5db2fdeb070eebaf6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Result.cshtml", typeof(AspNetCore.Views_Home_Result))]
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
#line 1 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\Login_RegisBella\Login_Regis\Views\_ViewImports.cshtml"
using Login_Regis;

#line default
#line hidden
#line 1 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\Login_RegisBella\Login_Regis\Views\Home\Result.cshtml"
using Login_Regis.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"664b6b709d1a5c9ce47efa5db2fdeb070eebaf6b", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cec18e1bcb20a6ef2b76ecfbef50f88e8126910", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\Login_RegisBella\Login_Regis\Views\Home\Result.cshtml"
  
    ViewData["Title"] = "Login_Regis";

#line default
#line hidden
            BeginContext(85, 44, true);
            WriteLiteral("\n<h1>You signed up successfully!!!</h1>\n<h2>");
            EndContext();
            BeginContext(130, 15, false);
#line 9 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\Login_RegisBella\Login_Regis\Views\Home\Result.cshtml"
Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(145, 10, true);
            WriteLiteral("</h2>\n<h2>");
            EndContext();
            BeginContext(156, 14, false);
#line 10 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\Login_RegisBella\Login_Regis\Views\Home\Result.cshtml"
Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(170, 34, true);
            WriteLiteral("</h2>\n<a href=\"/Logout\">Logout</a>");
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
