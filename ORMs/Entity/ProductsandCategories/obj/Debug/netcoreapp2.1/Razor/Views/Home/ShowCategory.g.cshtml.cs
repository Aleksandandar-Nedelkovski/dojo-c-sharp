#pragma checksum "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40f479298f4b99ec583c2bd1fec8dd7576f478dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowCategory), @"mvc.1.0.view", @"/Views/Home/ShowCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowCategory.cshtml", typeof(AspNetCore.Views_Home_ShowCategory))]
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
#line 1 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowCategory.cshtml"
using ProductsandCategories.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40f479298f4b99ec583c2bd1fec8dd7576f478dd", @"/Views/Home/ShowCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1338244e1b0b6ef81c8c667696120815a24a2a50", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowCategory.cshtml"
  
ViewData["Title"] = "Show Categories";

#line default
#line hidden
            BeginContext(103, 154, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-4\"></div>\r\n        <div class=\"col-4\"> <br>\r\n            <h1 class=\"card-title\">");
            EndContext();
            BeginContext(258, 10, false);
#line 12 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowCategory.cshtml"
                              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(268, 259, true);
            WriteLiteral(@"</h1>
        </div>
        <div class=""col-4""></div>
    </div>
    <div class=""row"">
        <div class=""col-sm""> <br>
            <ul class=""list-group list-group-flush"">
                <li class=""list-group-item font-weight-bold"">Products:</li>
");
            EndContext();
#line 20 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowCategory.cshtml"
                 foreach (var prod in Model.AssociatedProducts) {

#line default
#line hidden
            BeginContext(594, 44, true);
            WriteLiteral("                <li class=\"list-group-item\">");
            EndContext();
            BeginContext(639, 17, false);
#line 21 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowCategory.cshtml"
                                       Write(prod.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(656, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 22 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowCategory.cshtml"
                }

#line default
#line hidden
            BeginContext(682, 161, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div class=\"col-2\"> </div>\r\n        <div class=\"col-sm\">\r\n            <h5 class=\"my-4\">Add Product:</h5>\r\n            ");
            EndContext();
            BeginContext(843, 481, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a216d184fd9042a6ba35077478f49001", async() => {
                BeginContext(909, 64, true);
                WriteLiteral("\r\n                <select name=\"Id\" class=\"form-control mb-3\">\r\n");
                EndContext();
#line 30 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowCategory.cshtml"
                     foreach (var product in ViewBag.UnassociatedProducts){

#line default
#line hidden
                BeginContext(1050, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(1070, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf28e0fcbe95425d84a8e10a384d1925", async() => {
                    BeginContext(1106, 12, false);
#line 31 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowCategory.cshtml"
                                                  Write(product.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 31 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowCategory.cshtml"
                       WriteLiteral(product.ProductId);

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
                BeginContext(1127, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 32 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowCategory.cshtml"
                    }

#line default
#line hidden
                BeginContext(1152, 116, true);
                WriteLiteral("                </select>\r\n                <button type=\"submit\" class=\"btn btn-dark\">Add</button>\r\n                ");
                EndContext();
                BeginContext(1269, 34, false);
#line 35 "C:\Users\Aleksandar\Downloads\cd\C#\ORMs\Entity\ProductsandCategories\Views\Home\ShowCategory.cshtml"
           Write(Html.Raw(TempData["alertMessage"]));

#line default
#line hidden
                EndContext();
                BeginContext(1303, 14, true);
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
            BeginContext(1324, 36, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
