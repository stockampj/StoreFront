#pragma checksum "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbbf39a02df60a150c10003e40a7bac34acadf83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Index), @"mvc.1.0.view", @"/Views/Treats/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Treats/Index.cshtml", typeof(AspNetCore.Views_Treats_Index))]
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
#line 1 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\_ViewImports.cshtml"
using StoreFront;

#line default
#line hidden
#line 1 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Index.cshtml"
using StoreFront.Models;

#line default
#line hidden
#line 2 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbbf39a02df60a150c10003e40a7bac34acadf83", @"/Views/Treats/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b69af709270e91d24f70fedcc324573d65d2a20", @"/Views/_ViewImports.cshtml")]
    public class Views_Treats_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StoreFront.Models.Treat>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(103, 45, true);
            WriteLiteral("\r\n<h4>Pierre\'s Scrumptious Offerings</h4>\r\n\r\n");
            EndContext();
#line 7 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Index.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(170, 8, true);
            WriteLiteral("  <ul>\r\n");
            EndContext();
#line 10 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Index.cshtml"
     foreach (Treat treat in Model)
    {

#line default
#line hidden
            BeginContext(222, 10, true);
            WriteLiteral("      <li>");
            EndContext();
            BeginContext(233, 68, false);
#line 12 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Index.cshtml"
     Write(Html.ActionLink($"{treat.Name}", "Show", new { id = treat.TreatId }));

#line default
#line hidden
            EndContext();
            BeginContext(301, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 13 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(315, 9, true);
            WriteLiteral("  </ul>\r\n");
            EndContext();
#line 15 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Index.cshtml"
} 
else
{

#line default
#line hidden
            BeginContext(337, 43, true);
            WriteLiteral("  <h3>No treats have been added yet!</h3>\r\n");
            EndContext();
#line 19 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Index.cshtml"
}

#line default
#line hidden
#line 20 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(423, 5, true);
            WriteLiteral("  <p>");
            EndContext();
            BeginContext(429, 42, false);
#line 22 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Index.cshtml"
Write(Html.ActionLink("Add new treat", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(471, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 23 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Index.cshtml"
}

#line default
#line hidden
            BeginContext(480, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(486, 40, false);
#line 25 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(526, 10, true);
            WriteLiteral("</p>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StoreFront.Models.Treat>> Html { get; private set; }
    }
}
#pragma warning restore 1591
