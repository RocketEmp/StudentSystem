#pragma checksum "C:\Users\SPowell4\OneDrive - KNEX\Desktop\tEST\School\Views\Home\Student.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9694a2cf661d3c0e02063e228689fbfa62892c71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Student), @"mvc.1.0.view", @"/Views/Home/Student.cshtml")]
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
#line 1 "C:\Users\SPowell4\OneDrive - KNEX\Desktop\tEST\School\Views\_ViewImports.cshtml"
using School;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\SPowell4\OneDrive - KNEX\Desktop\tEST\School\Views\Home\Student.cshtml"
using School.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9694a2cf661d3c0e02063e228689fbfa62892c71", @"/Views/Home/Student.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4035b931494fa1549d6ea6f2e0dd8aa05ecfb9a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Student : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"info\">\r\n");
#nullable restore
#line 10 "C:\Users\SPowell4\OneDrive - KNEX\Desktop\tEST\School\Views\Home\Student.cshtml"
     using (Html.BeginForm("Create", "Student", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>Enter Your Id:</span> ");
#nullable restore
#line 12 "C:\Users\SPowell4\OneDrive - KNEX\Desktop\tEST\School\Views\Home\Student.cshtml"
                               Write(Html.TextBoxFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <span>Enter Your Firstname: </span> ");
#nullable restore
#line 13 "C:\Users\SPowell4\OneDrive - KNEX\Desktop\tEST\School\Views\Home\Student.cshtml"
                                       Write(Html.TextBoxFor(m => m.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <span>Enter Your Lastname: </span>");
#nullable restore
#line 14 "C:\Users\SPowell4\OneDrive - KNEX\Desktop\tEST\School\Views\Home\Student.cshtml"
                                     Write(Html.TextBoxFor(m => m.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <span>Enter Your Course Id:</span> ");
#nullable restore
#line 15 "C:\Users\SPowell4\OneDrive - KNEX\Desktop\tEST\School\Views\Home\Student.cshtml"
                                      Write(Html.TextBoxFor(m => m.Course_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <span>Enter Your Enrollment Date: </span> ");
#nullable restore
#line 16 "C:\Users\SPowell4\OneDrive - KNEX\Desktop\tEST\School\Views\Home\Student.cshtml"
                                             Write(Html.TextBoxFor(m => m.Enrollment_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <span>Enter Your Course Status: </span>");
#nullable restore
#line 17 "C:\Users\SPowell4\OneDrive - KNEX\Desktop\tEST\School\Views\Home\Student.cshtml"
                                          Write(Html.TextBoxFor(m => m.Course_Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <span>Enter Your Grade: </span>");
#nullable restore
#line 18 "C:\Users\SPowell4\OneDrive - KNEX\Desktop\tEST\School\Views\Home\Student.cshtml"
                                  Write(Html.TextBoxFor(m => m.Grade));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <input id=\"Submit\" type=\"submit\" value=\"submit\" />\r\n");
#nullable restore
#line 20 "C:\Users\SPowell4\OneDrive - KNEX\Desktop\tEST\School\Views\Home\Student.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<style>
    .info {
        width: 34%;
        margin-left: 30%;
    }
    input {
        width: 100%;
        margin-top: 1%;
    }
    button {
        background-color: blue;
        color: white;
        border: 1 px solid transparent;
        margin-top: 2%;
    }
    </style>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
