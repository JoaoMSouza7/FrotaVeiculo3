#pragma checksum "C:\pim\FrotaPim.Web\Views\Pessoa\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79dc070c73ae1dd6aba6da192ed91e3525723cb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoa_Detalhes), @"mvc.1.0.view", @"/Views/Pessoa/Detalhes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pessoa/Detalhes.cshtml", typeof(AspNetCore.Views_Pessoa_Detalhes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79dc070c73ae1dd6aba6da192ed91e3525723cb8", @"/Views/Pessoa/Detalhes.cshtml")]
    public class Views_Pessoa_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FrotaPim.Web.Models.ViewsModels.PessoaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\Pessoa\Detalhes.cshtml"
  
    ViewData["Title"] = "Informações do(a) colaborador(a) ";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(174, 4, true);
            WriteLiteral("<h3>");
            EndContext();
            BeginContext(179, 17, false);
#line 7 "C:\pim\FrotaPim.Web\Views\Pessoa\Detalhes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(197, 10, false);
#line 7 "C:\pim\FrotaPim.Web\Views\Pessoa\Detalhes.cshtml"
                 Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(207, 95, true);
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(303, 39, false);
#line 13 "C:\pim\FrotaPim.Web\Views\Pessoa\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.CPF));

#line default
#line hidden
            EndContext();
            BeginContext(342, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(406, 35, false);
#line 16 "C:\pim\FrotaPim.Web\Views\Pessoa\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.CPF));

#line default
#line hidden
            EndContext();
            BeginContext(441, 141, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Data de Admissão\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(583, 40, false);
#line 22 "C:\pim\FrotaPim.Web\Views\Pessoa\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Admissao));

#line default
#line hidden
            EndContext();
            BeginContext(623, 133, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Telefone\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(757, 40, false);
#line 28 "C:\pim\FrotaPim.Web\Views\Pessoa\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(797, 130, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Cargo\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(928, 41, false);
#line 34 "C:\pim\FrotaPim.Web\Views\Pessoa\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.NomeCargo));

#line default
#line hidden
            EndContext();
            BeginContext(969, 438, true);
            WriteLiteral(@"
        </dd>
        <dd class = ""col-sm-2"">
            ------------------
        </dd>
        <dd class = ""col-sm-10"">
            ---------------------------------------
        </dd>
        <dt class = ""col-sm-2"">
            Endereço Completo
        </dt>
        <dd class = ""col-sm-10"">
        </dd>
        <dt class = ""col-sm-2"">
            Rua
        </dt>
        <dd class = ""col-sm-10"">
            ");
            EndContext();
            BeginContext(1408, 44, false);
#line 51 "C:\pim\FrotaPim.Web\Views\Pessoa\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Endereco.Rua));

#line default
#line hidden
            EndContext();
            BeginContext(1452, 131, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Número\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1584, 47, false);
#line 57 "C:\pim\FrotaPim.Web\Views\Pessoa\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Endereco.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1631, 128, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            CEP\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1760, 44, false);
#line 63 "C:\pim\FrotaPim.Web\Views\Pessoa\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Endereco.CEP));

#line default
#line hidden
            EndContext();
            BeginContext(1804, 131, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Bairro\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1936, 47, false);
#line 69 "C:\pim\FrotaPim.Web\Views\Pessoa\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Endereco.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1983, 131, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Cidade\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2115, 47, false);
#line 75 "C:\pim\FrotaPim.Web\Views\Pessoa\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Endereco.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(2162, 127, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            UF\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2290, 47, false);
#line 81 "C:\pim\FrotaPim.Web\Views\Pessoa\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Endereco.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(2337, 49, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2386, "\"", 2418, 2);
            WriteAttributeValue("", 2393, "../Editar/", 2393, 10, true);
#line 86 "C:\pim\FrotaPim.Web\Views\Pessoa\Detalhes.cshtml"
WriteAttributeValue("", 2403, Model.IDPessoa, 2403, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2419, 153, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\"><i class=\"fa fa-edit mx-2\"></i>Editar</a> |\r\n    <a href=\"../Index\" class=\"btn btn-secondary btn-sm\">Voltar</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrotaPim.Web.Models.ViewsModels.PessoaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
