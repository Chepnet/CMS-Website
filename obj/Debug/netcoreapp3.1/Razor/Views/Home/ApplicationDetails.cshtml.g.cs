#pragma checksum "C:\Users\LabStudent-55-504266\source\repos\Content Management System\Views\Home\ApplicationDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98b31986698ed7757dc47ce711a9e44953f41acf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ApplicationDetails), @"mvc.1.0.view", @"/Views/Home/ApplicationDetails.cshtml")]
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
#line 1 "C:\Users\LabStudent-55-504266\source\repos\Content Management System\Views\_ViewImports.cshtml"
using Content_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LabStudent-55-504266\source\repos\Content Management System\Views\_ViewImports.cshtml"
using Content_Management_System.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98b31986698ed7757dc47ce711a9e44953f41acf", @"/Views/Home/ApplicationDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bfdd22a380e7358e06ee56095cf17fc84561a1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ApplicationDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Content_Management_System.Models.TrainingApplication>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LabStudent-55-504266\source\repos\Content Management System\Views\Home\ApplicationDetails.cshtml"
  
    ViewBag.Title = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2> Applicant details</h2>\r\n\r\n<div>\r\n    <h4>Farmers Training</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 15 "C:\Users\LabStudent-55-504266\source\repos\Content Management System\Views\Home\ApplicationDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.EventName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 19 "C:\Users\LabStudent-55-504266\source\repos\Content Management System\Views\Home\ApplicationDetails.cshtml"
       Write(Html.DisplayFor(model => model.EventName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 25 "C:\Users\LabStudent-55-504266\source\repos\Content Management System\Views\Home\ApplicationDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 29 "C:\Users\LabStudent-55-504266\source\repos\Content Management System\Views\Home\ApplicationDetails.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 33 "C:\Users\LabStudent-55-504266\source\repos\Content Management System\Views\Home\ApplicationDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 37 "C:\Users\LabStudent-55-504266\source\repos\Content Management System\Views\Home\ApplicationDetails.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 41 "C:\Users\LabStudent-55-504266\source\repos\Content Management System\Views\Home\ApplicationDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 45 "C:\Users\LabStudent-55-504266\source\repos\Content Management System\Views\Home\ApplicationDetails.cshtml"
       Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n");
            WriteLiteral("    ");
#nullable restore
#line 53 "C:\Users\LabStudent-55-504266\source\repos\Content Management System\Views\Home\ApplicationDetails.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("|\r\n\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Content_Management_System.Models.TrainingApplication> Html { get; private set; }
    }
}
#pragma warning restore 1591
