#pragma checksum "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlannerrrr\Views\Home\DashBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a25fdcc05687fcd1ba18def1a4dc9b9eb610c82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DashBoard), @"mvc.1.0.view", @"/Views/Home/DashBoard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DashBoard.cshtml", typeof(AspNetCore.Views_Home_DashBoard))]
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
#line 1 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlannerrrr\Views\_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 1 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlannerrrr\Views\Home\DashBoard.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
#line 2 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlannerrrr\Views\Home\DashBoard.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a25fdcc05687fcd1ba18def1a4dc9b9eb610c82", @"/Views/Home/DashBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DashBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Wedding>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(89, 32, true);
            WriteLiteral("<h1>Welcome to Wedding Planner, ");
            EndContext();
            BeginContext(122, 37, false);
#line 5 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlannerrrr\Views\Home\DashBoard.cshtml"
                           Write(Context.Session.GetString("UserName"));

#line default
#line hidden
            EndContext();
            BeginContext(159, 387, true);
            WriteLiteral(@"!</h1>
<a href=""logout"">Log Out</a>
<a href=""newWedding"">New Wedding</a>

    <table class=""table"">
    <thead class=""thead-dark"">
        <tr>
        <th scope=""col"">WeddingID</th>
        <th scope=""col"">Fiancees</th>
        <th scope=""col"">Date</th>
        <th scope=""col"">Guests</th>
        <th scope=""col"">Action</th>
        </tr>
    </thead>
    <tbody>
    
");
            EndContext();
#line 21 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlannerrrr\Views\Home\DashBoard.cshtml"
      
        int? seshUser = @Context.Session.GetInt32("ID");
        
        foreach(var wedding in Model)
        {

#line default
#line hidden
            BeginContext(672, 50, true);
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
            EndContext();
            BeginContext(723, 17, false);
#line 27 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlannerrrr\Views\Home\DashBoard.cshtml"
                           Write(wedding.WeddingID);

#line default
#line hidden
            EndContext();
            BeginContext(740, 29, true);
            WriteLiteral("</th>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 769, "\"", 803, 2);
            WriteAttributeValue("", 776, "/wedding/", 776, 9, true);
#line 28 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlannerrrr\Views\Home\DashBoard.cshtml"
WriteAttributeValue("", 785, wedding.WeddingID, 785, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(804, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(806, 17, false);
#line 28 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlannerrrr\Views\Home\DashBoard.cshtml"
                                                     Write(wedding.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(823, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(827, 17, false);
#line 28 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlannerrrr\Views\Home\DashBoard.cshtml"
                                                                          Write(wedding.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(844, 31, true);
            WriteLiteral("</a></td>\r\n                <td>");
            EndContext();
            BeginContext(876, 43, false);
#line 29 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlannerrrr\Views\Home\DashBoard.cshtml"
               Write(wedding.When.ToString("dddd, MMMM dd yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(919, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(947, 19, false);
#line 30 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlannerrrr\Views\Home\DashBoard.cshtml"
               Write(wedding.RSVPs.Count);

#line default
#line hidden
            EndContext();
            BeginContext(966, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 31 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlannerrrr\Views\Home\DashBoard.cshtml"
                  
                    if(wedding.CreatorID == seshUser)
                    {

#line default
#line hidden
            BeginContext(1071, 30, true);
            WriteLiteral("                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1101, "\"", 1134, 2);
            WriteAttributeValue("", 1108, "/delete/", 1108, 8, true);
#line 34 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlannerrrr\Views\Home\DashBoard.cshtml"
WriteAttributeValue("", 1116, wedding.WeddingID, 1116, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1135, 18, true);
            WriteLiteral(">DELETE</a></td>\r\n");
            EndContext();
#line 35 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlannerrrr\Views\Home\DashBoard.cshtml"
                    }
                    else
                    {   
                        bool going = false;
                        foreach(var RSVP in wedding.RSVPs)
                        {
                            if(RSVP.User.UserId == (int)seshUser)
                            {
                                going = true;
                            }
                        }
                        if(going)
                        {

#line default
#line hidden
            BeginContext(1625, 34, true);
            WriteLiteral("                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1659, "\"", 1692, 2);
            WriteAttributeValue("", 1666, "/UnRSVP/", 1666, 8, true);
#line 48 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlannerrrr\Views\Home\DashBoard.cshtml"
WriteAttributeValue("", 1674, wedding.WeddingID, 1674, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1693, 19, true);
            WriteLiteral(">Un-RSVP</a></td>\r\n");
            EndContext();
#line 49 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlannerrrr\Views\Home\DashBoard.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1796, 34, true);
            WriteLiteral("                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1830, "\"", 1861, 2);
            WriteAttributeValue("", 1837, "/RSVP/", 1837, 6, true);
#line 52 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlannerrrr\Views\Home\DashBoard.cshtml"
WriteAttributeValue("", 1843, wedding.WeddingID, 1843, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1862, 16, true);
            WriteLiteral(">RSVP</a></td>\r\n");
            EndContext();
#line 53 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlannerrrr\Views\Home\DashBoard.cshtml"
                        }
                    }
                

#line default
#line hidden
            BeginContext(1947, 37, true);
            WriteLiteral("                \r\n            </tr>\r\n");
            EndContext();
#line 58 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlannerrrr\Views\Home\DashBoard.cshtml"
        }
    

#line default
#line hidden
            BeginContext(2002, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Wedding>> Html { get; private set; }
    }
}
#pragma warning restore 1591
