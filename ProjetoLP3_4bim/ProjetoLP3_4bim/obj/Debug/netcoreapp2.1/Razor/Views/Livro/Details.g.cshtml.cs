#pragma checksum "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f661cdd99c54ef15aa95caccb963d6422fb1b2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Livro_Details), @"mvc.1.0.view", @"/Views/Livro/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Livro/Details.cshtml", typeof(AspNetCore.Views_Livro_Details))]
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
#line 1 "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\_ViewImports.cshtml"
using ProjetoLP3_4bim;

#line default
#line hidden
#line 2 "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\_ViewImports.cshtml"
using ProjetoLP3_4bim.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f661cdd99c54ef15aa95caccb963d6422fb1b2b", @"/Views/Livro/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b8dc96480b75957b1c736924afc93930cad3663", @"/Views/_ViewImports.cshtml")]
    public class Views_Livro_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoLP3_4bim.Models.Livro>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Details.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
            BeginContext(83, 120, true);
            WriteLiteral("\r\n<h2>Detalhes</h2>\r\n\r\n<div>\r\n    <h4>Livro</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(204, 47, false);
#line 14 "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TituloLivro));

#line default
#line hidden
            EndContext();
            BeginContext(251, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(295, 43, false);
#line 17 "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Details.cshtml"
       Write(Html.DisplayFor(model => model.TituloLivro));

#line default
#line hidden
            EndContext();
            BeginContext(338, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(382, 55, false);
#line 20 "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataLancamentoLivro));

#line default
#line hidden
            EndContext();
            BeginContext(437, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(481, 51, false);
#line 23 "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataLancamentoLivro));

#line default
#line hidden
            EndContext();
            BeginContext(532, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(576, 51, false);
#line 26 "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QtdPaginasLivro));

#line default
#line hidden
            EndContext();
            BeginContext(627, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(671, 47, false);
#line 29 "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Details.cshtml"
       Write(Html.DisplayFor(model => model.QtdPaginasLivro));

#line default
#line hidden
            EndContext();
            BeginContext(718, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(762, 46, false);
#line 32 "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PrecoLivro));

#line default
#line hidden
            EndContext();
            BeginContext(808, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(852, 42, false);
#line 35 "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Details.cshtml"
       Write(Html.DisplayFor(model => model.PrecoLivro));

#line default
#line hidden
            EndContext();
            BeginContext(894, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(938, 48, false);
#line 38 "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SinopseLivro));

#line default
#line hidden
            EndContext();
            BeginContext(986, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1030, 44, false);
#line 41 "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Details.cshtml"
       Write(Html.DisplayFor(model => model.SinopseLivro));

#line default
#line hidden
            EndContext();
            BeginContext(1074, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1118, 58, false);
#line 44 "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AutorIdAutorNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1220, 64, false);
#line 47 "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Details.cshtml"
       Write(Html.DisplayFor(model => model.AutorIdAutorNavigation.NomeAutor));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1328, 62, false);
#line 50 "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EditoraIdEditoraNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1390, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1434, 70, false);
#line 53 "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Details.cshtml"
       Write(Html.DisplayFor(model => model.EditoraIdEditoraNavigation.NomeEditora));

#line default
#line hidden
            EndContext();
            BeginContext(1504, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1548, 70, false);
#line 56 "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GeneroLivroIdGeneroLivroNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1618, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1662, 82, false);
#line 59 "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Details.cshtml"
       Write(Html.DisplayFor(model => model.GeneroLivroIdGeneroLivroNavigation.NomeGeneroLivro));

#line default
#line hidden
            EndContext();
            BeginContext(1744, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1791, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a3b022bbe2a4fa780bdd903189ca8e1", async() => {
                BeginContext(1842, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "F:\LP3\ProjetoLP3_4bim\ProjetoLP3_4bim\ProjetoLP3_4bim\Views\Livro\Details.cshtml"
                           WriteLiteral(Model.IdLivro);

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
            BeginContext(1852, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1860, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "101135d3ce06477ea7d3c7c5cb7d9198", async() => {
                BeginContext(1882, 17, true);
                WriteLiteral("Voltar para Lista");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1903, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoLP3_4bim.Models.Livro> Html { get; private set; }
    }
}
#pragma warning restore 1591
