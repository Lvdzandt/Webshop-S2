#pragma checksum "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fac1b1afea5e017f6b8a01e2314ad699d4711c8b"
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
#line 1 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\_ViewImports.cshtml"
using WebShop_S2;

#line default
#line hidden
#line 2 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\_ViewImports.cshtml"
using WebShop_S2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fac1b1afea5e017f6b8a01e2314ad699d4711c8b", @"/Views/Game/GamePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ea4cc49e3701bd8a65df0ec2ffd4ada04f15fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_GamePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebShop_S2.Models.GameViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
  
    ViewData["Title"] = "GamePage";

#line default
#line hidden
            BeginContext(86, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
   var sessionName = new byte[20];
    var state = Context.Session.TryGetValue("_Name", out sessionName);

#line default
#line hidden
            BeginContext(199, 138, true);
            WriteLiteral("\r\n<link rel=\"stylesheet\" type=\"text/css\" href=\"/css/GamePage.css\" />\r\n\r\n<div>\r\n    <div class=\"GameInfo\">\r\n        <div>\r\n            <h2>");
            EndContext();
            BeginContext(338, 15, false);
#line 16 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
           Write(Model.Game.Name);

#line default
#line hidden
            EndContext();
            BeginContext(353, 99, true);
            WriteLiteral("</h2>\r\n            <ul>\r\n                <li><p><span class=\"glyphicon glyphicon-calendar\"></span> ");
            EndContext();
            BeginContext(453, 42, false);
#line 18 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
                                                                     Write(Model.Game.ReleaseDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(495, 11, true);
            WriteLiteral("</p></li>\r\n");
            EndContext();
            BeginContext(595, 23, true);
            WriteLiteral("                <li><p>");
            EndContext();
            BeginContext(619, 18, false);
#line 20 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
                  Write(Model.Game.GameTag);

#line default
#line hidden
            EndContext();
            BeginContext(637, 50, true);
            WriteLiteral("</p></li>\r\n            </ul>\r\n            <hr />\r\n");
            EndContext();
#line 23 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
             if (state)
            {
                

#line default
#line hidden
#line 25 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
                 using (Html.BeginForm("AddShoppingList", "Order", new { id = @Model.Game.Id }, FormMethod.Post))
                {

#line default
#line hidden
            BeginContext(861, 66, true);
            WriteLiteral("                    <input type=\"submit\" value=\"ShoppingList\" />\r\n");
            EndContext();
#line 28 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
                }

#line default
#line hidden
#line 29 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
                 using (Html.BeginForm("AddWishListItem", "Order", new { gameId = @Model.Game.Id }, FormMethod.Post))
                {

#line default
#line hidden
            BeginContext(1084, 62, true);
            WriteLiteral("                    <input type=\"submit\" value=\"WishList\" />\r\n");
            EndContext();
#line 32 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
                }

#line default
#line hidden
#line 32 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(1180, 115, true);
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n    <div class=\"GamePic\">\r\n        <img alt=\"/images/NoIMG.png\" src=\"\">\r\n    </div>\r\n");
            EndContext();
            BeginContext(1555, 43, true);
            WriteLiteral("    <div class=\"GameDescription\">\r\n        ");
            EndContext();
            BeginContext(1599, 22, false);
#line 48 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
   Write(Model.Game.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1621, 105, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div style=\"float:left\">\r\n    <a href=\"/Home/Index\">Back to Profile</a>\r\n</div>\r\n");
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
