#pragma checksum "C:\Users\Olasquare\Documents\GitHub\FBKsystem\FBKsystem\FBKsystem\Views\Member\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f920f4f41b369d630633bff4010cfe5fe35f735"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_Success), @"mvc.1.0.view", @"/Views/Member/Success.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Olasquare\Documents\GitHub\FBKsystem\FBKsystem\FBKsystem\Views\_ViewImports.cshtml"
using FBKsystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Olasquare\Documents\GitHub\FBKsystem\FBKsystem\FBKsystem\Views\_ViewImports.cshtml"
using FBKsystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Olasquare\Documents\GitHub\FBKsystem\FBKsystem\FBKsystem\Views\_ViewImports.cshtml"
using FBKsystem.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f920f4f41b369d630633bff4010cfe5fe35f735", @"/Views/Member/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"747bad8ee7add5cfc8ce9656a5bc4c115ed1379c", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Olasquare\Documents\GitHub\FBKsystem\FBKsystem\FBKsystem\Views\Member\Success.cshtml"
   
    Layout = "~/Views/Shared/_MemberDashboardLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"justify-content-center\">\r\n    <h1>");
#nullable restore
#line 6 "C:\Users\Olasquare\Documents\GitHub\FBKsystem\FBKsystem\FBKsystem\Views\Member\Success.cshtml"
   Write(ViewBag.memberAddSuccessMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
