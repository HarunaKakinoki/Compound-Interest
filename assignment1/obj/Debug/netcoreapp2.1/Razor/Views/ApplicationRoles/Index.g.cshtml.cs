#pragma checksum "C:\Users\Haruna Doranecoco\Downloads\Chan_Kakinoki_ass1_v2\assignment1\assignment1\Views\ApplicationRoles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c6dbbb3cce85c85b3ffd3066e0ee2e28da05a13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApplicationRoles_Index), @"mvc.1.0.view", @"/Views/ApplicationRoles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ApplicationRoles/Index.cshtml", typeof(AspNetCore.Views_ApplicationRoles_Index))]
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
#line 1 "C:\Users\Haruna Doranecoco\Downloads\Chan_Kakinoki_ass1_v2\assignment1\assignment1\Views\_ViewImports.cshtml"
using assignment1;

#line default
#line hidden
#line 2 "C:\Users\Haruna Doranecoco\Downloads\Chan_Kakinoki_ass1_v2\assignment1\assignment1\Views\_ViewImports.cshtml"
using assignment1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c6dbbb3cce85c85b3ffd3066e0ee2e28da05a13", @"/Views/ApplicationRoles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40ec9bbb3a297dde244f6b0a2620babf17d5d546", @"/Views/_ViewImports.cshtml")]
    public class Views_ApplicationRoles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<assignment1.Models.ApplicationRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Haruna Doranecoco\Downloads\Chan_Kakinoki_ass1_v2\assignment1\assignment1\Views\ApplicationRoles\Index.cshtml"
  
    ViewData["Title"] = "Application Roles";

#line default
#line hidden
            BeginContext(111, 80, true);
            WriteLiteral("\r\n<h2>Application roles</h2>\r\n<h4>Manage application roles here.</h4>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(191, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "876fde9486b94d8186df7f3299fd537f", async() => {
                BeginContext(214, 15, true);
                WriteLiteral("Create New Role");
                EndContext();
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
            EndContext();
            BeginContext(233, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(326, 47, false);
#line 16 "C:\Users\Haruna Doranecoco\Downloads\Chan_Kakinoki_ass1_v2\assignment1\assignment1\Views\ApplicationRoles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(373, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(429, 48, false);
#line 19 "C:\Users\Haruna Doranecoco\Downloads\Chan_Kakinoki_ass1_v2\assignment1\assignment1\Views\ApplicationRoles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(477, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(533, 40, false);
#line 22 "C:\Users\Haruna Doranecoco\Downloads\Chan_Kakinoki_ass1_v2\assignment1\assignment1\Views\ApplicationRoles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(573, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(629, 50, false);
#line 25 "C:\Users\Haruna Doranecoco\Downloads\Chan_Kakinoki_ass1_v2\assignment1\assignment1\Views\ApplicationRoles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NormalizedName));

#line default
#line hidden
            EndContext();
            BeginContext(679, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(735, 52, false);
#line 28 "C:\Users\Haruna Doranecoco\Downloads\Chan_Kakinoki_ass1_v2\assignment1\assignment1\Views\ApplicationRoles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ConcurrencyStamp));

#line default
#line hidden
            EndContext();
            BeginContext(787, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\Haruna Doranecoco\Downloads\Chan_Kakinoki_ass1_v2\assignment1\assignment1\Views\ApplicationRoles\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(905, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(954, 46, false);
#line 37 "C:\Users\Haruna Doranecoco\Downloads\Chan_Kakinoki_ass1_v2\assignment1\assignment1\Views\ApplicationRoles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1000, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1056, 47, false);
#line 40 "C:\Users\Haruna Doranecoco\Downloads\Chan_Kakinoki_ass1_v2\assignment1\assignment1\Views\ApplicationRoles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1159, 39, false);
#line 43 "C:\Users\Haruna Doranecoco\Downloads\Chan_Kakinoki_ass1_v2\assignment1\assignment1\Views\ApplicationRoles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1254, 49, false);
#line 46 "C:\Users\Haruna Doranecoco\Downloads\Chan_Kakinoki_ass1_v2\assignment1\assignment1\Views\ApplicationRoles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NormalizedName));

#line default
#line hidden
            EndContext();
            BeginContext(1303, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1359, 51, false);
#line 49 "C:\Users\Haruna Doranecoco\Downloads\Chan_Kakinoki_ass1_v2\assignment1\assignment1\Views\ApplicationRoles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ConcurrencyStamp));

#line default
#line hidden
            EndContext();
            BeginContext(1410, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1465, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1be5be86f79c4985b13301e7370beb54", async() => {
                BeginContext(1513, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\Haruna Doranecoco\Downloads\Chan_Kakinoki_ass1_v2\assignment1\assignment1\Views\ApplicationRoles\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1524, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 55 "C:\Users\Haruna Doranecoco\Downloads\Chan_Kakinoki_ass1_v2\assignment1\assignment1\Views\ApplicationRoles\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1563, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<assignment1.Models.ApplicationRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
