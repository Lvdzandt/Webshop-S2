#pragma checksum "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77a3bd3f02915089335196b030b6d0f1ab782e5e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77a3bd3f02915089335196b030b6d0f1ab782e5e", @"/Views/Game/GamePage.cshtml")]
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
            BeginContext(86, 71, true);
            WriteLiteral("\r\n<h2>GamePage</h2>\r\n\r\n<div>\r\n    <ul>\r\n        <li style=\"float:left\">");
            EndContext();
            BeginContext(158, 15, false);
#line 11 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
                          Write(Model.Game.Name);

#line default
#line hidden
            EndContext();
            BeginContext(173, 39, true);
            WriteLiteral("</li>\r\n        <li style=\"float:right\">");
            EndContext();
            BeginContext(213, 16, false);
#line 12 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
                           Write(Model.Game.Price);

#line default
#line hidden
            EndContext();
            BeginContext(229, 19, true);
            WriteLiteral("</li>\r\n        <li>");
            EndContext();
            BeginContext(249, 22, false);
#line 13 "C:\Users\lucvd\Desktop\ICT\S2 Her\Code\WebShop-S2\WebShop-S2\Views\Game\GamePage.cshtml"
       Write(Model.Game.Description);

#line default
#line hidden
            EndContext();
            BeginContext(271, 26, true);
            WriteLiteral("</li>\r\n    </ul>\r\n</div>\r\n");
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
