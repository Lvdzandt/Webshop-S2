#pragma checksum "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e51acf2d4c0ccee77edbec054ba403e5a10542b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_GamePage), @"mvc.1.0.view", @"/Views/Game/GamePage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Game/GamePage.cshtml", typeof(AspNetCore.Views_Game_GamePage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e51acf2d4c0ccee77edbec054ba403e5a10542b", @"/Views/Game/GamePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ea4cc49e3701bd8a65df0ec2ffd4ada04f15fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_GamePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebShop_S2.Models.GameViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
  
    ViewData["Title"] = "GamePage";

#line default
#line hidden
            BeginContext(86, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
   var sessionName = new byte[20];
    var state = Context.Session.TryGetValue("_Name", out sessionName);

#line default
#line hidden
            BeginContext(199, 93, true);
            WriteLiteral("\r\n<div>\r\n    <div id=\"GameInfo\" style=\"float:left\">\r\n        <div>\r\n            <h2 class=\"\">");
            EndContext();
            BeginContext(293, 15, false);
#line 14 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
                    Write(Model.Game.Name);

#line default
#line hidden
            EndContext();
            BeginContext(308, 113, true);
            WriteLiteral("</h2>\r\n            <ul id=\"GameInfo\">\r\n                <li><p><span class=\"glyphicon glyphicon-calendar\"></span> ");
            EndContext();
            BeginContext(422, 42, false);
#line 16 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
                                                                     Write(Model.Game.ReleaseDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(464, 119, true);
            WriteLiteral("</p></li>\r\n                <li><p><span class=\"glyphicon glyphicon-star\"></span>Score</p></li>\r\n                <li><p>");
            EndContext();
            BeginContext(584, 18, false);
#line 18 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
                  Write(Model.Game.GameTag);

#line default
#line hidden
            EndContext();
            BeginContext(602, 50, true);
            WriteLiteral("</p></li>\r\n            </ul>\r\n            <hr />\r\n");
            EndContext();
#line 21 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
             if (state)
            {
                

#line default
#line hidden
#line 23 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
                 using (Html.BeginForm("AddShoppingList", "Order", new { id = @Model.Game.Id }, FormMethod.Post))
                {

#line default
#line hidden
            BeginContext(826, 102, true);
            WriteLiteral("                    <input style=\"float:left;margin-right:10%\" type=\"submit\" value=\"ShoppingList\" />\r\n");
            EndContext();
#line 26 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
                }

#line default
#line hidden
#line 27 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
                 using (Html.BeginForm("AddWishListItem", "Order", new { gameId = @Model.Game.Id }, FormMethod.Post))
                {

#line default
#line hidden
            BeginContext(1085, 81, true);
            WriteLiteral("                    <input style=\"float:left\" type=\"submit\" value=\"WishList\" />\r\n");
            EndContext();
#line 30 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
                }

#line default
#line hidden
#line 30 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(1200, 591, true);
            WriteLiteral(@"        </div>

    </div>
    <div style=""float:right;border:dashed;height:80%;width:70%;height:300px;margin:2%"">
        <img style=""width:80%;height:50%;"" alt=""/images/NoIMG.png"" src="""" class=""img img-responsive profile-image"">
    </div>
    <div style=""margin-top:5%;width:20%;float:left"">
        <h3>Reviews</h3>
        <h2 style=""float:left"">Name</h2>
        <h2 style=""float:right"">Score</h2>
        <br />
        <br />
        <br />
        <p><h1 style=""float:left"">Description</h1></p>
    </div>

    <div class=""center-block"" style=""float:left"">
        ");
            EndContext();
            BeginContext(1792, 22, false);
#line 49 "C:\Users\Luc\Desktop\git\Webshop-S2\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
   Write(Model.Game.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1814, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebShop_S2.Models.GameViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
