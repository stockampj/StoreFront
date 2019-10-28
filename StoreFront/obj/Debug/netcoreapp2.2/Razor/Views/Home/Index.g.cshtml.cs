#pragma checksum "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1bda652f3b0e5d7adbd8cb166014698c588f200"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\_ViewImports.cshtml"
using StoreFront;

#line default
#line hidden
#line 1 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
using System;

#line default
#line hidden
#line 2 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#line 3 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
using System.Linq;

#line default
#line hidden
#line 4 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
using StoreFront.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1bda652f3b0e5d7adbd8cb166014698c588f200", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b69af709270e91d24f70fedcc324573d65d2a20", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StoreFront.Models.Treat>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(145, 59, true);
            WriteLiteral("\r\n<div>\r\n    <h1>Pierre\'s Pastery Treats</h1>\r\n</div>\r\n\r\n\r\n");
            EndContext();
#line 12 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
  
    int columnAssignment= 1;
    List<Treat> column1 = new List<Treat> {};
    List<Treat> column2 = new List<Treat> {};
    List<Treat> column3 = new List<Treat> {};
    List<Treat> column4 = new List<Treat> {};

    

#line default
#line hidden
#line 19 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
     foreach (Treat treat in Model)
    {
        

#line default
#line hidden
#line 21 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
         switch(columnAssignment)
        {
            case 1:
                column1.Add(treat);
                break;
            case 2:
                column2.Add(treat);
                break;
            case 3:
                column3.Add(treat);
                break;
            case 4:
                column4.Add(treat);
                break;
            default:
                break;
        }

#line default
#line hidden
#line 39 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
         if (columnAssignment >= 4)
        {
            columnAssignment = 1;
        }
        else
        {
            columnAssignment++;
        }

#line default
#line hidden
#line 46 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
          
    }

#line default
#line hidden
#line 47 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
     
    List<List<Treat>> columnHolder = new List<List<Treat>> {column1, column2, column3, column4};


#line default
#line hidden
            BeginContext(1176, 35, true);
            WriteLiteral("    <div class=\"info-holder row\">\r\n");
            EndContext();
#line 51 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
         foreach (List<Treat> column in columnHolder)
        {

#line default
#line hidden
            BeginContext(1277, 39, true);
            WriteLiteral("            <div class=\"info-column\">\r\n");
            EndContext();
#line 54 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
                 foreach (Treat treat in column)
                {

#line default
#line hidden
            BeginContext(1385, 42, true);
            WriteLiteral("                    <div class=\"info-item\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1427, "\"", 1446, 1);
#line 56 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
WriteAttributeValue("", 1432, treat.TreatId, 1432, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1447, 81, true);
            WriteLiteral(">\r\n                        <h4 class=\"info-header\">\r\n                            ");
            EndContext();
            BeginContext(1529, 10, false);
#line 58 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
                       Write(treat.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1539, 82, true);
            WriteLiteral("\r\n                        </h4>\r\n                        <p class=\"info-rating\">\r\n");
            EndContext();
#line 61 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
                          
                            string ratingOutput = "";
                            

#line default
#line hidden
#line 63 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
                             for (int l=1; l<=5; l++)
                            {
                                string star = "";
                                

#line default
#line hidden
#line 66 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
                                 if (l<=treat.Rating)
                                {                                
                                    star+= "<i class='fas fa-star'></i>";
                                }
                                else
                                {
                                    star+= "<i class='fas fa-star fas-faded'></i>";
                                }

#line default
#line hidden
#line 73 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
                                 
                                ratingOutput+= star;
                            }

#line default
#line hidden
            BeginContext(2380, 22, false);
#line 76 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
                       Write(Html.Raw(ratingOutput));

#line default
#line hidden
            EndContext();
#line 76 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
                                                   ;
                        

#line default
#line hidden
            BeginContext(2460, 112, true);
            WriteLiteral("                        </p>\r\n                        <p class=\"info-description\">\r\n                            ");
            EndContext();
            BeginContext(2573, 17, false);
#line 80 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
                       Write(treat.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2590, 86, true);
            WriteLiteral("\r\n                        </p>\r\n                        <ul class=\"info-tag-holder\">\r\n");
            EndContext();
#line 83 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
                             foreach(var join in treat.Flavors)
                            {

#line default
#line hidden
            BeginContext(2772, 53, true);
            WriteLiteral("                                <li class=\"info-tag\">");
            EndContext();
            BeginContext(2826, 16, false);
#line 85 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
                                                Write(join.Flavor.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2842, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 86 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2880, 59, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
            EndContext();
#line 89 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2958, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
#line 91 "C:\users\stock\desktop\Project.Solution\StoreFront\Views\Home\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(2991, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
            BeginContext(3006, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
