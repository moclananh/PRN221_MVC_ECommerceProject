#pragma checksum "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c7617cf4d49bb9f35c9b097aba584d7ede0b1b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Views\_ViewImports.cshtml"
using PRN221_Asm02;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Views\_ViewImports.cshtml"
using PRN221_Asm02.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c7617cf4d49bb9f35c9b097aba584d7ede0b1b8", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a326033709c260803f7dbfb1f67efbe14380400a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRN221_Asm02.Models.Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Views\Home\Details.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c7617cf4d49bb9f35c9b097aba584d7ede0b1b84529", async() => {
                WriteLiteral(@"
    <div class=""app"">
        <div class=""layout"">
            <div class=""page-container"">
                <!-- Content Wrapper START -->
                <div class=""main-content"">

                    <div class=""card"" style=""margin-bottom: 20px"">
                        <div class=""card-body"">
                            <div class=""container"">
                                <div class=""row"">
                                    <div class=""col-5 text-center"">
                                        <img");
                BeginWriteAttribute("alt", " alt=\"", 614, "\"", 620, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid w-100\"");
                BeginWriteAttribute("src", " src=\"", 645, "\"", 670, 1);
#nullable restore
#line 20 "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Views\Home\Details.cshtml"
WriteAttributeValue("", 651, Model.ProductImage, 651, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"max-width: 54%\">\n                                        <p style=\"padding-top: 12px; font-size: 20px; font-weight: bold\">Price: ");
#nullable restore
#line 21 "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Views\Home\Details.cshtml"
                                                                                                           Write(Model.UnitPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" $</p>\n                                        <p style=\"font-size: 20px; font-weight: bold\">Stock: ");
#nullable restore
#line 22 "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Views\Home\Details.cshtml"
                                                                                        Write(Model.QuantityPerUnit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                                    </div>\n                                    <div class=\"col-7 text-center\">\n                                        <div class=\"m-t-5\">\n                                            <h1 style=\"color: tomato\">");
#nullable restore
#line 26 "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Views\Home\Details.cshtml"
                                                                 Write(Model.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\n                                        </div>\n                                       \n                                        <div class=\"text-right\">\n");
#nullable restore
#line 30 "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Views\Home\Details.cshtml"
                                             if (Model.QuantityPerUnit > 0)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <div class=\"text-right\">\n                                                    <button class=\"btn btn-success\" type=\"button\">\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c7617cf4d49bb9f35c9b097aba584d7ede0b1b88042", async() => {
                    WriteLiteral("Add to cart");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Views\Home\Details.cshtml"
                                                         WriteLiteral(Model.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                                    </button>\n                                                </div>\n");
#nullable restore
#line 40 "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Views\Home\Details.cshtml"

                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Views\Home\Details.cshtml"
                                             if (Model.QuantityPerUnit <= 0)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                <div class=""text-center"">

                                                    <p class=""card-text show_txt"" style=""color:red; font-size: 20px"">Sold out </p>
                                                </div>
");
#nullable restore
#line 48 "D:\FU_Hub\SU23\PRN221\Assignment\PRN221_Asm02\PRN221_Asm02\Views\Home\Details.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <script src=""assets/js/vendors.min.js""></script>

        <!-- page js -->
        <!-- Core JS -->
        <script src=""assets/js/app.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRN221_Asm02.Models.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
