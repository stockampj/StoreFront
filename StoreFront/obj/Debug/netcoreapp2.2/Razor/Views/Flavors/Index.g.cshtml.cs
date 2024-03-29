#pragma checksum "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a17842695472beb8a6134d7ae4d63abbdfb54b0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Index), @"mvc.1.0.view", @"/Views/Flavors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flavors/Index.cshtml", typeof(AspNetCore.Views_Flavors_Index))]
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
#line 1 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Index.cshtml"
using StoreFront.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a17842695472beb8a6134d7ae4d63abbdfb54b0f", @"/Views/Flavors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b69af709270e91d24f70fedcc324573d65d2a20", @"/Views/_ViewImports.cshtml")]
    public class Views_Flavors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StoreFront.Models.Flavor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 22, true);
            WriteLiteral("\r\n<h1>Flavors</h1>\r\n\r\n");
            EndContext();
#line 6 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(117, 44, true);
            WriteLiteral("  <h3>No flavors have been added yet!</h3>\r\n");
            EndContext();
#line 9 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Index.cshtml"
} 

#line default
#line hidden
            BeginContext(165, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Index.cshtml"
 foreach (Flavor flavor in Model)
{

#line default
#line hidden
            BeginContext(205, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(212, 71, false);
#line 13 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Index.cshtml"
 Write(Html.ActionLink($"{flavor.Name}", "Show", new { id = flavor.FlavorId }));

#line default
#line hidden
            EndContext();
            BeginContext(283, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 14 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Index.cshtml"
}

#line default
#line hidden
            BeginContext(293, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(335, 5, true);
            WriteLiteral("  <p>");
            EndContext();
            BeginContext(341, 43, false);
#line 18 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Index.cshtml"
Write(Html.ActionLink("Add new Flavor", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(384, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 19 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Flavors\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StoreFront.Models.Flavor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
