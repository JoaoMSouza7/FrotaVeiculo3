#pragma checksum "C:\pim\FrotaPim.Web\Views\ContasAPagar\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9c3e73761d859ed2de527f4286ece8b7fa186a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContasAPagar_Editar), @"mvc.1.0.view", @"/Views/ContasAPagar/Editar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ContasAPagar/Editar.cshtml", typeof(AspNetCore.Views_ContasAPagar_Editar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c3e73761d859ed2de527f4286ece8b7fa186a7", @"/Views/ContasAPagar/Editar.cshtml")]
    public class Views_ContasAPagar_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FrotaPim.Web.Models.ViewsModels.ContasAPagarViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Editar.cshtml"
  
    ViewData["Title"] = "Editar Despesa";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(161, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(168, 17, false);
#line 8 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Editar.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(185, 427, true);
            WriteLiteral(@"</h2>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Editar"" asp-controller=""ContasAPagar"" method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""CentroDeCusto"" class=""control-label""></label>
                <input asp-for=""CentroDeCusto"" class=""form-control"" name=""CentroDeCusto""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 612, "\"", 640, 1);
#line 16 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Editar.cshtml"
WriteAttributeValue("", 620, Model.CentroDeCusto, 620, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(641, 309, true);
            WriteLiteral(@"/>
                <span asp-validation-for=""CentroDeCusto"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""TipoDespesa"" class=""control-label""></label>
                <input asp-for=""TipoDespesa"" class=""form-control"" name=""TipoDespesa""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 950, "\"", 976, 1);
#line 21 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Editar.cshtml"
WriteAttributeValue("", 958, Model.TipoDespesa, 958, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(977, 301, true);
            WriteLiteral(@"/>
                <span asp-validation-for=""TipoDespesa"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Descricao"" class=""control-label""></label>
                <input asp-for=""Descricao"" class=""form-control"" name=""Descricao""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1278, "\"", 1302, 1);
#line 26 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Editar.cshtml"
WriteAttributeValue("", 1286, Model.Descricao, 1286, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1303, 302, true);
            WriteLiteral(@"/>
                <span asp-validation-for=""Descricao"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Vencimento"" class=""control-label""></label>
                <input asp-for=""Vencimento"" class=""form-control"" name=""Vencimento""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1605, "\"", 1630, 1);
#line 31 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Editar.cshtml"
WriteAttributeValue("", 1613, Model.Vencimento, 1613, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1631, 393, true);
            WriteLiteral(@"/>
                <span asp-validation-for=""Vencimento"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Valor"" class=""control-label""></label>
                <input size=""10"" maxlength=""10"" onkeydown=""FormataMoeda(this,10,event)"" onkeypress=""return maskKeyPress(event)"" asp-for=""Valor"" class=""form-control"" name=""Valor""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2024, "\"", 2044, 1);
#line 36 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Editar.cshtml"
WriteAttributeValue("", 2032, Model.Valor, 2032, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2045, 419, true);
            WriteLiteral(@"/>
                <span asp-validation-for=""Valor"" class=""text-danger""></span>
            </div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <input type=""submit"" value=""Salvar"" class=""btn btn-success btn-sm"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a href=""../Index"" class=""btn btn-primary btn-sm"">Voltar</a>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrotaPim.Web.Models.ViewsModels.ContasAPagarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
