#pragma checksum "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\AddFlavor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b0da7d5ce0cad542e9b7aae94d63edb9856cd65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_AddFlavor), @"mvc.1.0.view", @"/Views/Treats/AddFlavor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Treats/AddFlavor.cshtml", typeof(AspNetCore.Views_Treats_AddFlavor))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0da7d5ce0cad542e9b7aae94d63edb9856cd65", @"/Views/Treats/AddFlavor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b69af709270e91d24f70fedcc324573d65d2a20", @"/Views/_ViewImports.cshtml")]
    public class Views_Treats_AddFlavor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StoreFront.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 58, true);
            WriteLiteral("\r\n<h2>Add a flavor</h2>\r\n\r\n<h4>Add a flavor to this task: ");
            EndContext();
            BeginContext(91, 36, false);
#line 5 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\AddFlavor.cshtml"
                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(127, 9, true);
            WriteLiteral("</h4>\r\n\r\n");
            EndContext();
#line 7 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\AddFlavor.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(171, 38, false);
#line 9 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\AddFlavor.cshtml"
Write(Html.HiddenFor(model => model.TreatId));

#line default
#line hidden
            EndContext();
            BeginContext(218, 24, false);
#line 11 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\AddFlavor.cshtml"
Write(Html.Label("Select tag"));

#line default
#line hidden
            EndContext();
            BeginContext(249, 29, false);
#line 12 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\AddFlavor.cshtml"
Write(Html.DropDownList("FlavorId"));

#line default
#line hidden
            EndContext();
            BeginContext(282, 42, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\r\n");
            EndContext();
#line 15 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\AddFlavor.cshtml"
}

#line default
#line hidden
            BeginContext(327, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(333, 40, false);
#line 17 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\AddFlavor.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(373, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StoreFront.Models.Treat> Html { get; private set; }
    }
}
#pragma warning restore 1591
