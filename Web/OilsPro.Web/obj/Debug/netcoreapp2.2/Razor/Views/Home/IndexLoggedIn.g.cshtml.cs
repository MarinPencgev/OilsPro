#pragma checksum "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Home\IndexLoggedIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49eac27f36e1310ea6983773329409de8a345751"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexLoggedIn), @"mvc.1.0.view", @"/Views/Home/IndexLoggedIn.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/IndexLoggedIn.cshtml", typeof(AspNetCore.Views_Home_IndexLoggedIn))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49eac27f36e1310ea6983773329409de8a345751", @"/Views/Home/IndexLoggedIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9a6442f2d3c4bfb2ce93c6b42858b62a85114ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexLoggedIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Home\IndexLoggedIn.cshtml"
  
    this.ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(50, 778, true);
            WriteLiteral(@"
<div class=""container-fluid ml-5"">
    <div class=""text-left"">
        <h1 class=""display-4"">UNCOMLETED ORDERS</h1>
    </div>
    <table class=""table table-hover"">
        <thead>
            <tr class=""row"">
                <th scope=""col"" class=""col-lg-1 suls-text-color"">Sequence</th>
                <th scope=""col"" class=""col-lg-2 suls-text-color"">Receiver</th>
                <th scope=""col"" class=""col-lg-1 suls-text-color"">Packs total count</th>
                <th scope=""col"" class=""col-lg-1 suls-text-color"">Packs total weight</th>
                <th scope=""col"" class=""col-lg-3 suls-text-color"">Delivery address</th>
                <th scope=""col"" class=""col-lg-4 suls-text-color"">Action</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 21 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Home\IndexLoggedIn.cshtml"
             foreach (var order in Model)
            {

#line default
#line hidden
            BeginContext(886, 91, true);
            WriteLiteral("                <tr class=\"row\">\r\n                    <td class=\"col-lg-1 suls-text-color\">");
            EndContext();
            BeginContext(978, 14, false);
#line 24 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Home\IndexLoggedIn.cshtml"
                                                    Write(order.Sequence);

#line default
#line hidden
            EndContext();
            BeginContext(992, 64, true);
            WriteLiteral("</td>\r\n                    <td class=\"col-lg-2 suls-text-color\">");
            EndContext();
            BeginContext(1057, 18, false);
#line 25 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Home\IndexLoggedIn.cshtml"
                                                    Write(order.ReceiverName);

#line default
#line hidden
            EndContext();
            BeginContext(1075, 64, true);
            WriteLiteral("</td>\r\n                    <td class=\"col-lg-1 suls-text-color\">");
            EndContext();
            BeginContext(1140, 26, false);
#line 26 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Home\IndexLoggedIn.cshtml"
                                                    Write(order.OrderedPackagesCount);

#line default
#line hidden
            EndContext();
            BeginContext(1166, 64, true);
            WriteLiteral("</td>\r\n                    <td class=\"col-lg-1 suls-text-color\">");
            EndContext();
            BeginContext(1231, 27, false);
#line 27 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Home\IndexLoggedIn.cshtml"
                                                    Write(order.OrderedPackagesWeight);

#line default
#line hidden
            EndContext();
            BeginContext(1258, 64, true);
            WriteLiteral("</td>\r\n                    <td class=\"col-lg-3 suls-text-color\">");
            EndContext();
            BeginContext(1323, 21, false);
#line 28 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Home\IndexLoggedIn.cshtml"
                                                    Write(order.DeliveryAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1344, 149, true);
            WriteLiteral("</td>\r\n                    <td class=\"col-lg-4 suls-text-color\">\r\n                        <div class=\"button-holder\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1493, "\"", 1530, 2);
            WriteAttributeValue("", 1500, "/Orders/Edit?id=", 1500, 16, true);
#line 31 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Home\IndexLoggedIn.cshtml"
WriteAttributeValue("", 1516, order.OrderId, 1516, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1531, 69, true);
            WriteLiteral(" class=\"btn btn-warning\">Complete</a>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1600, "\"", 1639, 2);
            WriteAttributeValue("", 1607, "/Orders/Remove?id=", 1607, 18, true);
#line 32 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Home\IndexLoggedIn.cshtml"
WriteAttributeValue("", 1625, order.OrderId, 1625, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1640, 71, true);
            WriteLiteral(" class=\"btn btn-warning\" id=\"remove\" data-toggle=\"modal\">Remove</a>\r\n\r\n");
            EndContext();
            BeginContext(1788, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 36 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Home\IndexLoggedIn.cshtml"
                             if (order.OrderedPackagesCount > 0)
                            {

#line default
#line hidden
            BeginContext(1887, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1921, "\"", 1961, 2);
            WriteAttributeValue("", 1928, "/Orders/Release?id=", 1928, 19, true);
#line 38 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Home\IndexLoggedIn.cshtml"
WriteAttributeValue("", 1947, order.OrderId, 1947, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1962, 38, true);
            WriteLiteral(" class=\"btn btn-warning\">Release</a>\r\n");
            EndContext();
#line 39 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Home\IndexLoggedIn.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2096, 83, true);
            WriteLiteral("                                <a class=\"btn btn-secondary disabled\">Release</a>\r\n");
            EndContext();
#line 43 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Home\IndexLoggedIn.cshtml"
                            }

#line default
#line hidden
            BeginContext(2210, 82, true);
            WriteLiteral("                        </div>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 47 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Home\IndexLoggedIn.cshtml"
            }

#line default
#line hidden
            BeginContext(2307, 641, true);
            WriteLiteral(@"            <tr class=""row"">
                <td class=""col-lg-1 suls-text-color"">-</td>
                <td class=""col-lg-2 suls-text-color"">-</td>
                <td class=""col-lg-1 suls-text-color"">-</td>
                <td class=""col-lg-1 suls-text-color"">-</td>
                <td class=""col-lg-3 suls-text-color"">-</td>
                <td class=""col-lg-4 suls-text-color"">
                    <div class=""button-holder"">
                        <a href=""/Orders/Create"" class=""btn btn-warning"">+ New Order</a>
                    </div>
                </td>
            </tr>
        </tbody>
    </table>
</div>

");
            EndContext();
            BeginContext(3004, 862, true);
            WriteLiteral(@"<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""myModal"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">ATENTION!</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Selected order will be removed! Are you sure!</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" id=""save"" >Proceed</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
