#pragma checksum "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df162d1b6420b0bb585b8534561498703dc37892"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowProduct), @"mvc.1.0.view", @"/Views/Home/ShowProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowProduct.cshtml", typeof(AspNetCore.Views_Home_ShowProduct))]
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
#line 1 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\_ViewImports.cshtml"
using ProductsandCategories;

#line default
#line hidden
#line 1 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowProduct.cshtml"
using ProductsandCategories.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df162d1b6420b0bb585b8534561498703dc37892", @"/Views/Home/ShowProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1338244e1b0b6ef81c8c667696120815a24a2a50", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowProduct.cshtml"
  
ViewData["Title"] = "Show Products";

#line default
#line hidden
            BeginContext(100, 154, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-4\"></div>\r\n        <div class=\"col\"> <br>\r\n            <h1 class=\"card-title\">");
            EndContext();
            BeginContext(255, 10, false);
#line 13 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowProduct.cshtml"
                              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(265, 217, true);
            WriteLiteral("</h1>\r\n        </div>\r\n        <div class=\"col-4\"></div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-sm\"> <br>\r\n            <div class=\"card-body\">\r\n                <h4>\r\n                    <p>Price: ");
            EndContext();
            BeginContext(483, 17, false);
#line 21 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowProduct.cshtml"
                         Write(Model.PriceString);

#line default
#line hidden
            EndContext();
            BeginContext(500, 62, true);
            WriteLiteral(" </p>\r\n                    <p class=\"card-text\"> Description: ");
            EndContext();
            BeginContext(563, 17, false);
#line 22 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowProduct.cshtml"
                                                  Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(580, 182, true);
            WriteLiteral("</p>\r\n                </h4>\r\n            </div>\r\n            <ul class=\"list-group list-group-flush\">\r\n                <li class=\"list-group-item font-weight-bold\">Categories:</li>\r\n");
            EndContext();
#line 27 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowProduct.cshtml"
                 foreach (var cat in Model.AssociatedCategories) {

#line default
#line hidden
            BeginContext(830, 44, true);
            WriteLiteral("                <li class=\"list-group-item\">");
            EndContext();
            BeginContext(875, 17, false);
#line 28 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowProduct.cshtml"
                                       Write(cat.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(892, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 29 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowProduct.cshtml"
                }

#line default
#line hidden
            BeginContext(918, 167, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div class=\"col-2\"> </div>\r\n        <div class=\"col-sm\"> <br>\r\n            <h5 class=\"my-4\">Add Category:</h5>\r\n            ");
            EndContext();
            BeginContext(1085, 488, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5ecec903948424d9f0deb2c94db4979", async() => {
                BeginContext(1152, 64, true);
                WriteLiteral("\r\n                <select name=\"Id\" class=\"form-control mb-3\">\r\n");
                EndContext();
#line 37 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowProduct.cshtml"
                     foreach (var category in ViewBag.UnassociatedCategories){

#line default
#line hidden
                BeginContext(1296, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(1316, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bf8e672d4fa41dab888d20eab971435", async() => {
                    BeginContext(1354, 13, false);
#line 38 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowProduct.cshtml"
                                                    Write(category.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 38 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowProduct.cshtml"
                       WriteLiteral(category.CategoryId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1376, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 39 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowProduct.cshtml"
                    }

#line default
#line hidden
                BeginContext(1401, 116, true);
                WriteLiteral("                </select>\r\n                <button type=\"submit\" class=\"btn btn-dark\">Add</button>\r\n                ");
                EndContext();
                BeginContext(1518, 34, false);
#line 42 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowProduct.cshtml"
           Write(Html.Raw(TempData["alertMessage"]));

#line default
#line hidden
                EndContext();
                BeginContext(1552, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1573, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591