#pragma checksum "C:\pim\FrotaPim.Web\Views\Carro\Criar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5ffb0fca4a998208ca8524c0d4c6241aad39a4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carro_Criar), @"mvc.1.0.view", @"/Views/Carro/Criar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Carro/Criar.cshtml", typeof(AspNetCore.Views_Carro_Criar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5ffb0fca4a998208ca8524c0d4c6241aad39a4f", @"/Views/Carro/Criar.cshtml")]
    public class Views_Carro_Criar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FrotaPim.Web.Models.ViewsModels.CarroViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\Carro\Criar.cshtml"
  
    ViewData["Title"] = "Adicionar Veículo";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(157, 69, true);
            WriteLiteral("\r\n<div class=\"row header\">\r\n    <div class=\"col-md-12\">\r\n        <h3>");
            EndContext();
            BeginContext(227, 17, false);
#line 10 "C:\pim\FrotaPim.Web\Views\Carro\Criar.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(244, 2937, true);
            WriteLiteral(@"</h3>
        <a href=""/Carro"" class=""btn btn-secondary btn-sm"">Voltar</a>
    </div>
</div>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Criar"" asp-controller=""Carro"" method=""post"" asp-anti-forgery>
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Placa"" class=""control-label"">Placa</label>
                <input asp-for=""Placa"" class=""form-control"" name=""Placa""/>
                <span asp-validation-for=""Placa"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Tipo"" class=""control-label"">Tipo</label>
                <input asp-for=""Tipo"" class=""form-control"" name=""Tipo"" />
                <span asp-validation-for=""Tipo"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Marca"" class=""control-label"">Marca</label>
                <");
            WriteLiteral(@"input asp-for=""Marca"" class=""form-control"" name=""Marca""/>
                <span asp-validation-for=""Marca"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Modelo"" class=""control-label"">Modelo</label>
                <input asp-for=""Modelo"" class=""form-control"" name=""Modelo""/>
                <span asp-validation-for=""Modelo"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Combustivel"" class=""control-label"">Combustivel</label>
                <input asp-for=""Combustivel"" class=""form-control"" name=""Combustivel""/>
                <span asp-validation-for=""Combustivel"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Cor"" class=""control-label"">Cor</label>
                <input asp-for=""Cor"" class=""form-control"" name=""Cor""/>
                <span asp-validation-for=""Cor"" class=""text-danger""></span>");
            WriteLiteral(@"
            </div>
            <div class=""form-group"">
                <label asp-for=""Ano"" class=""control-label"">Ano</label>
                <input asp-for=""Ano"" class=""form-control input-year"" name=""Ano""/>
                <span asp-validation-for=""Ano"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Motorista"" class=""control-label"">Motorista</label>
                <input asp-for=""_Motorista"" class=""form-control"" name=""_Motorista""/>
                <span asp-validation-for=""Motorista"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Criar"" class=""btn btn-success btn-sm"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a href=""../Index"" class=""btn btn-secondary btn-sm"">Voltar</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3199, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 71 "C:\pim\FrotaPim.Web\Views\Carro\Criar.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrotaPim.Web.Models.ViewsModels.CarroViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
