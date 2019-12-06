#pragma checksum "C:\pim\FrotaPim.Web\Views\Seguro\Criar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0b4ea1e06b1713865215a55325fcb19e65250a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seguro_Criar), @"mvc.1.0.view", @"/Views/Seguro/Criar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Seguro/Criar.cshtml", typeof(AspNetCore.Views_Seguro_Criar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0b4ea1e06b1713865215a55325fcb19e65250a9", @"/Views/Seguro/Criar.cshtml")]
    public class Views_Seguro_Criar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FrotaPim.Web.Models.ViewsModels.SeguroViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\Seguro\Criar.cshtml"
  
    ViewData["Title"] = "Adicionar Seguro";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(157, 69, true);
            WriteLiteral("\r\n<div class=\"row header\">\r\n    <div class=\"col-md-12\">\r\n        <h2>");
            EndContext();
            BeginContext(227, 17, false);
#line 10 "C:\pim\FrotaPim.Web\Views\Seguro\Criar.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(244, 1039, true);
            WriteLiteral(@"</h2>
        
    </div>
</div>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Criar"" asp-controller=""Seguro"" method=""post"" asp-anti-forgery>
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Apolice"" class=""control-label""><b>Apolice</b></label>
                <input asp-for=""Apolice"" class=""form-control""  name=""Apolice""/>
                <span asp-validation-for=""Apolice"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Seguradora"" class=""control-label""><b>Seguradora</b></label>
                <input asp-for=""Seguradora"" class=""form-control""  name=""Seguradora""/>
                <span asp-validation-for=""Seguradora"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label""><b>Veículo</b></label>
                <div>
     ");
            WriteLiteral("               ");
            EndContext();
            BeginContext(1284, 117, false);
#line 32 "C:\pim\FrotaPim.Web\Views\Seguro\Criar.cshtml"
               Write(Html.DropDownList("IDCarro", new SelectList(@Model.Carros, "IDCarro", "Placa", "0"), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1401, 1366, true);
            WriteLiteral(@"
                </div>
            </div>
            <div class=""form-group"">
                <label asp-for=""DataContratacao"" class=""control-label""><b>DataContratacao</b></label>
                <input placeholder=""dd/mm/aaaa"" asp-for=""DataContratacao"" class=""form-control""  name=""DataContratacao""/>
                <span asp-validation-for=""DataContratacao"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DataValidade"" class=""control-label""><b>DataValidade</b></label>
                <input placeholder=""dd/mm/aaaa"" asp-for=""DataValidade"" class=""form-control"" name=""DataValidade"" />
                <span asp-validation-for=""DataValidade"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ValorSeguro"" class=""control-label""><b>Valor do Seguro</b></label>
                <input placeholder=""R$"" asp-for=""ValorSeguro"" class=""form-control""  name=""ValorSeguro""/>
        ");
            WriteLiteral(@"        <span asp-validation-for=""DataValidade"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Salvar"" class=""btn btn-success btn-sm"" />
            </div>
        </form>
    </div>
</div>
<a href=""/Seguro"" class=""btn btn-secondary btn-sm"">Voltar</a>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2785, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 58 "C:\pim\FrotaPim.Web\Views\Seguro\Criar.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrotaPim.Web.Models.ViewsModels.SeguroViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
