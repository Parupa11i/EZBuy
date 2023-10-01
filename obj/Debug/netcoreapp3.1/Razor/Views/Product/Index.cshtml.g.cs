#pragma checksum "/Users/Parupalli/Projects/EZBuy/Views/Product/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6eb96cf0aef82301ffbd6c358e53a7a8f0ae1d49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EZBuy.Views.Product.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
namespace EZBuy.Views.Product
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
#line 3 "/Users/Parupalli/Projects/EZBuy/Views/_ViewImports.cshtml"
using EZBuy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eb96cf0aef82301ffbd6c358e53a7a8f0ae1d49", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a37c6b5baec43b6a6b10299d253ef9a35b128d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Product/UpdateCart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/Parupalli/Projects/EZBuy/Views/Product/Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<section class=\"jumbotron text-center\">\n    <div class=\"py-5 bg-light align-items-center\">\n        <div class=\"container\">\n            <div class=\"row\">\n");
#nullable restore
#line 10 "/Users/Parupalli/Projects/EZBuy/Views/Product/Index.cshtml"
                 if (Model != null)
                {
                    foreach (Product item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6eb96cf0aef82301ffbd6c358e53a7a8f0ae1d494264", async() => {
                WriteLiteral(@"
                            <div class=""col-md-4"">
                                <div class=""card mb-4 shadow-sm"" style=""width: 18rem;"">
                                    <div class=""card-body"">
                                        <h5 class=""card-title""> ");
#nullable restore
#line 18 "/Users/Parupalli/Projects/EZBuy/Views/Product/Index.cshtml"
                                                           Write(item.SKU);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h5>\n                                        <p class=\"card-text\"> ");
#nullable restore
#line 19 "/Users/Parupalli/Projects/EZBuy/Views/Product/Index.cshtml"
                                                         Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </p>
                                        <div class=""d-flex justify-content-between align-items-center"">
                                            <p style=""text-align:justify"" class=""text-muted small"">
                                                <button type=""submit"" class=""btn btn-outline-secondary btn-sm"" name=""AddToCart"">Add to cart</button>
                                            </p>
                                            <p class=""small"">
                                                Price &nbsp;<small>");
#nullable restore
#line 25 "/Users/Parupalli/Projects/EZBuy/Views/Product/Index.cshtml"
                                                              Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</small>
                                                <br />
                                                Quantity <input type=""number"" name=""qty"" id=""qty"" min=""1"" value=""1"" max=""4"" style=""width:40px"">
                                                <input type=""hidden"" name=""id""");
                BeginWriteAttribute("value", " value=\"", 1583, "\"", 1599, 1);
#nullable restore
#line 28 "/Users/Parupalli/Projects/EZBuy/Views/Product/Index.cshtml"
WriteAttributeValue("", 1591, item.Id, 1591, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                                <input type=\"hidden\" name=\"sku\"");
                BeginWriteAttribute("value", " value=\"", 1683, "\"", 1700, 1);
#nullable restore
#line 29 "/Users/Parupalli/Projects/EZBuy/Views/Product/Index.cshtml"
WriteAttributeValue("", 1691, item.SKU, 1691, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                                <input type=\"hidden\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 1786, "\"", 1805, 1);
#nullable restore
#line 30 "/Users/Parupalli/Projects/EZBuy/Views/Product/Index.cshtml"
WriteAttributeValue("", 1794, item.Price, 1794, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                                <input type=\"hidden\" name=\"itemDescr\"");
                BeginWriteAttribute("value", " value=\"", 1895, "\"", 1920, 1);
#nullable restore
#line 31 "/Users/Parupalli/Projects/EZBuy/Views/Product/Index.cshtml"
WriteAttributeValue("", 1903, item.Description, 1903, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                            </p>\n                                        </div>\n                                    </div>\n                                </div>\n                                </div>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 38 "/Users/Parupalli/Projects/EZBuy/Views/Product/Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n</section>");
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
