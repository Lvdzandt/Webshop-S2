#pragma checksum "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Order\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2afe6c527aa3479c9c14fcb689f3fd12f96e7a62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Order), @"mvc.1.0.view", @"/Views/Order/Order.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Order.cshtml", typeof(AspNetCore.Views_Order_Order))]
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
#line 1 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\_ViewImports.cshtml"
using WebShop_S2;

#line default
#line hidden
#line 2 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\_ViewImports.cshtml"
using WebShop_S2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2afe6c527aa3479c9c14fcb689f3fd12f96e7a62", @"/Views/Order/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ea4cc49e3701bd8a65df0ec2ffd4ada04f15fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebShop_S2.Models.OrderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Order\Order.cshtml"
  
    ViewData["Title"] = "Order";

#line default
#line hidden
            BeginContext(84, 15, true);
            WriteLiteral("\r\n<h2>OrderID: ");
            EndContext();
            BeginContext(100, 14, false);
#line 7 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Order\Order.cshtml"
        Write(Model.Order.Id);

#line default
#line hidden
            EndContext();
            BeginContext(114, 280, true);
            WriteLiteral(@"</h2>

<div>
    <hr />
    <div>
        <table id=""TableHeader"" class=""table table-striped table-bordered"">
            <thead>
            <tr>
                <td>Name</td>
                <td>Price</td>
            </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 20 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Order\Order.cshtml"
             foreach (var itemGame in Model.Order.GameList)
            {

#line default
#line hidden
            BeginContext(470, 55, true);
            WriteLiteral("                <tr class=\"\">\r\n                    <td>");
            EndContext();
            BeginContext(526, 13, false);
#line 23 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Order\Order.cshtml"
                   Write(itemGame.Name);

#line default
#line hidden
            EndContext();
            BeginContext(539, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(571, 14, false);
#line 24 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Order\Order.cshtml"
                   Write(itemGame.Price);

#line default
#line hidden
            EndContext();
            BeginContext(585, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 26 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Order\Order.cshtml"
            }

#line default
#line hidden
            BeginContext(630, 132, true);
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n    <dl style=\"float:right\" class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(763, 46, false);
#line 33 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Order\Order.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(809, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(853, 42, false);
#line 36 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Order\Order.cshtml"
       Write(Html.DisplayFor(model => model.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(895, 63, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <br/><br/>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(958, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e57ba187ed0459d97d58384efe80d36", async() => {
                BeginContext(975, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(991, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebShop_S2.Models.OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
