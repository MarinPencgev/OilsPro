#pragma checksum "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58bc77fe55a350847f82848c2e3f78238b2f0ced"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Edit), @"mvc.1.0.view", @"/Views/Orders/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Edit.cshtml", typeof(AspNetCore.Views_Orders_Edit))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\_ViewImports.cshtml"
using OilsPro.Web;

#line default
#line hidden
#line 2 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\_ViewImports.cshtml"
using OilsPro.Web.Models;

#line default
#line hidden
#line 1 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
using System.Linq;

#line default
#line hidden
#line 2 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
using OilsPro.Web.Models.ViewModels;

#line default
#line hidden
#line 3 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
using OilsPro.Services;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58bc77fe55a350847f82848c2e3f78238b2f0ced", @"/Views/Orders/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9a6442f2d3c4bfb2ce93c6b42858b62a85114ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OilsPro.Web.Models.ViewModels.Order.CreateOrderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Include", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Js/GetAllProducts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Js/GetLotsByProduct.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(186, 239, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"button-holder col-2\" >\r\n        <a class=\"btn btn-warning\" id=\"back\" href=\"/\"><<< Back to active orders</a>\r\n    </div>\r\n    <div class=\"col-8\">\r\n        <h1 class=\"text-center suls-text-color\" >Order №");
            EndContext();
            BeginContext(426, 20, false);
#line 12 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                                   Write(Model.SequenceNumber);

#line default
#line hidden
            EndContext();
            BeginContext(446, 39, true);
            WriteLiteral("</h1>\r\n    </div>\r\n\r\n</div>\r\n\r\n<br />\r\n");
            EndContext();
            BeginContext(485, 6522, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58bc77fe55a350847f82848c2e3f78238b2f0ced6296", async() => {
                BeginContext(552, 113, true);
                WriteLiteral("\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n            <div class=\"col-4\">\r\n                ");
                EndContext();
                BeginContext(665, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58bc77fe55a350847f82848c2e3f78238b2f0ced6802", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 22 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CreatedOn);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(700, 41, true);
                WriteLiteral("\r\n                <p asp-for=\"CreatedOn\">");
                EndContext();
                BeginContext(742, 15, false);
#line 23 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                  Write(Model.CreatedOn);

#line default
#line hidden
                EndContext();
                BeginContext(757, 24, true);
                WriteLiteral("</p>\r\n\r\n                ");
                EndContext();
                BeginContext(781, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58bc77fe55a350847f82848c2e3f78238b2f0ced8822", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 25 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Purpose);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(814, 39, true);
                WriteLiteral("\r\n                <p asp-for=\"Purpose\">");
                EndContext();
                BeginContext(854, 13, false);
#line 26 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                Write(Model.Purpose);

#line default
#line hidden
                EndContext();
                BeginContext(867, 66, true);
                WriteLiteral("</p>\r\n\r\n                <input class=\"invisible\" id=\"Id\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 933, "\"", 950, 1);
#line 28 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
WriteAttributeValue("", 941, Model.Id, 941, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(951, 87, true);
                WriteLiteral(" />\r\n                <input class=\"invisible\" id=\"sequenceNumber\" name=\"sequenceNumber\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1038, "\"", 1067, 1);
#line 29 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
WriteAttributeValue("", 1046, Model.SequenceNumber, 1046, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1068, 74, true);
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col-4\">\r\n                ");
                EndContext();
                BeginContext(1142, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58bc77fe55a350847f82848c2e3f78238b2f0ced11862", async() => {
                    BeginContext(1172, 12, true);
                    WriteLiteral("Carrier name");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 32 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Carrier.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1192, 44, true);
                WriteLiteral("\r\n                <p asp-for=\"Carrier.Name\">");
                EndContext();
                BeginContext(1237, 18, false);
#line 33 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                     Write(Model.Carrier.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1255, 24, true);
                WriteLiteral("</p>\r\n\r\n                ");
                EndContext();
                BeginContext(1279, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58bc77fe55a350847f82848c2e3f78238b2f0ced14036", async() => {
                    BeginContext(1314, 14, true);
                    WriteLiteral("Vehicle number");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 35 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Vehicle.RegNumber);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1336, 49, true);
                WriteLiteral("\r\n                <p asp-for=\"Vehicle.RegNumber\">");
                EndContext();
                BeginContext(1386, 23, false);
#line 36 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                          Write(Model.Vehicle.RegNumber);

#line default
#line hidden
                EndContext();
                BeginContext(1409, 24, true);
                WriteLiteral("</p>\r\n\r\n                ");
                EndContext();
                BeginContext(1433, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58bc77fe55a350847f82848c2e3f78238b2f0ced16232", async() => {
                    BeginContext(1466, 11, true);
                    WriteLiteral("Driver name");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 38 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Driver.FullName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1485, 47, true);
                WriteLiteral("\r\n                <p asp-for=\"Driver.FullName\">");
                EndContext();
                BeginContext(1533, 21, false);
#line 39 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                        Write(Model.Driver.FullName);

#line default
#line hidden
                EndContext();
                BeginContext(1554, 75, true);
                WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-4\">\r\n                ");
                EndContext();
                BeginContext(1629, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58bc77fe55a350847f82848c2e3f78238b2f0ced18472", async() => {
                    BeginContext(1660, 13, true);
                    WriteLiteral("Receiver name");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 42 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Receiver.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1681, 45, true);
                WriteLiteral("\r\n                <p asp-for=\"Receiver.Name\">");
                EndContext();
                BeginContext(1727, 19, false);
#line 43 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                      Write(Model.Receiver.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1746, 24, true);
                WriteLiteral("</p>\r\n\r\n                ");
                EndContext();
                BeginContext(1770, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58bc77fe55a350847f82848c2e3f78238b2f0ced20651", async() => {
                    BeginContext(1803, 16, true);
                    WriteLiteral("Delivery address");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 45 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DeliveryAddress);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1827, 47, true);
                WriteLiteral("\r\n                <p asp-for=\"DeliveryAddress\">");
                EndContext();
                BeginContext(1875, 21, false);
