#pragma checksum "C:\pim\FrotaPim.Web\Views\Estoque\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae39edc294dbe71772d139bc5ae524f091f32680"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estoque_Detalhes), @"mvc.1.0.view", @"/Views/Estoque/Detalhes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Estoque/Detalhes.cshtml", typeof(AspNetCore.Views_Estoque_Detalhes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae39edc294dbe71772d139bc5ae524f091f32680", @"/Views/Estoque/Detalhes.cshtml")]
    public class Views_Estoque_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FrotaPim.Web.Models.ViewsModels.EstoqueViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\Estoque\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(150, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(157, 17, false);
#line 8 "C:\pim\FrotaPim.Web\Views\Estoque\Detalhes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(174, 117, true);
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <h4>Estoque</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(292, 44, false);
#line 15 "C:\pim\FrotaPim.Web\Views\Estoque\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.NomePeca));

#line default
#line hidden
            EndContext();
            BeginContext(336, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(400, 40, false);
#line 18 "C:\pim\FrotaPim.Web\Views\Estoque\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.NomePeca));

#line default
#line hidden
            EndContext();
            BeginContext(440, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(503, 45, false);
#line 21 "C:\pim\FrotaPim.Web\Views\Estoque\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(548, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(612, 41, false);
#line 24 "C:\pim\FrotaPim.Web\Views\Estoque\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(653, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(716, 46, false);
#line 27 "C:\pim\FrotaPim.Web\Views\Estoque\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Fornecedor));

#line default
#line hidden
            EndContext();
            BeginContext(762, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(826, 42, false);
#line 30 "C:\pim\FrotaPim.Web\Views\Estoque\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Fornecedor));

#line default
#line hidden
            EndContext();
            BeginContext(868, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(931, 45, false);
#line 33 "C:\pim\FrotaPim.Web\Views\Estoque\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorPeca));

#line default
#line hidden
            EndContext();
            BeginContext(976, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1040, 41, false);
#line 36 "C:\pim\FrotaPim.Web\Views\Estoque\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.ValorPeca));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1144, 46, false);
#line 39 "C:\pim\FrotaPim.Web\Views\Estoque\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(1190, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1254, 42, false);
#line 42 "C:\pim\FrotaPim.Web\Views\Estoque\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 49, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1345, "\"", 1378, 2);
            WriteAttributeValue("", 1352, "../Editar/", 1352, 10, true);
#line 47 "C:\pim\FrotaPim.Web\Views\Estoque\Detalhes.cshtml"
WriteAttributeValue("", 1362, Model.IdEstoque, 1362, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1379, 122, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Editar</a> |\r\n    <a href=\"../Index\" class=\"btn btn-secondary btn-sm\">Voltar</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrotaPim.Web.Models.ViewsModels.EstoqueViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591