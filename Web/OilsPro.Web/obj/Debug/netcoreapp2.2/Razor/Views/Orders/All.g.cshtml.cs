#pragma checksum "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12fd8d31b7d83a023a6a2f646674373430f653f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_All), @"mvc.1.0.view", @"/Views/Orders/All.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/All.cshtml", typeof(AspNetCore.Views_Orders_All))]
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
#line 1 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\_ViewImports.cshtml"
using OilsPro.Web;

#line default
#line hidden
#line 2 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\_ViewImports.cshtml"
using OilsPro.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12fd8d31b7d83a023a6a2f646674373430f653f1", @"/Views/Orders/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9a6442f2d3c4bfb2ce93c6b42858b62a85114ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OilsPro.Data.Models.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
  
    ViewData["Title"] = "All";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 115, true);
            WriteLiteral("\r\n<h1>COMPLETED ORDERS</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(251, 50, false);
#line 14 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayNameFor(model => model.SequenceNumber));

#line default
#line hidden
            EndContext();
            BeginContext(301, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(357, 45, false);
#line 17 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(402, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(458, 47, false);
#line 20 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(505, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(561, 43, false);
#line 23 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayNameFor(model => model.Purpose));

#line default
#line hidden
            EndContext();
            BeginContext(604, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(660, 44, false);
#line 26 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayNameFor(model => model.OilsUser));

#line default
#line hidden
            EndContext();
            BeginContext(704, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(760, 51, false);
#line 29 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayNameFor(model => model.DeliveryAddress));

#line default
#line hidden
            EndContext();
            BeginContext(811, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(867, 44, false);
#line 32 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayNameFor(model => model.Receiver));

#line default
#line hidden
            EndContext();
            BeginContext(911, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(967, 43, false);
#line 35 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayNameFor(model => model.Carrier));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1066, 42, false);
#line 38 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayNameFor(model => model.Driver));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1164, 43, false);
#line 41 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayNameFor(model => model.Vehicle));

#line default
#line hidden
            EndContext();
            BeginContext(1207, 202, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Packages Count\r\n            </th>\r\n            <th>\r\n                Packages Weight\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 52 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1441, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1490, 49, false);
#line 55 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayFor(modelItem => item.SequenceNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1539, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1595, 44, false);
#line 58 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1639, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1695, 46, false);
#line 61 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1741, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1797, 42, false);
#line 64 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayFor(modelItem => item.Purpose));

#line default
#line hidden
            EndContext();
            BeginContext(1839, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1895, 52, false);
#line 67 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayFor(modelItem => item.OilsUser.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1947, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2004, 62, false);
#line 70 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
            Write(item.DeliveryAddress.Town + ", " + item.DeliveryAddress.Street);

#line default
#line hidden
            EndContext();
            BeginContext(2067, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2123, 48, false);
#line 73 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayFor(modelItem => item.Receiver.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2171, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2227, 47, false);
#line 76 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayFor(modelItem => item.Carrier.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2274, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2330, 50, false);
#line 79 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayFor(modelItem => item.Driver.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(2380, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2436, 52, false);
#line 82 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(Html.DisplayFor(modelItem => item.Vehicle.RegNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2488, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2544, 46, false);
#line 85 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(item.Products.Sum(x => x.OrderedPackagesCount));

#line default
#line hidden
            EndContext();
            BeginContext(2590, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2646, 65, false);
#line 88 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
           Write(item.Products.Sum(x => x.OrderedPackagesWeight).ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(2711, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 91 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\All.cshtml"
}

#line default
#line hidden
            BeginContext(2750, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OilsPro.Data.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
