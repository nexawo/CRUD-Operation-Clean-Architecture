#pragma checksum "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a0b5d4aa93c3ca0dc440b2619b625c7bfc016c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tenant_List), @"mvc.1.0.view", @"/Views/Tenant/List.cshtml")]
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
#line 1 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a0b5d4aa93c3ca0dc440b2619b625c7bfc016c9", @"/Views/Tenant/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dec085bf195b01abb92852e860e2ca042d6a2857", @"/Views/_ViewImports.cshtml")]
    public class Views_Tenant_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Nexawo.Application.Tenants.Queries.GetTenantsList.TenantDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success float-md-right btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n");
#nullable restore
#line 4 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-md-6\">        \n    </div>\n    <div class=\"col-md-6\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a0b5d4aa93c3ca0dc440b2619b625c7bfc016c94152", async() => {
                WriteLiteral("<i class=\"fa fa-plus\"></i> Create A Tenant");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n<hr />\n<div class=\"row\">\n    <table class=\"table table-borderless table-responsive-md small\">\n        <thead>\n            <tr>\n                <th hidden>\n                    ");
#nullable restore
#line 20 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\List.cshtml"
               Write(Html.DisplayNameFor(model => model.TenantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 23 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\List.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 26 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\List.cshtml"
               Write(Html.DisplayNameFor(model => model.DBConnection));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th class=\"float-md-right\">Actions</th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 32 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\List.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td hidden>\n                        ");
#nullable restore
#line 36 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TenantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 39 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 42 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DBConnection));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td class=\"float-md-right\">\n                        ");
#nullable restore
#line 45 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\List.cshtml"
                   Write(Html.ActionLink(" Edit", "Edit", new { id = item.TenantId }, new { @class = "fa fa-pen small" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                        ");
#nullable restore
#line 46 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\List.cshtml"
                   Write(Html.ActionLink(" Detail", "Detail", new { id = item.TenantId }, new { @class = "fa fa-eye small" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                        ");
#nullable restore
#line 47 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\List.cshtml"
                   Write(Html.ActionLink(" Delete", "Delete", new { id = item.TenantId }, new { @class = "fa fa-trash small" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 50 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Nexawo.Application.Tenants.Queries.GetTenantsList.TenantDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
