#pragma checksum "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab1c7960247c6402a494e6d6149583ee5b435997"
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
#line 1 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\_ViewImports.cshtml"
using OilsPro.Web;

#line default
#line hidden
#line 2 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\_ViewImports.cshtml"
using OilsPro.Web.Models;

#line default
#line hidden
#line 1 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
using System.Linq;

#line default
#line hidden
#line 2 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
using OilsPro.Web.Models.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
using OilsPro.Services;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab1c7960247c6402a494e6d6149583ee5b435997", @"/Views/Orders/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9a6442f2d3c4bfb2ce93c6b42858b62a85114ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateOrderViewModel>
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
            BeginContext(150, 53, true);
            WriteLiteral("\r\n    <h1 class=\"text-center suls-text-color\">Order №");
            EndContext();
            BeginContext(204, 20, false);
#line 7 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                              Write(Model.SequenceNumber);

#line default
#line hidden
            EndContext();
            BeginContext(224, 15, true);
            WriteLiteral("</h1>\r\n<br />\r\n");
            EndContext();
            BeginContext(239, 6704, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab1c7960247c6402a494e6d6149583ee5b4359976062", async() => {
                BeginContext(306, 113, true);
                WriteLiteral("\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n            <div class=\"col-4\">\r\n                ");
                EndContext();
                BeginContext(419, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab1c7960247c6402a494e6d6149583ee5b4359976568", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 13 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
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
                BeginContext(454, 41, true);
                WriteLiteral("\r\n                <p asp-for=\"CreatedOn\">");
                EndContext();
                BeginContext(496, 15, false);
#line 14 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                  Write(Model.CreatedOn);

#line default
#line hidden
                EndContext();
                BeginContext(511, 24, true);
                WriteLiteral("</p>\r\n\r\n                ");
                EndContext();
                BeginContext(535, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab1c7960247c6402a494e6d6149583ee5b4359978602", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 16 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
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
                BeginContext(568, 39, true);
                WriteLiteral("\r\n                <p asp-for=\"Purpose\">");
                EndContext();
                BeginContext(608, 13, false);
#line 17 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                Write(Model.Purpose);

#line default
#line hidden
                EndContext();
                BeginContext(621, 66, true);
                WriteLiteral("</p>\r\n\r\n                <input class=\"invisible\" id=\"Id\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 687, "\"", 704, 1);
#line 19 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
WriteAttributeValue("", 695, Model.Id, 695, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(705, 87, true);
                WriteLiteral(" />\r\n                <input class=\"invisible\" id=\"sequenceNumber\" name=\"sequenceNumber\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 792, "\"", 821, 1);
#line 20 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
WriteAttributeValue("", 800, Model.SequenceNumber, 800, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(822, 74, true);
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col-4\">\r\n                ");
                EndContext();
                BeginContext(896, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab1c7960247c6402a494e6d6149583ee5b43599711664", async() => {
                    BeginContext(926, 12, true);
                    WriteLiteral("Carrier name");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 23 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
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
                BeginContext(946, 44, true);
                WriteLiteral("\r\n                <p asp-for=\"Carrier.Name\">");
                EndContext();
                BeginContext(991, 18, false);
#line 24 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                     Write(Model.Carrier.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1009, 24, true);
                WriteLiteral("</p>\r\n\r\n                ");
                EndContext();
                BeginContext(1033, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab1c7960247c6402a494e6d6149583ee5b43599713849", async() => {
                    BeginContext(1068, 14, true);
                    WriteLiteral("Vehicle number");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 26 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
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
                BeginContext(1090, 49, true);
                WriteLiteral("\r\n                <p asp-for=\"Vehicle.RegNumber\">");
                EndContext();
                BeginContext(1140, 23, false);
#line 27 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                          Write(Model.Vehicle.RegNumber);

#line default
#line hidden
                EndContext();
                BeginContext(1163, 24, true);
                WriteLiteral("</p>\r\n\r\n                ");
                EndContext();
                BeginContext(1187, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab1c7960247c6402a494e6d6149583ee5b43599716059", async() => {
                    BeginContext(1220, 11, true);
                    WriteLiteral("Driver name");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 29 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
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
                BeginContext(1239, 47, true);
                WriteLiteral("\r\n                <p asp-for=\"Driver.FullName\">");
                EndContext();
                BeginContext(1287, 21, false);
#line 30 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                        Write(Model.Driver.FullName);

#line default
#line hidden
                EndContext();
                BeginContext(1308, 75, true);
                WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-4\">\r\n                ");
                EndContext();
                BeginContext(1383, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab1c7960247c6402a494e6d6149583ee5b43599718313", async() => {
                    BeginContext(1414, 13, true);
                    WriteLiteral("Receiver name");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 33 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
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
                BeginContext(1435, 45, true);
                WriteLiteral("\r\n                <p asp-for=\"Receiver.Name\">");
                EndContext();
                BeginContext(1481, 19, false);
#line 34 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                      Write(Model.Receiver.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1500, 24, true);
                WriteLiteral("</p>\r\n\r\n                ");
                EndContext();
                BeginContext(1524, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab1c7960247c6402a494e6d6149583ee5b43599720506", async() => {
                    BeginContext(1557, 16, true);
                    WriteLiteral("Delivery address");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 36 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
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
                BeginContext(1581, 47, true);
                WriteLiteral("\r\n                <p asp-for=\"DeliveryAddress\">");
                EndContext();
                BeginContext(1629, 21, false);
#line 37 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                        Write(Model.DeliveryAddress);

#line default
#line hidden
                EndContext();
                BeginContext(1650, 771, true);
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
#line 54 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                  
                    int counter = 1;
                

#line default
#line hidden
                BeginContext(2498, 16, true);
                WriteLiteral("                ");
                EndContext();
#line 57 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                 foreach (var product in Model.OrderedProducts)
                {

#line default
#line hidden
                BeginContext(2582, 99, true);
                WriteLiteral("                    <tr class=\"row\">\r\n                        <td class=\"col-lg-1 suls-text-color\">");
                EndContext();
                BeginContext(2683, 9, false);
#line 60 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                                         Write(counter++);

#line default
#line hidden
                EndContext();
                BeginContext(2693, 68, true);
                WriteLiteral("</td>\r\n                        <td class=\"col-lg-5 suls-text-color\">");
                EndContext();
                BeginContext(2762, 27, false);
#line 61 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                                        Write(product.Product.ProductCode);

#line default
#line hidden
                EndContext();
                BeginContext(2789, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(2793, 20, false);
#line 61 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                                                                       Write(product.Product.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2813, 68, true);
                WriteLiteral("</td>\r\n                        <td class=\"col-lg-2 suls-text-color\">");
                EndContext();
                BeginContext(2882, 24, false);
#line 62 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                                        Write(product.Lot.SerialNumber);

#line default
#line hidden
                EndContext();
                BeginContext(2906, 68, true);
                WriteLiteral("</td>\r\n                        <td class=\"col-lg-1 suls-text-color\">");
                EndContext();
                BeginContext(2975, 28, false);
#line 63 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                                        Write(product.OrderedPackagesCount);

#line default
#line hidden
                EndContext();
                BeginContext(3003, 68, true);
                WriteLiteral("</td>\r\n                        <td class=\"col-lg-1 suls-text-color\">");
                EndContext();
                BeginContext(3073, 44, false);
#line 64 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                                                         Write(Math.Round(product.OrderedPackagesWeight, 0));

#line default
#line hidden
                EndContext();
                BeginContext(3118, 161, true);
                WriteLiteral("</td>\r\n                        <td class=\"col-lg-2 suls-text-color\">\r\n                            <div class=\"button-holder\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3279, "\"", 3340, 3);
                WriteAttributeValue("", 3286, "/Products/Remove?id=", 3286, 20, true);
#line 67 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
WriteAttributeValue("", 3306, product.OrderId, 3306, 16, false);

#line default
#line hidden
#line 67 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
WriteAttributeValue("", 3322, product.ProductId, 3322, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3341, 131, true);
                WriteLiteral(" class=\"btn btn-warning\">Remove</a>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
                EndContext();
#line 71 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                }

#line default
#line hidden
                BeginContext(3491, 703, true);
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
                BeginContext(4195, 78, false);
#line 90 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                       Write(Math.Round((decimal)Model.OrderedProducts.Sum(x => x.OrderedPackagesCount), 0));

#line default
#line hidden
                EndContext();
                BeginContext(4273, 180, true);
                WriteLiteral(";\r\n                        </div>\r\n                    </td>\r\n                    <td class=\"col-lg-1 suls-text-color\">\r\n                        <div>\r\n                            ");
                EndContext();
                BeginContext(4454, 67, false);
#line 95 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
                       Write(Math.Round(Model.OrderedProducts.Sum(x => x.OrderedPackagesWeight)));

#line default
#line hidden
                EndContext();
                BeginContext(4521, 2212, true);
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
                                                                                                               //TODO to enable the IncludeButton only if selected fields are filled
                        </s");
                WriteLiteral("cript>\r\n                    </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n        <div class=\"container-fluid d-flex justify-content-end\">\r\n");
                EndContext();
#line 142 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
             if (Model.OrderedProducts.Count > 0)
            {

#line default
#line hidden
                BeginContext(6799, 18, true);
                WriteLiteral("                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 6817, "\"", 6852, 2);
                WriteAttributeValue("", 6824, "/Orders/Release?id=", 6824, 19, true);
#line 144 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
WriteAttributeValue("", 6843, Model.Id, 6843, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6853, 38, true);
                WriteLiteral(" class=\"btn btn-warning\">Release</a>\r\n");
                EndContext();
#line 145 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Edit.cshtml"
            }

#line default
#line hidden
                BeginContext(6906, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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
            BeginContext(6943, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(6947, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab1c7960247c6402a494e6d6149583ee5b43599735043", async() => {
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
            BeginContext(6993, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(6995, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab1c7960247c6402a494e6d6149583ee5b43599736223", async() => {
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
            BeginContext(7043, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateOrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
