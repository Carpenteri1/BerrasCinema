#pragma checksum "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c35a1933b82b133d7b2797e589ca45da311e3a6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\_ViewImports.cshtml"
using BerrasCinema;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\_ViewImports.cshtml"
using BerrasCinema.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c35a1933b82b133d7b2797e589ca45da311e3a6f", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17f7b7b8c1f36eac2d8e5b1282dbe5770407a9b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BerrasCinema.Models.Movies>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = "Available Movies";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>");
#nullable restore
#line 9 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\Movies\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\Movies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MovieName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\Movies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SeatsLeft));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\Movies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MovieStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\Movies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MovieDuration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\Movies\Index.cshtml"
         foreach (var item in Model)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\Movies\Index.cshtml"
             if (item.SeatsLeft.Equals(0))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\"color:red\">\r\n                    <td>\r\n                        ");
#nullable restore
#line 36 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\Movies\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MovieName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"Seats\">\r\n                        ");
#nullable restore
#line 39 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\Movies\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SeatsLeft));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\Movies\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MovieStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 45 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\Movies\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MovieDuration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 48 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\Movies\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\"color:black\">\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\Movies\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MovieName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"Seats\">\r\n                        ");
#nullable restore
#line 56 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\Movies\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SeatsLeft));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\Movies\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MovieStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\Movies\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MovieDuration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 65 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\Movies\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Admin\source\AspNet\BerrasCinema\BerrasCinema\Views\Movies\Index.cshtml"
             

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BerrasCinema.Models.Movies>> Html { get; private set; }
    }
}
#pragma warning restore 1591
