#pragma checksum "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3f9404beaa8cdde2353852bf41eaac2e00b4d82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Show), @"mvc.1.0.view", @"/Views/Flavors/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flavors/Show.cshtml", typeof(AspNetCore.Views_Flavors_Show))]
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
#line 2 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\_ViewImports.cshtml"
using StoreFront.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3f9404beaa8cdde2353852bf41eaac2e00b4d82", @"/Views/Flavors/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b69af709270e91d24f70fedcc324573d65d2a20", @"/Views/_ViewImports.cshtml")]
    public class Views_Flavors_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StoreFront.Models.Flavor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 31, true);
            WriteLiteral("\r\n<h2>Flavor</h2>\r\n<hr />\r\n<h3>");
            EndContext();
            BeginContext(66, 40, false);
#line 5 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Show.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(106, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(109, 36, false);
#line 5 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Show.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(145, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 7 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Show.cshtml"
 if(@Model.Treats.Count == 0)
{

#line default
#line hidden
            BeginContext(188, 47, true);
            WriteLiteral("  <p>This Flavor does not have any treats</p>\r\n");
            EndContext();
#line 10 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Show.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(247, 38, true);
            WriteLiteral("  <h4>Associated Treats</h4>\r\n  <ul>\r\n");
            EndContext();
#line 15 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Show.cshtml"
   foreach(var join in Model.Treats)
  {

#line default
#line hidden
            BeginContext(328, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(337, 15, false);
#line 17 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Show.cshtml"
   Write(join.Treat.Name);

#line default
#line hidden
            EndContext();
            BeginContext(352, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 18 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Show.cshtml"
  }

#line default
#line hidden
            BeginContext(364, 9, true);
            WriteLiteral("  </ul>\r\n");
            EndContext();
#line 20 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Show.cshtml"
}

#line default
#line hidden
            BeginContext(376, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(382, 43, false);
#line 22 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Show.cshtml"
Write(Html.ActionLink("Back to flavors", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(425, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(435, 78, false);
#line 23 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Show.cshtml"
Write(Html.ActionLink("Edit Flavor", "Edit", "Flavors", new { id = Model.FlavorId }));

#line default
#line hidden
            EndContext();
            BeginContext(513, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(523, 71, false);
#line 24 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Show.cshtml"
Write(Html.ActionLink("Delete Flavor", "Delete", new { id = Model.FlavorId }));

#line default
#line hidden
            EndContext();
            BeginContext(594, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StoreFront.Models.Flavor> Html { get; private set; }
    }
}
#pragma warning restore 1591
