#pragma checksum "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79de118ed2f03fb3ea3c48c7c31f6e37271a2990"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Show), @"mvc.1.0.view", @"/Views/Treats/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Treats/Show.cshtml", typeof(AspNetCore.Views_Treats_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79de118ed2f03fb3ea3c48c7c31f6e37271a2990", @"/Views/Treats/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b69af709270e91d24f70fedcc324573d65d2a20", @"/Views/_ViewImports.cshtml")]
    public class Views_Treats_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StoreFront.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
 if(@Model.Flavors.Count != 0)
{

#line default
#line hidden
            BeginContext(69, 8, true);
            WriteLiteral("  <ul>\r\n");
            EndContext();
#line 6 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
   foreach(var join in Model.Flavors)
  {

#line default
#line hidden
            BeginContext(121, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(130, 16, false);
#line 8 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
   Write(join.Flavor.Name);

#line default
#line hidden
            EndContext();
            BeginContext(146, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 9 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
     using (Html.BeginForm("DeleteFlavor", "Recipes"))
    {
      

#line default
#line hidden
            BeginContext(223, 42, false);
#line 11 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
 Write(Html.Hidden("joinId", @join.TreatFlavorId));

#line default
#line hidden
            EndContext();
            BeginContext(267, 45, true);
            WriteLiteral("      <input type=\"submit\" value=\"Delete\"/>\r\n");
            EndContext();
#line 13 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
    }

#line default
#line hidden
#line 13 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
     
  }

#line default
#line hidden
            BeginContext(324, 9, true);
            WriteLiteral("  </ul>\r\n");
            EndContext();
#line 16 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
}

#line default
#line hidden
            BeginContext(336, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(343, 36, false);
#line 18 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(379, 23, true);
            WriteLiteral("</h2>\r\n<hr />\r\n\r\n<h3>\r\n");
            EndContext();
#line 22 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
 switch(Model.Rating)
  {
    case 1:

#line default
#line hidden
            BeginContext(443, 183, true);
            WriteLiteral("      <i class=\"fas fa-star\"></i><i class=\"fas fa-star fas-faded\"></i><i class=\"fas fa-star fas-faded\"></i><i class=\"fas fa-star fas-faded\"></i><i class=\"fas fa-star fas-faded\"></i>\r\n");
            EndContext();
#line 26 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
      break;
    case 2:

#line default
#line hidden
            BeginContext(653, 173, true);
            WriteLiteral("      <i class=\"fas fa-star\"></i><i class=\"fas fa-star\"></i><i class=\"fas fa-star fas-faded\"></i><i class=\"fas fa-star fas-faded\"></i><i class=\"fas fa-star fas-faded\"></i>\r\n");
            EndContext();
#line 29 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
      break;
    case 3:

#line default
#line hidden
            BeginContext(853, 163, true);
            WriteLiteral("      <i class=\"fas fa-star\"></i><i class=\"fas fa-star\"></i><i class=\"fas fa-star\"></i><i class=\"fas fa-star fas-faded\"></i><i class=\"fas fa-star fas-faded\"></i>\r\n");
            EndContext();
#line 32 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
      break;
    case 4:

#line default
#line hidden
            BeginContext(1043, 153, true);
            WriteLiteral("      <i class=\"fas fa-star\"></i><i class=\"fas fa-star\"></i><i class=\"fas fa-star\"></i><i class=\"fas fa-star\"></i><i class=\"fas fa-star fas-faded\"></i>\r\n");
            EndContext();
#line 35 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
      break;
    case 5:

#line default
#line hidden
            BeginContext(1223, 143, true);
            WriteLiteral("      <i class=\"fas fa-star\"></i><i class=\"fas fa-star\"></i><i class=\"fas fa-star\"></i><i class=\"fas fa-star\"></i><i class=\"fas fa-star\"></i>\r\n");
            EndContext();
#line 38 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
      break;
  }

#line default
#line hidden
            BeginContext(1385, 14, true);
            WriteLiteral("</h3>\r\n\r\n\r\n<p>");
            EndContext();
            BeginContext(1400, 47, false);
#line 43 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(1450, 43, false);
#line 43 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
                                                Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1493, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
#line 45 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
 if(@Model.Flavors.Count != 0)
{

#line default
#line hidden
            BeginContext(1536, 8, true);
            WriteLiteral("  <ul>\r\n");
            EndContext();
#line 48 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
   foreach(var join in Model.Flavors)
  {

#line default
#line hidden
            BeginContext(1588, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(1597, 16, false);
#line 50 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
   Write(join.Flavor.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1613, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 51 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
     using (Html.BeginForm("DeleteFlavor", "Treats"))
    {
      

#line default
#line hidden
            BeginContext(1689, 42, false);
#line 53 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
 Write(Html.Hidden("joinId", @join.TreatFlavorId));

#line default
#line hidden
            EndContext();
            BeginContext(1733, 45, true);
            WriteLiteral("      <input type=\"submit\" value=\"Delete\"/>\r\n");
            EndContext();
#line 55 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
    }

#line default
#line hidden
#line 55 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
     
  }

#line default
#line hidden
            BeginContext(1790, 9, true);
            WriteLiteral("  </ul>\r\n");
            EndContext();
#line 58 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
}

#line default
#line hidden
            BeginContext(1802, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(1808, 40, false);
#line 60 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1848, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(1858, 65, false);
#line 61 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
Write(Html.ActionLink("Edit Treat", "Edit", new { id = Model.TreatId }));

#line default
#line hidden
            EndContext();
            BeginContext(1923, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(1933, 72, false);
#line 62 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
Write(Html.ActionLink("Add a Flavor", "AddFlavor", new { id = Model.TreatId }));

#line default
#line hidden
            EndContext();
            BeginContext(2005, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(2015, 69, false);
#line 63 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Treats\Show.cshtml"
Write(Html.ActionLink("Delete Treat", "Delete", new { id = Model.TreatId }));

#line default
#line hidden
            EndContext();
            BeginContext(2084, 4, true);
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
