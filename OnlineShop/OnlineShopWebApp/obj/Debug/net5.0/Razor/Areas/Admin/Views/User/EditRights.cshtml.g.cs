#pragma checksum "C:\Users\scrib\source\repos\ASP.NET_Core_5.0_kurators\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\User\EditRights.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e4a0c1023baf4ea7f6188b1b8eddbcf37702912"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_EditRights), @"mvc.1.0.view", @"/Areas/Admin/Views/User/EditRights.cshtml")]
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
#line 1 "C:\Users\scrib\source\repos\ASP.NET_Core_5.0_kurators\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShopWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\scrib\source\repos\ASP.NET_Core_5.0_kurators\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShopWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\scrib\source\repos\ASP.NET_Core_5.0_kurators\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShopWebApp.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\scrib\source\repos\ASP.NET_Core_5.0_kurators\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShopWebApp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e4a0c1023baf4ea7f6188b1b8eddbcf37702912", @"/Areas/Admin/Views/User/EditRights.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6406589138542ef3b2ce247ce15b4c36e22ffc4a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_User_EditRights : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EditRightsViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditRights", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e4a0c1023baf4ea7f6188b1b8eddbcf377029125649", async() => {
                WriteLiteral("\r\n    <div class=\"row text-center\">\r\n        <div class=\"col\">\r\n            <h3>Текущие роли для пользователя ");
#nullable restore
#line 6 "C:\Users\scrib\source\repos\ASP.NET_Core_5.0_kurators\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\User\EditRights.cshtml"
                                         Write(Model.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n        </div>\r\n    </div>\r\n\r\n    <input type=\"hidden\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 248, "\"", 271, 1);
#nullable restore
#line 10 "C:\Users\scrib\source\repos\ASP.NET_Core_5.0_kurators\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\User\EditRights.cshtml"
WriteAttributeValue("", 256, Model.UserName, 256, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n");
#nullable restore
#line 12 "C:\Users\scrib\source\repos\ASP.NET_Core_5.0_kurators\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\User\EditRights.cshtml"
     foreach (var role in Model.AllRoles)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\r\n");
#nullable restore
#line 15 "C:\Users\scrib\source\repos\ASP.NET_Core_5.0_kurators\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\User\EditRights.cshtml"
             if (Model.UserRoles.Contains(role))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input class=\"form-check-input\"");
                BeginWriteAttribute("name", " name=\"", 454, "\"", 491, 3);
                WriteAttributeValue("", 461, "userRolesViewModel[", 461, 19, true);
#nullable restore
#line 17 "C:\Users\scrib\source\repos\ASP.NET_Core_5.0_kurators\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\User\EditRights.cshtml"
WriteAttributeValue("", 480, role.Name, 480, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 490, "]", 490, 1, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 508, "\"", 516, 0);
                EndWriteAttribute();
                WriteLiteral(" checked />\r\n                <label class=\"form-check-label\" for=\"flexCheckDefault\">");
#nullable restore
#line 18 "C:\Users\scrib\source\repos\ASP.NET_Core_5.0_kurators\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\User\EditRights.cshtml"
                                                                  Write(role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
#nullable restore
#line 19 "C:\Users\scrib\source\repos\ASP.NET_Core_5.0_kurators\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\User\EditRights.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input class=\"form-check-input\"");
                BeginWriteAttribute("name", " name=\"", 716, "\"", 753, 3);
                WriteAttributeValue("", 723, "userRolesViewModel[", 723, 19, true);
#nullable restore
#line 22 "C:\Users\scrib\source\repos\ASP.NET_Core_5.0_kurators\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\User\EditRights.cshtml"
WriteAttributeValue("", 742, role.Name, 742, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 752, "]", 752, 1, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 770, "\"", 778, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <label class=\"form-check-label\" for=\"flexCheckChecked\">");
#nullable restore
#line 23 "C:\Users\scrib\source\repos\ASP.NET_Core_5.0_kurators\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\User\EditRights.cshtml"
                                                                  Write(role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
#nullable restore
#line 24 "C:\Users\scrib\source\repos\ASP.NET_Core_5.0_kurators\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\User\EditRights.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n");
#nullable restore
#line 26 "C:\Users\scrib\source\repos\ASP.NET_Core_5.0_kurators\OnlineShop\OnlineShopWebApp\Areas\Admin\Views\User\EditRights.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e4a0c1023baf4ea7f6188b1b8eddbcf3770291210683", async() => {
                    WriteLiteral("Сменить");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EditRightsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
