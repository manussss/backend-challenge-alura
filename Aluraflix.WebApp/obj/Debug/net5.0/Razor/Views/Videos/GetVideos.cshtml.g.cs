#pragma checksum "C:\Users\opc\Documents\workspace\personal\alura-challenge\Challenge\BackendChallengeAlura\Aluraflix.WebApp\Views\Videos\GetVideos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "644ad9cffb0b1e3cf0559556482fe22531e81e72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Videos_GetVideos), @"mvc.1.0.view", @"/Views/Videos/GetVideos.cshtml")]
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
#line 1 "C:\Users\opc\Documents\workspace\personal\alura-challenge\Challenge\BackendChallengeAlura\Aluraflix.WebApp\Views\_ViewImports.cshtml"
using Aluraflix.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\opc\Documents\workspace\personal\alura-challenge\Challenge\BackendChallengeAlura\Aluraflix.WebApp\Views\_ViewImports.cshtml"
using Aluraflix.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"644ad9cffb0b1e3cf0559556482fe22531e81e72", @"/Views/Videos/GetVideos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1233a5af711635078ea94062eecfe779c6bca127", @"/Views/_ViewImports.cshtml")]
    public class Views_Videos_GetVideos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Aluraflix.WebApp.Models.Video>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostVideo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\opc\Documents\workspace\personal\alura-challenge\Challenge\BackendChallengeAlura\Aluraflix.WebApp\Views\Videos\GetVideos.cshtml"
  
    ViewData["Title"] = "Videos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista de V??deos</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "644ad9cffb0b1e3cf0559556482fe22531e81e723935", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\opc\Documents\workspace\personal\alura-challenge\Challenge\BackendChallengeAlura\Aluraflix.WebApp\Views\Videos\GetVideos.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\opc\Documents\workspace\personal\alura-challenge\Challenge\BackendChallengeAlura\Aluraflix.WebApp\Views\Videos\GetVideos.cshtml"
           Write(Html.DisplayNameFor(model => model.CategoriaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\opc\Documents\workspace\personal\alura-challenge\Challenge\BackendChallengeAlura\Aluraflix.WebApp\Views\Videos\GetVideos.cshtml"
           Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\opc\Documents\workspace\personal\alura-challenge\Challenge\BackendChallengeAlura\Aluraflix.WebApp\Views\Videos\GetVideos.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\opc\Documents\workspace\personal\alura-challenge\Challenge\BackendChallengeAlura\Aluraflix.WebApp\Views\Videos\GetVideos.cshtml"
           Write(Html.DisplayNameFor(model => model.Url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\opc\Documents\workspace\personal\alura-challenge\Challenge\BackendChallengeAlura\Aluraflix.WebApp\Views\Videos\GetVideos.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\opc\Documents\workspace\personal\alura-challenge\Challenge\BackendChallengeAlura\Aluraflix.WebApp\Views\Videos\GetVideos.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\opc\Documents\workspace\personal\alura-challenge\Challenge\BackendChallengeAlura\Aluraflix.WebApp\Views\Videos\GetVideos.cshtml"
           Write(Html.DisplayFor(modelItem => item.CategoriaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\opc\Documents\workspace\personal\alura-challenge\Challenge\BackendChallengeAlura\Aluraflix.WebApp\Views\Videos\GetVideos.cshtml"
           Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\opc\Documents\workspace\personal\alura-challenge\Challenge\BackendChallengeAlura\Aluraflix.WebApp\Views\Videos\GetVideos.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\opc\Documents\workspace\personal\alura-challenge\Challenge\BackendChallengeAlura\Aluraflix.WebApp\Views\Videos\GetVideos.cshtml"
           Write(Html.DisplayFor(modelItem => item.Url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\opc\Documents\workspace\personal\alura-challenge\Challenge\BackendChallengeAlura\Aluraflix.WebApp\Views\Videos\GetVideos.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 53 "C:\Users\opc\Documents\workspace\personal\alura-challenge\Challenge\BackendChallengeAlura\Aluraflix.WebApp\Views\Videos\GetVideos.cshtml"
           Write(Html.ActionLink("Details", "Video", new { item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 54 "C:\Users\opc\Documents\workspace\personal\alura-challenge\Challenge\BackendChallengeAlura\Aluraflix.WebApp\Views\Videos\GetVideos.cshtml"
           Write(Html.ActionLink("Delete", "Deletar", new { item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\opc\Documents\workspace\personal\alura-challenge\Challenge\BackendChallengeAlura\Aluraflix.WebApp\Views\Videos\GetVideos.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Aluraflix.WebApp.Models.Video>> Html { get; private set; }
    }
}
#pragma warning restore 1591
