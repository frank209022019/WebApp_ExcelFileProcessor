#pragma checksum "C:\Users\S4\Documents\GitHub\WebApp_ExcelFileProcessor\WebApp_ExcelFileProcessor\Views\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2b23e081b0c8c6c4cf41fa80af794c63b7e4dc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginPartial), @"mvc.1.0.view", @"/Views/Shared/_LoginPartial.cshtml")]
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
#line 1 "C:\Users\S4\Documents\GitHub\WebApp_ExcelFileProcessor\WebApp_ExcelFileProcessor\Views\_ViewImports.cshtml"
using WebApp_ExcelFileProcessor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\S4\Documents\GitHub\WebApp_ExcelFileProcessor\WebApp_ExcelFileProcessor\Views\_ViewImports.cshtml"
using WebApp_ExcelFileProcessor.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\S4\Documents\GitHub\WebApp_ExcelFileProcessor\WebApp_ExcelFileProcessor\Views\_ViewImports.cshtml"
using WebApp_ExcelFileProcessor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\S4\Documents\GitHub\WebApp_ExcelFileProcessor\WebApp_ExcelFileProcessor\Views\Shared\_LoginPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2b23e081b0c8c6c4cf41fa80af794c63b7e4dc8", @"/Views/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e92c1fa303219bcd7860b67f8f442630f7d14f52", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"navbar-nav\">\r\n");
#nullable restore
#line 6 "C:\Users\S4\Documents\GitHub\WebApp_ExcelFileProcessor\WebApp_ExcelFileProcessor\Views\Shared\_LoginPartial.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul class=\"navbar-nav ml-auto\">\r\n");
            WriteLiteral("        </ul>\r\n");
#nullable restore
#line 18 "C:\Users\S4\Documents\GitHub\WebApp_ExcelFileProcessor\WebApp_ExcelFileProcessor\Views\Shared\_LoginPartial.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\S4\Documents\GitHub\WebApp_ExcelFileProcessor\WebApp_ExcelFileProcessor\Views\Shared\_LoginPartial.cshtml"
                   
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
