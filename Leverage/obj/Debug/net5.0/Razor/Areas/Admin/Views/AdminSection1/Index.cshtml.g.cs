#pragma checksum "D:\Compar\compar academy\ASP\Leverage\Leverage\Areas\Admin\Views\AdminSection1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db85247d6a7147b1ee1d16a4dc4eb0aed9a9de40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminSection1_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminSection1/Index.cshtml")]
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
#line 1 "D:\Compar\compar academy\ASP\Leverage\Leverage\Areas\Admin\Views\_ViewImports.cshtml"
using Leverage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Compar\compar academy\ASP\Leverage\Leverage\Areas\Admin\Views\_ViewImports.cshtml"
using Leverage.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Compar\compar academy\ASP\Leverage\Leverage\Areas\Admin\Views\_ViewImports.cshtml"
using Leverage.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db85247d6a7147b1ee1d16a4dc4eb0aed9a9de40", @"/Areas/Admin/Views/AdminSection1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0f5d29cca613b0822a42cf6a0425e12a3b36551", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminSection1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Start>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Compar\compar academy\ASP\Leverage\Leverage\Areas\Admin\Views\AdminSection1\Index.cshtml"
   
    ViewData["Title"] = "Section 1";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2>Section 1</h2>
<div class=""table-sorter-wrapper col-lg-12 table-responsive"">
    <table id=""sortable-table-2"" class=""table table-striped"">
        <thead>
            <tr>
                <th class=""sortStyle ascStyle"">Header<i class=""mdi mdi-chevron-down""></i></th>
                <th class=""sortStyle unsortStyle"">Name<i class=""mdi mdi-chevron-down""></i></th>
                <th class=""sortStyle unsortStyle"">Work<i class=""mdi mdi-chevron-down""></i></th>
                <th class=""sortStyle unsortStyle"">Description<i class=""mdi mdi-chevron-down""></i></th>
                <th class=""sortStyle unsortStyle"">Photo<i class=""mdi mdi-chevron-down""></i></th>
                <th class=""sortStyle unsortStyle""><i class=""mdi mdi-chevron-down""></i></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 19 "D:\Compar\compar academy\ASP\Leverage\Leverage\Areas\Admin\Views\AdminSection1\Index.cshtml"
             foreach (var st in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 22 "D:\Compar\compar academy\ASP\Leverage\Leverage\Areas\Admin\Views\AdminSection1\Index.cshtml"
                   Write(st.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "D:\Compar\compar academy\ASP\Leverage\Leverage\Areas\Admin\Views\AdminSection1\Index.cshtml"
                   Write(st.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "D:\Compar\compar academy\ASP\Leverage\Leverage\Areas\Admin\Views\AdminSection1\Index.cshtml"
                   Write(st.Work);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "D:\Compar\compar academy\ASP\Leverage\Leverage\Areas\Admin\Views\AdminSection1\Index.cshtml"
                   Write(st.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "db85247d6a7147b1ee1d16a4dc4eb0aed9a9de406222", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1163, "~/uploads/", 1163, 10, true);
#nullable restore
#line 26 "D:\Compar\compar academy\ASP\Leverage\Leverage\Areas\Admin\Views\AdminSection1\Index.cshtml"
AddHtmlAttributeValue("", 1173, st.PhotoURl, 1173, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1269, "\"", 1308, 2);
            WriteAttributeValue("", 1276, "/Admin/AdminSection1/Edit/", 1276, 26, true);
#nullable restore
#line 28 "D:\Compar\compar academy\ASP\Leverage\Leverage\Areas\Admin\Views\AdminSection1\Index.cshtml"
WriteAttributeValue("", 1302, st.ID, 1302, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "D:\Compar\compar academy\ASP\Leverage\Leverage\Areas\Admin\Views\AdminSection1\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Start>> Html { get; private set; }
    }
}
#pragma warning restore 1591
