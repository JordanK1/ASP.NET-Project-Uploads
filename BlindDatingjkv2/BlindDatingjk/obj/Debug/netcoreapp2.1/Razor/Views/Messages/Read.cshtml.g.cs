#pragma checksum "C:\Users\Jordan\source\repos_NET\BlindDatingjkv2\BlindDatingjk\Views\Messages\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a05e750eb8118ad6ff4c91f53ee69b88a241d8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_Read), @"mvc.1.0.view", @"/Views/Messages/Read.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Messages/Read.cshtml", typeof(AspNetCore.Views_Messages_Read))]
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
#line 1 "C:\Users\Jordan\source\repos_NET\BlindDatingjkv2\BlindDatingjk\Views\_ViewImports.cshtml"
using BlindDatingjk;

#line default
#line hidden
#line 2 "C:\Users\Jordan\source\repos_NET\BlindDatingjkv2\BlindDatingjk\Views\_ViewImports.cshtml"
using BlindDatingjk.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a05e750eb8118ad6ff4c91f53ee69b88a241d8a", @"/Views/Messages/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ec3916582d92cdc0a2eac9f5dc0d85c88a0da81", @"/Views/_ViewImports.cshtml")]
    public class Views_Messages_Read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlindDatingjk.Models.MailMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 5, true);
            WriteLiteral("   \r\n");
            EndContext();
#line 3 "C:\Users\Jordan\source\repos_NET\BlindDatingjkv2\BlindDatingjk\Views\Messages\Read.cshtml"
  
    ViewData["Title"] = "Read";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(133, 122, true);
            WriteLiteral("\r\n<h2>Read</h2>\r\n\r\n<div>\r\n    <h4>MailMessage</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(256, 48, false);
#line 15 "C:\Users\Jordan\source\repos_NET\BlindDatingjkv2\BlindDatingjk\Views\Messages\Read.cshtml"
       Write(Html.DisplayNameFor(model => model.MessageTitle));

#line default
#line hidden
            EndContext();
            BeginContext(304, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(348, 44, false);
#line 18 "C:\Users\Jordan\source\repos_NET\BlindDatingjkv2\BlindDatingjk\Views\Messages\Read.cshtml"
       Write(Html.DisplayFor(model => model.MessageTitle));

#line default
#line hidden
            EndContext();
            BeginContext(392, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(436, 47, false);
#line 21 "C:\Users\Jordan\source\repos_NET\BlindDatingjkv2\BlindDatingjk\Views\Messages\Read.cshtml"
       Write(Html.DisplayNameFor(model => model.MessageText));

#line default
#line hidden
            EndContext();
            BeginContext(483, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(527, 43, false);
#line 24 "C:\Users\Jordan\source\repos_NET\BlindDatingjkv2\BlindDatingjk\Views\Messages\Read.cshtml"
       Write(Html.DisplayFor(model => model.MessageText));

#line default
#line hidden
            EndContext();
            BeginContext(570, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(614, 42, false);
#line 27 "C:\Users\Jordan\source\repos_NET\BlindDatingjkv2\BlindDatingjk\Views\Messages\Read.cshtml"
       Write(Html.DisplayNameFor(model => model.IsRead));

#line default
#line hidden
            EndContext();
            BeginContext(656, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(700, 38, false);
#line 30 "C:\Users\Jordan\source\repos_NET\BlindDatingjkv2\BlindDatingjk\Views\Messages\Read.cshtml"
       Write(Html.DisplayFor(model => model.IsRead));

#line default
#line hidden
            EndContext();
            BeginContext(738, 38, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlindDatingjk.Models.MailMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591