#line 46 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                        Write(Model.DeliveryAddress);

#line default
#line hidden
                EndContext();
                BeginContext(1896, 771, true);
                WriteLiteral(@"</p>
            </div>
        </div>
    </div>
    <div class=""container-fluid"">
        <table class=""table table-hover mx-auto col-12"">
            <thead>
                <tr class=""row"">
                    <th scope=""col"" class=""col-lg-1 suls-text-color"">Seq Number</th>
                    <th scope=""col"" class=""col-lg-5 suls-text-color"">Product</th>
                    <th scope=""col"" class=""col-lg-2 suls-text-color"">Lot</th>
                    <th scope=""col"" class=""col-lg-1 suls-text-color"">Pack Count</th>
                    <th scope=""col"" class=""col-lg-1 suls-text-color"">Pack Weight</th>
                    <th scope=""col"" class=""col-lg-2 suls-text-color"">Action</th>
                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 63 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                  
                    int counter = 1;
                

#line default
#line hidden
                BeginContext(2744, 16, true);
                WriteLiteral("                ");
                EndContext();
#line 66 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                 foreach (var product in Model.OrderedProducts)
                {

#line default
#line hidden
                BeginContext(2828, 99, true);
                WriteLiteral("                    <tr class=\"row\">\r\n                        <td class=\"col-lg-1 suls-text-color\">");
                EndContext();
                BeginContext(2929, 9, false);
#line 69 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                                         Write(counter++);

#line default
#line hidden
                EndContext();
                BeginContext(2939, 68, true);
                WriteLiteral("</td>\r\n                        <td class=\"col-lg-5 suls-text-color\">");
                EndContext();
                BeginContext(3008, 27, false);
#line 70 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                                        Write(product.Product.ProductCode);

#line default
#line hidden
                EndContext();
                BeginContext(3035, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(3039, 20, false);
#line 70 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                                                                       Write(product.Product.Name);

#line default
#line hidden
                EndContext();
                BeginContext(3059, 68, true);
                WriteLiteral("</td>\r\n                        <td class=\"col-lg-2 suls-text-color\">");
                EndContext();
                BeginContext(3128, 24, false);
#line 71 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                                        Write(product.Lot.SerialNumber);

#line default
#line hidden
                EndContext();
                BeginContext(3152, 68, true);
                WriteLiteral("</td>\r\n                        <td class=\"col-lg-1 suls-text-color\">");
                EndContext();
                BeginContext(3221, 28, false);
#line 72 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                                        Write(product.OrderedPackagesCount);

#line default
#line hidden
                EndContext();
                BeginContext(3249, 68, true);
                WriteLiteral("</td>\r\n                        <td class=\"col-lg-1 suls-text-color\">");
                EndContext();
                BeginContext(3319, 44, false);
#line 73 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                                         Write(Math.Round(product.OrderedPackagesWeight, 0));

#line default
#line hidden
                EndContext();
                BeginContext(3364, 161, true);
                WriteLiteral("</td>\r\n                        <td class=\"col-lg-2 suls-text-color\">\r\n                            <div class=\"button-holder\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3525, "\"", 3586, 3);
                WriteAttributeValue("", 3532, "/Products/Remove?id=", 3532, 20, true);
#line 76 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
WriteAttributeValue("", 3552, product.OrderId, 3552, 16, false);

#line default
#line hidden
#line 76 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
WriteAttributeValue("", 3568, product.ProductId, 3568, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3587, 131, true);
                WriteLiteral(" class=\"btn btn-warning\">Remove</a>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
                EndContext();
#line 80 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                }

#line default
#line hidden
                BeginContext(3737, 703, true);
                WriteLiteral(@"                <tr class=""row"">
                    <td class=""col-lg-1 suls-text-color"">
                        <div>
                            <p>TOTAL</p>
                        </div>
                    </td>
                    <td class=""col-lg-5 suls-text-color"">
                        <div>
                            -
                        </div>
                    </td>
                    <td class=""col-lg-2 suls-text-color"">
                        <div>
                            -
                        </div>
                    </td>
                    <td class=""col-lg-1 suls-text-color"">
                        <div>
                            ");
                EndContext();
                BeginContext(4441, 78, false);
#line 99 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                       Write(Math.Round((decimal)Model.OrderedProducts.Sum(x => x.OrderedPackagesCount), 0));

#line default
#line hidden
                EndContext();
                BeginContext(4519, 180, true);
                WriteLiteral(";\r\n                        </div>\r\n                    </td>\r\n                    <td class=\"col-lg-1 suls-text-color\">\r\n                        <div>\r\n                            ");
                EndContext();
                BeginContext(4700, 67, false);
#line 104 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                       Write(Math.Round(Model.OrderedProducts.Sum(x => x.OrderedPackagesWeight)));

#line default
#line hidden
                EndContext();
                BeginContext(4767, 2032, true);
                WriteLiteral(@";
                        </div>
                    </td>
                    <td class=""col-lg-2 suls-text-color"">
                    </td>
                </tr>
                <tr class=""row"">
                    <td class=""col-lg-1 suls-text-color"">
                        <div>
                            <p>#</p>
                        </div>
                    </td>
                    <td class=""col-lg-5 suls-text-color"">
                        <div>
                            <select id=""products"" name=""product"" class=""form-control""></select>
                            <span class=""error-msg"" id=""productsErr""></span>
                        </div>
                    </td>
                    <td class=""col-lg-2 suls-text-color"">
                        <div>
                            <select id=""lots"" name=""lot"" class=""form-control""></select>
                            <span class=""error-msg"" id=""lotsErr""></span>
                        </div>
                    </t");
                WriteLiteral(@"d>
                    <td class=""col-lg-1 suls-text-color"">
                        <div>
                            <input id=""packagesCount"" name=""packagesCount"" class=""form-control"" required />
                            <span class=""text-danger""></span>
                        </div>
                    </td>
                    <td class=""col-lg-1 suls-text-color"">
                        <div>
                            ----
                        </div>
                    </td>
                    <td class=""col-lg-2 suls-text-color"">
                        <div class=""button-holder"">
                            <button class=""btn btn-warning"" id=""includeProduct"">Include Product</button>
                        </div>
                        <script type='text/javascript'>

                        </script>
                    </td>
                </tr>
            </tbody>
        </table>
        <div class=""container-fluid d-flex justify-content-end"">
");
                EndContext();
#line 151 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
             if (Model.OrderedProducts.Count > 0)
            {

#line default
#line hidden
                BeginContext(6865, 18, true);
                WriteLiteral("                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 6883, "\"", 6918, 2);
                WriteAttributeValue("", 6890, "/Orders/Release?id=", 6890, 19, true);
#line 153 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
WriteAttributeValue("", 6909, Model.Id, 6909, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6919, 38, true);
                WriteLiteral(" class=\"btn btn-warning\">Release</a>\r\n");
                EndContext();
#line 154 "C:\Projects\C#\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
            }

#line default
#line hidden
                BeginContext(6972, 28, true);
                WriteLiteral("        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7007, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(7011, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58bc77fe55a350847f82848c2e3f78238b2f0ced34832", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7057, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(7059, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58bc77fe55a350847f82848c2e3f78238b2f0ced36012", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7107, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOrdersService orderServices { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OilsPro.Web.Models.ViewModels.Order.CreateOrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591