#pragma checksum "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "978b8ddb1886317ef88908143db828bdcf5a8622"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Account), @"mvc.1.0.view", @"/Views/Account/Account.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Account.cshtml", typeof(AspNetCore.Views_Account_Account))]
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
#line 1 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\_ViewImports.cshtml"
using WebShop_S2;

#line default
#line hidden
#line 2 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\_ViewImports.cshtml"
using WebShop_S2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"978b8ddb1886317ef88908143db828bdcf5a8622", @"/Views/Account/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ea4cc49e3701bd8a65df0ec2ffd4ada04f15fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebShop_S2.Models.AccountViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("/images/NoIMG.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/NoIMG.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
            BeginContext(88, 139, true);
            WriteLiteral("\r\n<link rel=\"stylesheet\" type=\"text/css\" href=\"/css/Profile.css\"/>\r\n\r\n<div id=\"ProfileInfo\" class=\"col-md-3\">\r\n    <div class=\"\">\r\n        ");
            EndContext();
            BeginContext(227, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a6ff471b2af54a86afd628c1a3130840", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(304, 14, true);
            WriteLiteral("\r\n        <h2>");
            EndContext();
            BeginContext(319, 14, false);
#line 12 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
       Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(333, 20, true);
            WriteLiteral("</h2>\r\n        <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 353, "\"", 383, 2);
            WriteAttributeValue("", 360, "/Account/Edit/", 360, 14, true);
#line 13 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
WriteAttributeValue("", 374, Model.Id, 374, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(384, 84, true);
            WriteLiteral(">Edit profile</a></p>\r\n        <p><span class=\"glyphicon glyphicon-calendar\"></span>");
            EndContext();
            BeginContext(469, 34, false);
#line 14 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                                                        Write(Model.Birthday.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(503, 67, true);
            WriteLiteral("</p>\r\n        <p><span class=\"glyphicon glyphicon-envelope\"></span>");
            EndContext();
            BeginContext(571, 11, false);
#line 15 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                                                        Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(582, 340, true);
            WriteLiteral(@"</p>
    </div>
</div>

<div class=""profile-box-content"">
    <h3>Orders</h3>
    <table id=""TableHeader"" class=""table table-striped table-bordered"">
        <thead>
            <tr>
                <td>ID</td>
                <td>Price</td>
                <td>Status</td>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 30 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
             if (Model.Orders.Count == 0)
            {

#line default
#line hidden
            BeginContext(980, 156, true);
            WriteLiteral("                <tr class=\"\">\r\n                    <td>No Orders</td>\r\n                    <td></td>\r\n                    <td></td>\r\n                </tr>\r\n");
            EndContext();
#line 37 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
            }
            else
            {

                foreach (var item in Model.Orders)
                {

#line default
#line hidden
            BeginContext(1257, 31, true);
            WriteLiteral("                <tr class=\"\">\r\n");
            EndContext();
#line 44 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                     using (Html.BeginForm("Order", "Order", new { orderId = item.Id }, FormMethod.Post))
                    {

#line default
#line hidden
            BeginContext(1418, 68, true);
            WriteLiteral("                        <td><input type=\"submit\" value=\"X\" /></td>\r\n");
            EndContext();
#line 47 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                    }

#line default
#line hidden
            BeginContext(1509, 24, true);
            WriteLiteral("                    <td>");
            EndContext();
            BeginContext(1534, 15, false);
#line 48 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                   Write(item.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1549, 33, true);
            WriteLiteral(" $</td>\r\n                    <td>");
            EndContext();
            BeginContext(1583, 16, false);
#line 49 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                   Write(item.OrderStatus);

#line default
#line hidden
            EndContext();
            BeginContext(1599, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 51 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(1663, 360, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>

<div class=""profile-box-content"">
    <h3>Reviews</h3>
    <table id=""TableHeader"" class=""table table-striped table-bordered"">
        <thead>
            <tr>
                <td>ID</td>
                <td>Description</td>
                <td>Score</td>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 68 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
             if (Model.Reviews.Count == 0)
            {

#line default
#line hidden
            BeginContext(2082, 157, true);
            WriteLiteral("                <tr class=\"\">\r\n                    <td>No Reviews</td>\r\n                    <td></td>\r\n                    <td></td>\r\n                </tr>\r\n");
            EndContext();
#line 75 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
            }
            else
            {
                foreach (var item in Model.Reviews)
                {

#line default
#line hidden
            BeginContext(2359, 63, true);
            WriteLiteral("                    <tr class=\"\">\r\n                        <td>");
            EndContext();
            BeginContext(2423, 10, false);
#line 81 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2433, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2469, 16, false);
#line 82 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                       Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2485, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2521, 10, false);
#line 83 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                       Write(item.Score);

#line default
#line hidden
            EndContext();
            BeginContext(2531, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 85 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(2599, 357, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>

<div class=""profile-box-content"">
    <h3>WishList</h3>
    <table id=""TableHeader"" class=""table table-striped table-bordered"">
        <thead>
            <tr>
                <td>Item</td>
                <td>Date added</td>
                <td></td>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 102 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
             if (Model.WishList.Count == 0)
            {

#line default
#line hidden
            BeginContext(3016, 161, true);
            WriteLiteral("                <tr class=\"\">\r\n                    <td>No items found</td>\r\n                    <td></td>\r\n                    <td></td>\r\n                </tr>\r\n");
            EndContext();
#line 109 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
            }
            else
            {
                foreach (var item in Model.WishList)
                {

#line default
#line hidden
            BeginContext(3298, 63, true);
            WriteLiteral("                    <tr class=\"\">\r\n                        <td>");
            EndContext();
            BeginContext(3362, 14, false);
#line 115 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                       Write(item.Game.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3376, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3412, 34, false);
#line 116 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                       Write(item.DateAdded.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(3446, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 117 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                         using (Html.BeginForm("RemoveWishList", "Order", new { gameId = @item.Game.Id}, FormMethod.Post))
                        {

#line default
#line hidden
            BeginContext(3604, 71, true);
            WriteLiteral("                            <td><input type=\"submit\" value=\"X\"/></td>\r\n");
            EndContext();
#line 120 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                        }

#line default
#line hidden
            BeginContext(3702, 27, true);
            WriteLiteral("                    </tr>\r\n");
            EndContext();
#line 122 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(3763, 42, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebShop_S2.Models.AccountViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
