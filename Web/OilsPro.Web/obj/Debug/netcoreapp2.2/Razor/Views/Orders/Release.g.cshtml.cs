#pragma checksum "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbab978aea1fe25f3c8721086239769f0b4f836a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Release), @"mvc.1.0.view", @"/Views/Orders/Release.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Release.cshtml", typeof(AspNetCore.Views_Orders_Release))]
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
#line 2 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
using OilsPro.Web.Models.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
using OilsPro.Services;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbab978aea1fe25f3c8721086239769f0b4f836a", @"/Views/Orders/Release.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9a6442f2d3c4bfb2ce93c6b42858b62a85114ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Release : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateOrderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(132, 173, true);
            WriteLiteral("\r\n<h1 class=\"text-center suls-text-color\">Receipt</h1>\r\n\r\n\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n            <div class=\"col-4\">\r\n\r\n                ");
            EndContext();
            BeginContext(305, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbab978aea1fe25f3c8721086239769f0b4f836a4258", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 14 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SequenceNumber);

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
            BeginContext(345, 23, true);
            WriteLiteral("\r\n                <p>: ");
            EndContext();
            BeginContext(369, 20, false);
#line 15 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
                Write(Model.SequenceNumber);

#line default
#line hidden
            EndContext();
            BeginContext(389, 24, true);
            WriteLiteral("</p>\r\n\r\n                ");
            EndContext();
            BeginContext(413, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbab978aea1fe25f3c8721086239769f0b4f836a6178", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 17 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
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
            BeginContext(448, 23, true);
            WriteLiteral("\r\n                <p>: ");
            EndContext();
            BeginContext(472, 15, false);
#line 18 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
                Write(Model.CreatedOn);

#line default
#line hidden
            EndContext();
            BeginContext(487, 24, true);
            WriteLiteral("</p>\r\n\r\n                ");
            EndContext();
            BeginContext(511, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbab978aea1fe25f3c8721086239769f0b4f836a8088", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 20 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
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
            BeginContext(544, 23, true);
            WriteLiteral("\r\n                <p>: ");
            EndContext();
            BeginContext(568, 13, false);
#line 21 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
                Write(Model.Purpose);

#line default
#line hidden
            EndContext();
            BeginContext(581, 77, true);
            WriteLiteral("</p>\r\n\r\n            </div>\r\n            <div class=\"col-4\">\r\n                ");
            EndContext();
            BeginContext(658, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbab978aea1fe25f3c8721086239769f0b4f836a10053", async() => {
                BeginContext(688, 12, true);
                WriteLiteral("Carrier name");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 25 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
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
            BeginContext(708, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(726, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fbab978aea1fe25f3c8721086239769f0b4f836a11730", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 26 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Carrier.Name);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(779, 22, true);
            WriteLiteral("\r\n\r\n\r\n                ");
            EndContext();
            BeginContext(801, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbab978aea1fe25f3c8721086239769f0b4f836a13368", async() => {
                BeginContext(836, 14, true);
                WriteLiteral("Vehicle number");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 29 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
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
            BeginContext(858, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(876, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fbab978aea1fe25f3c8721086239769f0b4f836a15052", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 30 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Vehicle.RegNumber);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(934, 22, true);
            WriteLiteral("\r\n\r\n\r\n                ");
            EndContext();
            BeginContext(956, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbab978aea1fe25f3c8721086239769f0b4f836a16695", async() => {
                BeginContext(989, 11, true);
                WriteLiteral("Driver name");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 33 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
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
            BeginContext(1008, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1026, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fbab978aea1fe25f3c8721086239769f0b4f836a18376", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 34 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Driver.FullName);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1082, 75, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"col-4\">\r\n\r\n                ");
            EndContext();
            BeginContext(1157, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbab978aea1fe25f3c8721086239769f0b4f836a20078", async() => {
                BeginContext(1188, 13, true);
                WriteLiteral("Receiver name");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 39 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
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
            BeginContext(1209, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1227, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fbab978aea1fe25f3c8721086239769f0b4f836a21760", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 40 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Receiver.Name);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1281, 22, true);
            WriteLiteral("\r\n\r\n\r\n                ");
            EndContext();
            BeginContext(1303, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbab978aea1fe25f3c8721086239769f0b4f836a23401", async() => {
                BeginContext(1336, 16, true);
                WriteLiteral("Delivery address");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 43 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
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
            BeginContext(1360, 23, true);
            WriteLiteral("\r\n                <p>: ");
            EndContext();
            BeginContext(1384, 21, false);
#line 44 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
                Write(Model.DeliveryAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1405, 710, true);
            WriteLiteral(@"</p>


            </div>
        </div>
    </div>


    <table class=""table table-hover mx-auto col-12"">
        <thead>
            <tr class=""row"">
                <th scope=""col"" class=""col-lg-2 suls-text-color"">Seq Number</th>
                <th scope=""col"" class=""col-lg-2 suls-text-color"">Product Code</th>
                <th scope=""col"" class=""col-lg-2 suls-text-color"">Product Name</th>
                <th scope=""col"" class=""col-lg-2 suls-text-color"">Pack Count</th>
                <th scope=""col"" class=""col-lg-2 suls-text-color"">Pack Weight</th>
                <td class=""col-lg-2 suls-text-color"">
                </td>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 65 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
              
                int counter = 1;
            

#line default
#line hidden
            BeginContext(2180, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 68 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
             foreach (var product in Model.OrderedProducts)
            {

#line default
#line hidden
            BeginContext(2256, 91, true);
            WriteLiteral("                <tr class=\"row\">\r\n                    <td class=\"col-lg-2 suls-text-color\">");
            EndContext();
            BeginContext(2349, 9, false);
#line 71 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
                                                     Write(counter++);

#line default
#line hidden
            EndContext();
            BeginContext(2359, 64, true);
            WriteLiteral("</td>\r\n                    <td class=\"col-lg-2 suls-text-color\">");
            EndContext();
            BeginContext(2424, 27, false);
#line 72 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
                                                    Write(product.Product.ProductCode);

#line default
#line hidden
            EndContext();
            BeginContext(2451, 64, true);
            WriteLiteral("</td>\r\n                    <td class=\"col-lg-2 suls-text-color\">");
            EndContext();
            BeginContext(2516, 20, false);
#line 73 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
                                                    Write(product.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2536, 64, true);
            WriteLiteral("</td>\r\n                    <td class=\"col-lg-2 suls-text-color\">");
            EndContext();
            BeginContext(2601, 28, false);
#line 74 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
                                                    Write(product.OrderedPackagesCount);

#line default
#line hidden
            EndContext();
            BeginContext(2629, 64, true);
            WriteLiteral("</td>\r\n                    <td class=\"col-lg-2 suls-text-color\">");
            EndContext();
            BeginContext(2694, 29, false);
#line 75 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"
                                                    Write(product.OrderedPackagesWeight);

#line default
#line hidden
            EndContext();
            BeginContext(2723, 116, true);
            WriteLiteral("</td>\r\n                    <td class=\"col-lg-2 suls-text-color\">\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 79 "C:\Users\Nora\Desktop\OilsPro\Web\OilsPro.Web\Views\Orders\Release.cshtml"

            }

#line default
#line hidden
            BeginContext(2856, 673, true);
            WriteLiteral(@"
            <tr class=""row"">
                <td class=""col-lg-2 suls-text-color"">-</td>
                <td class=""col-lg-2 suls-text-color"">-</td>
                <td class=""col-lg-2 suls-text-color"">-</td>
                <td class=""col-lg-2 suls-text-color"">-</td>
                <td class=""col-lg-2 suls-text-color"">-</td>
                <td class=""col-lg-2 suls-text-color"">
                </td>
            </tr>
        </tbody>
    </table>

    <div class=""top-border-line primary-separator""></div>
    <div class=""button-holder d-flex justify-content-center"">
        <a href=""/"" class=""btn btn-warning"">Print receipt</a>
    </div>




");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOrdersService orderservices { get; private set; }
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