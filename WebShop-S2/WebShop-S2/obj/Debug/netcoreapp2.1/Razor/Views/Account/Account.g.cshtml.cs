#pragma checksum "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "248f5a7da01f3d691ddf00d5d335665955b8ded7"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"248f5a7da01f3d691ddf00d5d335665955b8ded7", @"/Views/Account/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ea4cc49e3701bd8a65df0ec2ffd4ada04f15fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebShop_S2.Models.AccountViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:left;margin:5%;border:dashed;margin-right:5%;width:50px;height:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("/images/NoIMG.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/NoIMG.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img img-responsive profile-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(88, 169, true);
            WriteLiteral("\r\n<div id=\"ProfileInfo\" class=\"col-md-3 profile-box\" style=\"border:outset;width:100%;margin-bottom:10%;margin-top:20px\">\r\n    <div class=\"profile-box-content\">\r\n        ");
            EndContext();
            BeginContext(257, 178, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8e7ccd01344b42899cb34fe509eb0e23", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(435, 68, true);
            WriteLiteral("\r\n        <h2 style=\"float:left;margin:5%\" class=\"no-margin-bottom\">");
            EndContext();
            BeginContext(504, 14, false);
#line 10 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                                                             Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(518, 66, true);
            WriteLiteral("</h2>\r\n        <p style=\"float:right;margin:0;text-align:right\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 584, "\"", 614, 2);
            WriteAttributeValue("", 591, "/Account/Edit/", 591, 14, true);
#line 11 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
WriteAttributeValue("", 605, Model.ID, 605, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(615, 136, true);
            WriteLiteral(">Edit profile</a></p>\r\n        <p style=\"float:right;margin:5%;text-align:center\"><span class=\"glyphicon glyphicon-calendar one\"></span>");
            EndContext();
            BeginContext(752, 34, false);
#line 12 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                                                                                                            Write(Model.Birthday.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(786, 119, true);
            WriteLiteral("</p>\r\n        <p style=\"float:right;margin:5%;text-align:center\"><span class=\"glyphicon glyphicon-envelope one\"></span>");
            EndContext();
            BeginContext(906, 11, false);
#line 13 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                                                                                                            Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(917, 385, true);
            WriteLiteral(@"</p>
    </div>
</div>

<div class=""profile-box-content"" style=""float:left;width:30%;margin-right:5%"">
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
#line 28 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
             if (Model.Orders.Count == 0)
            {

#line default
#line hidden
            BeginContext(1360, 156, true);
            WriteLiteral("                <tr class=\"\">\r\n                    <td>No Orders</td>\r\n                    <td></td>\r\n                    <td></td>\r\n                </tr>\r\n");
            EndContext();
#line 35 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
            }
            else
            {
                foreach (var item in Model.Orders)
                {

#line default
#line hidden
            BeginContext(1635, 63, true);
            WriteLiteral("                    <tr class=\"\">\r\n                        <td>");
            EndContext();
            BeginContext(1699, 7, false);
#line 41 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                       Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1706, 76, true);
            WriteLiteral("</td>\r\n                        <td>#price</td>\r\n                        <td>");
            EndContext();
            BeginContext(1783, 16, false);
#line 43 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                       Write(item.OrderStatus);

#line default
#line hidden
            EndContext();
            BeginContext(1799, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 45 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(1867, 405, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>

<div class=""profile-box-content"" style=""float:left;width:30%;margin-right:5%"">
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
#line 62 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
             if (Model.Reviews.Count == 0)
            {

#line default
#line hidden
            BeginContext(2331, 157, true);
            WriteLiteral("                <tr class=\"\">\r\n                    <td>No Reviews</td>\r\n                    <td></td>\r\n                    <td></td>\r\n                </tr>\r\n");
            EndContext();
#line 69 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
            }
            else
            {
                foreach (var item in Model.Reviews)
                {

#line default
#line hidden
            BeginContext(2608, 63, true);
            WriteLiteral("                    <tr class=\"\">\r\n                        <td>");
            EndContext();
            BeginContext(2672, 10, false);
#line 75 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2682, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2718, 16, false);
#line 76 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                       Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2734, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2770, 10, false);
#line 77 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                       Write(item.Score);

#line default
#line hidden
            EndContext();
            BeginContext(2780, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 79 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(2848, 386, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>

<div class=""profile-box-content"" style=""float:left;width:30%"">
    <h3>Wishlist</h3>
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
#line 96 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
             if (Model.WishList.Count == 0)
            {

#line default
#line hidden
            BeginContext(3294, 161, true);
            WriteLiteral("                <tr class=\"\">\r\n                    <td>No items found</td>\r\n                    <td></td>\r\n                    <td></td>\r\n                </tr>\r\n");
            EndContext();
#line 103 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
            }
            else
            {
                foreach (var item in Model.WishList)
                {

#line default
#line hidden
            BeginContext(3576, 63, true);
            WriteLiteral("                    <tr class=\"\">\r\n                        <td>");
            EndContext();
            BeginContext(3640, 9, false);
#line 109 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3649, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3685, 36, false);
#line 110 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                       Write(item.ReleaseDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(3721, 86, true);
            WriteLiteral("</td>\r\n                        <td><a href=\"#\">X</a></td>\r\n                    </tr>\r\n");
            EndContext();
#line 113 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Account\Account.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(3841, 42, true);
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
