#pragma checksum "C:\Users\jrem7_000\Documents\Dotnet-Core-MVC\Biss Project\Bliss\Views\Cart\InquiryConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec41f0926fee330c53c027f82c8cfc78eb802e50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_InquiryConfirmation), @"mvc.1.0.view", @"/Views/Cart/InquiryConfirmation.cshtml")]
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
#line 1 "C:\Users\jrem7_000\Documents\Dotnet-Core-MVC\Biss Project\Bliss\Views\_ViewImports.cshtml"
using Bliss;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jrem7_000\Documents\Dotnet-Core-MVC\Biss Project\Bliss\Views\_ViewImports.cshtml"
using Bliss_Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec41f0926fee330c53c027f82c8cfc78eb802e50", @"/Views/Cart/InquiryConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da74a7b579df963b02235f49ccd4d4a7bc8aee5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_InquiryConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bliss_Models.OrderHeader>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n\r\n");
#nullable restore
#line 5 "C:\Users\jrem7_000\Documents\Dotnet-Core-MVC\Biss Project\Bliss\Views\Cart\InquiryConfirmation.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"text-info\"> Order Created</h1>\r\n        <p>Order #");
#nullable restore
#line 8 "C:\Users\jrem7_000\Documents\Dotnet-Core-MVC\Biss Project\Bliss\Views\Cart\InquiryConfirmation.cshtml"
             Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has been created successfully</p>\r\n");
#nullable restore
#line 9 "C:\Users\jrem7_000\Documents\Dotnet-Core-MVC\Biss Project\Bliss\Views\Cart\InquiryConfirmation.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"text-info\">Inquiry Confirmation</h1>\r\n");
            WriteLiteral("        <p>We have received your inquiry and someone from our team will contact you shortly!</p>\r\n");
#nullable restore
#line 15 "C:\Users\jrem7_000\Documents\Dotnet-Core-MVC\Biss Project\Bliss\Views\Cart\InquiryConfirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <img src=\"/images/patio.jpg\" width=\"80%\" />\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bliss_Models.OrderHeader> Html { get; private set; }
    }
}
#pragma warning restore 1591
