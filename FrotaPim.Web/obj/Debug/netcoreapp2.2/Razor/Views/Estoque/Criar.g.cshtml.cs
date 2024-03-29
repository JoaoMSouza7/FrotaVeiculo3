#pragma checksum "C:\pim\FrotaPim.Web\Views\Estoque\Criar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94f47d904a3ccfcf741c1709234f136596afa153"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estoque_Criar), @"mvc.1.0.view", @"/Views/Estoque/Criar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Estoque/Criar.cshtml", typeof(AspNetCore.Views_Estoque_Criar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94f47d904a3ccfcf741c1709234f136596afa153", @"/Views/Estoque/Criar.cshtml")]
    public class Views_Estoque_Criar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FrotaPim.Web.Models.ViewsModels.EstoqueViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\Estoque\Criar.cshtml"
  
    ViewData["Title"] = "Adicionar estoque";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(159, 69, true);
            WriteLiteral("\r\n<div class=\"row header\">\r\n    <div class=\"col-md-12\">\r\n        <h2>");
            EndContext();
            BeginContext(229, 17, false);
#line 10 "C:\pim\FrotaPim.Web\Views\Estoque\Criar.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(246, 2204, true);
            WriteLiteral(@"</h2>
        
    </div>
</div>

<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Criar"" asp-controller=""Estoque"" method=""post"" asp-anti-forgery>
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""NomePeca"" class=""control-label"">Nome da peça</label>
                <input asp-for=""NomePeca"" class=""form-control"" name=""NomePeca""/>
                <span asp-validation-for=""NomePeca"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Descricao"" class=""control-label"">Descrição</label>
                <input asp-for=""Descricao"" class=""form-control"" name=""Descricao""/>
                <span asp-validation-for=""Descricao"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Fornecedor"" class=""control-label"">Fornecedor</label>
                <inp");
            WriteLiteral(@"ut asp-for=""Fornecedor"" class=""form-control"" name=""Fornecedor""/>
                <span asp-validation-for=""Fornecedor"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ValorPeca"" class=""control-label"">Valor da peça</label>
                <input size=""10"" maxlength=""10"" onkeydown=""FormataMoeda(this,10,event)"" onkeypress=""return maskKeyPress(event)"" asp-for=""ValorPeca"" placeholder=""R$"" class=""form-control"" name=""ValorPeca""/>
                <span asp-validation-for=""ValorPeca"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Quantidade"" class=""control-label"">Quantidade</label>
                <input asp-for=""Quantidade"" class=""form-control"" name=""Quantidade""/>
                <span asp-validation-for=""Quantidade"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Salvar"" class=""btn btn-suc");
            WriteLiteral("cess btn-sm\" />\r\n                <a href=\"/Estoque\" class=\"btn btn-secondary btn-sm\">Voltar</a>\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n");
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
