#pragma checksum "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8c40e5d32ac732c6e2eab94ccc587f4f5fa3e02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tenant_Detail), @"mvc.1.0.view", @"/Views/Tenant/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8c40e5d32ac732c6e2eab94ccc587f4f5fa3e02", @"/Views/Tenant/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dec085bf195b01abb92852e860e2ca042d6a2857", @"/Views/_ViewImports.cshtml")]
    public class Views_Tenant_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Nexawo.Application.Tenants.Queries.GetTenantDetail.TenantDetailVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    var tenantUsers = (List<Nexawo.Application.Users.Queries.GetUsersListByTenant.UserDTO>)ViewBag.TenantUsers;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\" hidden>\n            ");
#nullable restore
#line 11 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.TenantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\" hidden>\n            ");
#nullable restore
#line 14 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\Detail.cshtml"
       Write(Html.DisplayFor(model => model.TenantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 17 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 20 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\Detail.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 23 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.DBConnection));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 26 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\Detail.cshtml"
       Write(Html.DisplayFor(model => model.DBConnection));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
#nullable restore
#line 31 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\Detail.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.TenantId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8c40e5d32ac732c6e2eab94ccc587f4f5fa3e026054", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<hr />

<div class=""row"">
    <h5>Tenant Users List</h5>
    <table class=""table table-hover table-bordered table-striped table-responsive-md small"">
        <thead>
            <tr>
                <th>
                    Name
                </th>
                <th>
                    Email
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 50 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\Detail.cshtml"
             foreach (var item in tenantUsers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 54 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\Detail.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 57 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\Detail.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 60 "D:\zipper\CleanArchitecture-master\Src\Presentation\WebApp\Views\Tenant\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nexawo.Application.Tenants.Queries.GetTenantDetail.TenantDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591