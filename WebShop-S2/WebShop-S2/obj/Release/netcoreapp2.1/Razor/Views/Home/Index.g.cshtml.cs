#pragma checksum "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ec0ce798e8355165b9ac53d4f67230740529ce0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec0ce798e8355165b9ac53d4f67230740529ce0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ea4cc49e3701bd8a65df0ec2ffd4ada04f15fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebShop_S2.Models.AllGameViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/FilterGame.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/AllGames.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("center-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("/images/NoIMG.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/noImg.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "AllGames";

#line default
#line hidden
            BeginContext(123, 92, true);
            WriteLiteral("\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.4.0/jquery.min.js\"></script>\r\n");
            EndContext();
            BeginContext(215, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "773d9d1146334621b1b92dcb2dc01082", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(280, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(282, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "530e5fc3eb494a8a818424725ac0b2f3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            BeginContext(331, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml"
   var sessionName = new byte[20];
    var status = Context.Session.TryGetValue("_Name", out sessionName);
    var name = Context.Session.GetString("_Name");
    var adminValue = Context.Session.TryGetValue("_IsAdmin", out sessionName);

#line default
#line hidden
            BeginContext(577, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml"
 if (status)
{

#line default
#line hidden
            BeginContext(596, 73, true);
            WriteLiteral("    <div style=\"text-align:center\">\r\n        <h1>Welcome to the GameShop ");
            EndContext();
            BeginContext(670, 4, false);
#line 20 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml"
                               Write(name);

#line default
#line hidden
            EndContext();
            BeginContext(674, 20, true);
            WriteLiteral("!</h1>\r\n    </div>\r\n");
            EndContext();
#line 22 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(706, 92, true);
            WriteLiteral("    <div style=\"text-align:center\">\r\n        <h1>Welcome to the GameShop!</h1>\r\n    </div>\r\n");
            EndContext();
#line 28 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(801, 64, true);
            WriteLiteral("<p><input id=\"myInput\" type=\"text\" placeholder=\"Search..\"></p>\r\n");
            EndContext();
#line 30 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml"
 if (adminValue)
{

#line default
#line hidden
            BeginContext(886, 42, true);
            WriteLiteral("    <a href=\"/Game/AddGame\">Add Game</a>\r\n");
            EndContext();
#line 33 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(931, 13, true);
            WriteLiteral("<hr>\r\n<div>\r\n");
            EndContext();
#line 36 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml"
     foreach (var item in Model.Games)
    {

#line default
#line hidden
            BeginContext(991, 83, true);
            WriteLiteral("        <div class=\"GameBox\">\r\n            <div class=\"GameInfo\">\r\n                ");
            EndContext();
            BeginContext(1074, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8480d136ad8a4f49bc368f48b984e3af", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1149, 36, true);
            WriteLiteral("\r\n                <p class=\"Name\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1185, "\"", 1215, 2);
            WriteAttributeValue("", 1192, "/Game/GamePage/", 1192, 15, true);
#line 41 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml"
WriteAttributeValue("", 1207, item.Id, 1207, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1216, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(1219, 9, false);
#line 41 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml"
                                                              Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1228, 43, true);
            WriteLiteral("</a></p>\r\n                <p class=\"Price\">");
            EndContext();
            BeginContext(1272, 10, false);
#line 42 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml"
                            Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1282, 76, true);
            WriteLiteral(" $</p>\r\n                <br /><hr /><br />\r\n                <p class=\"text\">");
            EndContext();
            BeginContext(1359, 16, false);
#line 44 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml"
                           Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1375, 38, true);
            WriteLiteral("</p>\r\n                <p class=\"text\">");
            EndContext();
            BeginContext(1414, 12, false);
#line 45 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml"
                           Write(item.GameTag);

#line default
#line hidden
            EndContext();
            BeginContext(1426, 42, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 48 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1475, 15, true);
            WriteLiteral("</div>\r\n<div>\r\n");
            EndContext();
            BeginContext(1498, 261, true);
            WriteLiteral(@"        <table id=""TableHeader"" class=""table table-striped table-bordered"">
            <thead>
                <tr>
                    <td>Game Tag</td>
                    <td>Count</td>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 60 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml"
                 foreach (var item in Model.TagCount)
                {

#line default
#line hidden
            BeginContext(1833, 63, true);
            WriteLiteral("                    <tr class=\"\">\r\n                        <td>");
            EndContext();
            BeginContext(1897, 10, false);
#line 63 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml"
                       Write(item.Item1);

#line default
#line hidden
            EndContext();
            BeginContext(1907, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1943, 10, false);
#line 64 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml"
                       Write(item.Item2);

#line default
#line hidden
            EndContext();
            BeginContext(1953, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 66 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2006, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
            BeginContext(2055, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebShop_S2.Models.AllGameViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
