#pragma checksum "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Areas\Admin\Views\Statistic\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b18bd79a1f9a5f6ace91515400b587fad0c2e596"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Statistic_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Statistic/Details.cshtml")]
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
#line 1 "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Areas\Admin\Views\_ViewImports.cshtml"
using PRN221_Asm02;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Areas\Admin\Views\_ViewImports.cshtml"
using PRN221_Asm02.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b18bd79a1f9a5f6ace91515400b587fad0c2e596", @"/Areas/Admin/Views/Statistic/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dda1c573833e9785ef95d508ce2584e43f06f672", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Statistic_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRN221_Asm02.Models.OrderDetail>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Areas\Admin\Views\Statistic\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    List<OrderDetail> details = ViewBag.ChiTiet;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\" id=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>ID Product</th>\r\n            <th>Price</th>\r\n            <th>Amount</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 18 "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Areas\Admin\Views\Statistic\Details.cshtml"
         if (details != null && details.Count() > 0)
        {
            foreach (var item in details)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 23 "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Areas\Admin\Views\Statistic\Details.cshtml"
                   Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Areas\Admin\Views\Statistic\Details.cshtml"
                   Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Areas\Admin\Views\Statistic\Details.cshtml"
                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 27 "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Areas\Admin\Views\Statistic\Details.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n   \r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRN221_Asm02.Models.OrderDetail> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
