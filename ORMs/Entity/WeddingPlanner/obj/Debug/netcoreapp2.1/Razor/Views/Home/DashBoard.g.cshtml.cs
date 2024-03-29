#pragma checksum "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\Home\DashBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfd82b15a1b8ae0b0032ce0415d01e2b2c2bfc04"
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
#line 1 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 1 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\Home\DashBoard.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
#line 2 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\Home\DashBoard.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfd82b15a1b8ae0b0032ce0415d01e2b2c2bfc04", @"/Views/Home/DashBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DashBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Wedding>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(87, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\Home\DashBoard.cshtml"
      
    ViewData["Title"] = "Dashboard";
    

#line default
#line hidden
            BeginContext(142, 141, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <h1>Welcome to the Wedding Planner, ");
            EndContext();
            BeginContext(284, 37, false);
#line 12 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\Home\DashBoard.cshtml"
                                               Write(Context.Session.GetString("UserName"));

#line default
#line hidden
            EndContext();
            BeginContext(321, 878, true);
            WriteLiteral(@"!</h1>
            </div>
            <div class=""col-2"">
                <a href=""logout""><button type=""submit"" class=""btn btn-danger btn-sm"">Log Out</button></a>
                <a href=""newwedding""><button type=""submit"" class=""btn btn-primary btn-sm"">New Wedding</button></a>
            </div>
        </div>
        <div class=""row"">
            <div class=""col""> <br>
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
#line 32 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\Home\DashBoard.cshtml"
                          
                        int? seshUser = @Context.Session.GetInt32("ID");
                        foreach(var wedding in Model)
                        {

#line default
#line hidden
            BeginContext(1383, 74, true);
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
            EndContext();
            BeginContext(1458, 17, false);
#line 37 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\Home\DashBoard.cshtml"
                                       Write(wedding.WeddingID);

#line default
#line hidden
            EndContext();
            BeginContext(1475, 41, true);
            WriteLiteral("</th>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1516, "\"", 1550, 2);
            WriteAttributeValue("", 1523, "/wedding/", 1523, 9, true);
#line 38 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\Home\DashBoard.cshtml"
WriteAttributeValue("", 1532, wedding.WeddingID, 1532, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1551, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1553, 17, false);
#line 38 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\Home\DashBoard.cshtml"
                                                                 Write(wedding.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(1570, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(1574, 17, false);
#line 38 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\Home\DashBoard.cshtml"
                                                                                      Write(wedding.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(1591, 43, true);
            WriteLiteral("</a></td>\r\n                            <td>");
            EndContext();
            BeginContext(1635, 43, false);
#line 39 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\Home\DashBoard.cshtml"
                           Write(wedding.When.ToString("dddd, MMMM dd yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1678, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1718, 19, false);
#line 40 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\Home\DashBoard.cshtml"
                           Write(wedding.RSVPs.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1737, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 41 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\Home\DashBoard.cshtml"
                              
                            if(wedding.CreatorID == seshUser)
                            {

#line default
#line hidden
            BeginContext(1870, 34, true);
            WriteLiteral("                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1904, "\"", 1937, 2);
            WriteAttributeValue("", 1911, "/delete/", 1911, 8, true);
#line 44 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\Home\DashBoard.cshtml"
WriteAttributeValue("", 1919, wedding.WeddingID, 1919, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1938, 18, true);
            WriteLiteral(">DELETE</a></td>\r\n");
            EndContext();
#line 45 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\Home\DashBoard.cshtml"
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
            BeginContext(2469, 34, true);
            WriteLiteral("                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2503, "\"", 2536, 2);
            WriteAttributeValue("", 2510, "/UnRSVP/", 2510, 8, true);
#line 58 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\Home\DashBoard.cshtml"
WriteAttributeValue("", 2518, wedding.WeddingID, 2518, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2537, 19, true);
            WriteLiteral(">Un-RSVP</a></td>\r\n");
            EndContext();
#line 59 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\Home\DashBoard.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2652, 34, true);
            WriteLiteral("                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2686, "\"", 2717, 2);
            WriteAttributeValue("", 2693, "/RSVP/", 2693, 6, true);
#line 62 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\Home\DashBoard.cshtml"
WriteAttributeValue("", 2699, wedding.WeddingID, 2699, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2718, 16, true);
            WriteLiteral(">RSVP</a></td>\r\n");
            EndContext();
#line 63 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\Home\DashBoard.cshtml"
                            }
                            }
                            

#line default
#line hidden
            BeginContext(2827, 31, true);
            WriteLiteral("                        </tr>\r\n");
            EndContext();
#line 67 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\WeddingPlanner\Views\Home\DashBoard.cshtml"
                        }
                        

#line default
#line hidden
            BeginContext(2912, 102, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>");
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
