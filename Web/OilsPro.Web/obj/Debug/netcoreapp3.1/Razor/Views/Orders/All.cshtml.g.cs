#pragma checksum "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83709c54cc6af87eb8eec3658f379f8e9410c626"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_All), @"mvc.1.0.view", @"/Views/Orders/All.cshtml")]
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
#line 1 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\_ViewImports.cshtml"
using OilsPro.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\_ViewImports.cshtml"
using OilsPro.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83709c54cc6af87eb8eec3658f379f8e9410c626", @"/Views/Orders/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9a6442f2d3c4bfb2ce93c6b42858b62a85114ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OilsPro.Data.Models.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
  
    ViewData["Title"] = "All";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"text-center suls-text-color\">COMPLETED ORDERS</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayNameFor(model => model.SequenceNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayNameFor(model => model.Purpose));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayNameFor(model => model.OilsUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayNameFor(model => model.DeliveryAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayNameFor(model => model.Receiver));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayNameFor(model => model.Carrier));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayNameFor(model => model.Driver));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayNameFor(model => model.Vehicle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Packages Count\r\n            </th>\r\n            <th>\r\n                Packages Weight\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 51 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
               Write(Html.DisplayFor(modelItem => item.SequenceNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
               Write(Html.DisplayFor(modelItem => item.Purpose));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
               Write(Html.DisplayFor(modelItem => item.OilsUser.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
                Write(item.DeliveryAddress.Town + ", " + item.DeliveryAddress.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
               Write(Html.DisplayFor(modelItem => item.Receiver.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
               Write(Html.DisplayFor(modelItem => item.Carrier.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 79 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
               Write(Html.DisplayFor(modelItem => item.Driver.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 82 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
               Write(Html.DisplayFor(modelItem => item.Vehicle.RegNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 85 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
               Write(item.Products.Sum(x => x.OrderedPackagesCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 88 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
               Write(item.Products.Sum(x => x.OrderedPackagesWeight).ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 91 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OilsPro.Data.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
