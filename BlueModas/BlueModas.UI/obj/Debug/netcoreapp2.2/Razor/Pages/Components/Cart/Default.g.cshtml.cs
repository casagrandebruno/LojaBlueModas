#pragma checksum "C:\Users\brunoc\Documents\Estudo\BlueModas\BlueModas\BlueModas.UI\Pages\Components\Cart\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5ceea7be025ffd5ef343cd894d22e650fc72eb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BlueModas.UI.Pages.Components.Cart.Pages_Components_Cart_Default), @"mvc.1.0.view", @"/Pages/Components/Cart/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Components/Cart/Default.cshtml", typeof(BlueModas.UI.Pages.Components.Cart.Pages_Components_Cart_Default))]
namespace BlueModas.UI.Pages.Components.Cart
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\brunoc\Documents\Estudo\BlueModas\BlueModas\BlueModas.UI\Pages\_ViewImports.cshtml"
using BlueModas.UI;

#line default
#line hidden
#line 2 "C:\Users\brunoc\Documents\Estudo\BlueModas\BlueModas\BlueModas.UI\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5ceea7be025ffd5ef343cd894d22e650fc72eb1", @"/Pages/Components/Cart/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"295a193203e5932fe748684cdfcb27b4fb8f45e3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Components_Cart_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BlueModas.Application.Cart.GetCart.Response>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/item.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(77, 42, true);
            WriteLiteral("\r\n\r\n<div>\r\n    <p class=\"title\">Cart</p>\r\n");
            EndContext();
#line 10 "C:\Users\brunoc\Documents\Estudo\BlueModas\BlueModas\BlueModas.UI\Pages\Components\Cart\Default.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
            BeginContext(163, 140, true);
            WriteLiteral("        <article class=\"media\">\r\n            <figure class=\"media-left\">\r\n                <p class=\"image is-128x128\">\r\n                    ");
            EndContext();
            BeginContext(303, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f5ceea7be025ffd5ef343cd894d22e650fc72eb14409", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(334, 174, true);
            WriteLiteral("\r\n                </p>\r\n            </figure>\r\n            <div class=\"media-content\">\r\n                <div class=\"content\">\r\n                    <p class=\"title is-size-4\">");
            EndContext();
            BeginContext(509, 12, false);
#line 20 "C:\Users\brunoc\Documents\Estudo\BlueModas\BlueModas\BlueModas.UI\Pages\Components\Cart\Default.cshtml"
                                          Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(521, 105, true);
            WriteLiteral("</p>\r\n                    <div class=\"level\">\r\n                        <div class=\"level-item\">Quantity: ");
            EndContext();
            BeginContext(627, 16, false);
#line 22 "C:\Users\brunoc\Documents\Estudo\BlueModas\BlueModas\BlueModas.UI\Pages\Components\Cart\Default.cshtml"
                                                     Write(product.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(643, 62, true);
            WriteLiteral("</div>\r\n                        <div class=\"level-item\">Size: ");
            EndContext();
            BeginContext(706, 15, false);
#line 23 "C:\Users\brunoc\Documents\Estudo\BlueModas\BlueModas\BlueModas.UI\Pages\Components\Cart\Default.cshtml"
                                                 Write(product.StockId);

#line default
#line hidden
            EndContext();
            BeginContext(721, 63, true);
            WriteLiteral("</div>\r\n                        <div class=\"level-item\">Price: ");
            EndContext();
            BeginContext(785, 13, false);
#line 24 "C:\Users\brunoc\Documents\Estudo\BlueModas\BlueModas\BlueModas.UI\Pages\Components\Cart\Default.cshtml"
                                                  Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(798, 100, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </article>\r\n");
            EndContext();
#line 29 "C:\Users\brunoc\Documents\Estudo\BlueModas\BlueModas\BlueModas.UI\Pages\Components\Cart\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(905, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BlueModas.Application.Cart.GetCart.Response>> Html { get; private set; }
    }
}
#pragma warning restore 1591
