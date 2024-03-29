#pragma checksum "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2aac6ad602f77b97a963983c609f99963aee0d47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
#line 1 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\_ViewImports.cshtml"
using BELTEXAM;

#line default
#line hidden
#line 2 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\_ViewImports.cshtml"
using BELTEXAM.Models;

#line default
#line hidden
#line 1 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aac6ad602f77b97a963983c609f99963aee0d47", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4fa57ac9051b95d912f7fd452e415ef7ee54768", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 390, true);
            WriteLiteral(@"
<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">Activity</th>
            <th scope=""col"">Date and Time</th>
            <th scope=""col"">Duration</th>
            <th scope=""col"">Event Coordinator</th>
            <th scope=""col"">No. of Participants</th>
            <th scope=""col"">Actions</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 15 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml"
          
        int? seshUser = @Context.Session.GetInt32("ID");
        bool booked = false;
        foreach(var x in ViewBag.Activities)
        {

#line default
#line hidden
            BeginContext(582, 44, true);
            WriteLiteral("        <tr>\r\n            <th scope=\"row\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 626, "\"", 647, 2);
            WriteAttributeValue("", 633, "activity/", 633, 9, true);
#line 21 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml"
WriteAttributeValue("", 642, x.ID, 642, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(648, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(650, 7, false);
#line 21 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml"
                                                Write(x.Title);

#line default
#line hidden
            EndContext();
            BeginContext(657, 27, true);
            WriteLiteral("</a></th>\r\n            <td>");
            EndContext();
            BeginContext(685, 34, false);
#line 22 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml"
           Write(x.DateOfActivity.ToString("MM/dd"));

#line default
#line hidden
            EndContext();
            BeginContext(719, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(721, 16, false);
#line 22 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml"
                                               Write(x.Time.TimeOfDay);

#line default
#line hidden
            EndContext();
            BeginContext(737, 24, true);
            WriteLiteral(" </td>\r\n            <td>");
            EndContext();
            BeginContext(762, 10, false);
#line 23 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml"
           Write(x.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(772, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(774, 14, false);
#line 23 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml"
                       Write(x.DurationUnit);

#line default
#line hidden
            EndContext();
            BeginContext(788, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(812, 23, false);
#line 24 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml"
           Write(x.Coordinator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(835, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(859, 20, false);
#line 25 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml"
           Write(x.Participants.Count);

#line default
#line hidden
            EndContext();
            BeginContext(879, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 26 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml"
             if(x.CoordinatorID == (int)seshUser)
            {

#line default
#line hidden
            BeginContext(952, 18, true);
            WriteLiteral("            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 970, "\"", 990, 2);
            WriteAttributeValue("", 977, "/delete/", 977, 8, true);
#line 28 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml"
WriteAttributeValue("", 985, x.ID, 985, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(991, 64, true);
            WriteLiteral("><button class=\"btn btn-danger\">Call it off!</button></a></td>\r\n");
            EndContext();
#line 29 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml"
            }

#line default
#line hidden
            BeginContext(1070, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 30 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml"
             if(x.CoordinatorID != (int)seshUser)
            {
            bool going = false;
            foreach(var part in x.Participants)
            {
            if(part.User.ID == (int)seshUser)
            {
            going = true;
            }
            }
            if(going)
            {

#line default
#line hidden
            BeginContext(1390, 18, true);
            WriteLiteral("            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1408, "\"", 1428, 2);
            WriteAttributeValue("", 1415, "/UnRsvp/", 1415, 8, true);
#line 42 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml"
WriteAttributeValue("", 1423, x.ID, 1423, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1429, 66, true);
            WriteLiteral("><button class=\"btn btn-danger\">Leave Activity</button></a></td>\r\n");
            EndContext();
#line 43 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml"
            }
            else
            {
            foreach(var part in ViewBag.ActivitiesWithConflicts)
            {
            if(part.Activity.DateOfActivity == x.DateOfActivity)
            {
            booked = true;
            }
            }
            if(!booked)
            {

#line default
#line hidden
            BeginContext(1803, 18, true);
            WriteLiteral("            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1821, "\"", 1839, 2);
            WriteAttributeValue("", 1828, "/Rsvp/", 1828, 6, true);
#line 55 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml"
WriteAttributeValue("", 1834, x.ID, 1834, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1840, 66, true);
            WriteLiteral("><button class=\"btn btn-success\">Join Activity</button></a></td>\r\n");
            EndContext();
#line 56 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1954, 76, true);
            WriteLiteral("            <td><button class=\"btn\" disabled> You\'re booked!</button></td>\r\n");
            EndContext();
#line 60 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml"
            }
            }
            }

#line default
#line hidden
            BeginContext(2075, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 64 "C:\Users\Aleksandar\Downloads\CD\C#\ORMs\Entity\BELTEXAM\Views\Home\Home.cshtml"
        }
        

#line default
#line hidden
            BeginContext(2112, 112, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n<a href=\"newActivity\"><button class=\"btn btn-success\">Add New Activity!</button></a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
