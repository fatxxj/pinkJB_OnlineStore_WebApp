#pragma checksum "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d298eb000c36bbe7314d9d62a3d13ea58635671"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Store), @"mvc.1.0.view", @"/Views/Home/Store.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\_ViewImports.cshtml"
using pinkJB_core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\_ViewImports.cshtml"
using pinkJB_core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d298eb000c36bbe7314d9d62a3d13ea58635671", @"/Views/Home/Store.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faf9834a23f8a7cdf549bb93cfbdfd55e76b1ed1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Store : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white float-right customEditButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary customFont float-right buttoniTeStore"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 15px; color: deeppink"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml"
  
    ViewData["Title"] = "List of products";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <br /><br /><br />\r\n    <h1 class=\"customFont\" style=\"font-size: 65px;\">Pink <b><i>JB</i></b></h1>\r\n\r\n    \r\n\r\n<div class=\"row g-2\">        \r\n\r\n");
#nullable restore
#line 17 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml"
  foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-6 col-xs-6 border-primary mb-3 "">
            <span class=""border-primary"">
               

                <div class=""card mb-3 "" style=""max-width: 540px;"">

                    <div class=""row  "">
                        <div class=""col-md-12"">
                            <div class=""card-header text-white bg-pinkJB text-center"" style="" background-color: deeppink"" >
                           
                                <h3 class=""card-title customFont text-white"" style=""color: white"">
                                    ");
#nullable restore
#line 31 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml"
                               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;\r\n                                    \r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d298eb000c36bbe7314d9d62a3d13ea586356717424", async() => {
                WriteLiteral("<i class=\"bi bi-pencil-square\" ></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml"
                                                                                                           WriteLiteral(item.Id);

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
            WriteLiteral(@"
                                   
                                </h3>
                                
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d298eb000c36bbe7314d9d62a3d13ea5863567110008", async() => {
                WriteLiteral("\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 1502, "\"", 1526, 1);
#nullable restore
#line 41 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml"
WriteAttributeValue("", 1508, item.ProductImage, 1508, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-thumbnail\" width=\"100%\"");
                BeginWriteAttribute("alt", " alt=\"", 1562, "\"", 1585, 1);
#nullable restore
#line 41 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml"
WriteAttributeValue("", 1568, item.ProductName, 1568, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml"
                                                      WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                        \r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <div class=\"card-body\">\r\n                                <p class=\"card-text customFont\">");
#nullable restore
#line 47 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml"
                                                           Write(item.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"card-text customFont\" >\r\n                                    <b>Status: </b>\r\n");
#nullable restore
#line 50 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml"
                                     if (@item.amountLeft >= 1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"badge bg-pinkJB  text-white\" style=\"font-style: italic; font-weight: normal; font-size: 11px; color: white; background-color: hotpink;\">AVAILABLE</span>\r\n");
#nullable restore
#line 53 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml"
                                    }
                                
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span style=\"font-size: 11px; font-weight: normal;  font-style: italic; color: white;\" class=\"badge bg-danger text-white\">NOT AVAILABLE</span>\r\n");
#nullable restore
#line 58 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </p>

                            </div>
                        </div>
                        <div class=""col-md-12 justify-content-around text-center"">
                            <div class=""card-footer "">
                                <p class=""card-text customFont "" style=""font-size: 19px;"">
                                   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d298eb000c36bbe7314d9d62a3d13ea5863567115325", async() => {
                WriteLiteral("\r\n                                        <i class=\"bi bi-eye-fill\"></i> Show Details\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml"
                                                                                                                                                                            WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                                    \r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d298eb000c36bbe7314d9d62a3d13ea5863567117969", async() => {
                WriteLiteral("\r\n                                        <i class=\"bi bi-cart\"></i> Add to card\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3434, "btn", 3434, 3, true);
            AddHtmlAttributeValue(" ", 3437, "btn-outline-primary", 3438, 20, true);
            AddHtmlAttributeValue(" ", 3457, "customFont", 3458, 11, true);
            AddHtmlAttributeValue(" ", 3468, "float-right", 3469, 12, true);
            AddHtmlAttributeValue(" ", 3480, "buttoniTeStore", 3481, 15, true);
#nullable restore
#line 71 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml"
AddHtmlAttributeValue("  ", 3495, (item.amountLeft<=0) ? "disabled" : "", 3497, 41, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml"
                                                                                                                                                                                                                                                           WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                                    \r\n                                    <a");
            BeginWriteAttribute("class", " class=\"", 3862, "\"", 3974, 6);
            WriteAttributeValue("", 3870, "btn", 3870, 3, true);
            WriteAttributeValue(" ", 3873, "btn-outline-primary", 3874, 20, true);
            WriteAttributeValue(" ", 3893, "customFont", 3894, 11, true);
            WriteAttributeValue(" ", 3904, "float-right", 3905, 12, true);
            WriteAttributeValue(" ", 3916, "buttoniTeStore", 3917, 15, true);
#nullable restore
#line 75 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml"
WriteAttributeValue("  ", 3931, (item.amountLeft<=0) ? "disabled" : "", 3933, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 19px; color: deeppink; text-decoration: none;\" >\r\n                                        ");
#nullable restore
#line 76 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml"
                                   Write(item.ProductPrice.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </a>


                                    
                                    
                                
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </span>
        </div>
");
#nullable restore
#line 90 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml"

  
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n <br/>\r\n</div>\r\n");
#nullable restore
#line 96 "C:\Users\fatha\Source\Repos\pinkJB-core\pinkJB-core\Views\Home\Store.cshtml"
Write(await Html.PartialAsync("_CreateItem", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br /><br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
