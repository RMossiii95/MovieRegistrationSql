#pragma checksum "C:\GitHubDevBuild\repos\MovieRegistration\MovieRegistration\Views\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9767faae912ecaf4202318c7ea553b93440f02b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Index), @"mvc.1.0.view", @"/Views/Index.cshtml")]
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
#line 1 "C:\GitHubDevBuild\repos\MovieRegistration\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GitHubDevBuild\repos\MovieRegistration\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9767faae912ecaf4202318c7ea553b93440f02b1", @"/Views/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edb0700316839935d5586746ff80ad9306f8388", @"/Views/_ViewImports.cshtml")]
    public class Views_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\GitHubDevBuild\repos\MovieRegistration\MovieRegistration\Views\Index.cshtml"
 foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>");
#nullable restore
#line 5 "C:\GitHubDevBuild\repos\MovieRegistration\MovieRegistration\Views\Index.cshtml"
              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 6 "C:\GitHubDevBuild\repos\MovieRegistration\MovieRegistration\Views\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591