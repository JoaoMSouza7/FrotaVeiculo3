#pragma checksum "C:\pim\FrotaPim.Web\Views\Manutencao\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc274776ab527ce550b23c7ca30023641d8a116a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manutencao_Editar), @"mvc.1.0.view", @"/Views/Manutencao/Editar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manutencao/Editar.cshtml", typeof(AspNetCore.Views_Manutencao_Editar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc274776ab527ce550b23c7ca30023641d8a116a", @"/Views/Manutencao/Editar.cshtml")]
    public class Views_Manutencao_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FrotaPim.Web.Models.ViewsModels.ManutencaoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\Manutencao\Editar.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(149, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(154, 17, false);
#line 7 "C:\pim\FrotaPim.Web\Views\Manutencao\Editar.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(171, 452, true);
            WriteLiteral(@"</h2>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Editar"" asp-controller=""Manutencao"" method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""DescricaoManutencao"" class=""control-label"">Descrição</label>
                <input asp-for=""DescricaoManutencao"" class=""form-control"" name=""DescricaoManutencao""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 623, "\"", 657, 1);
#line 15 "C:\pim\FrotaPim.Web\Views\Manutencao\Editar.cshtml"
WriteAttributeValue("", 631, Model.DescricaoManutencao, 631, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(658, 303, true);
            WriteLiteral(@" />
                <span asp-validation-for=""DescricaoManutencao"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Valor"" class=""control-label"">Valor</label>
                <input asp-for=""Valor"" class=""form-control"" name=""Valor""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 961, "\"", 981, 1);
#line 20 "C:\pim\FrotaPim.Web\Views\Manutencao\Editar.cshtml"
WriteAttributeValue("", 969, Model.Valor, 969, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(982, 285, true);
            WriteLiteral(@" />
                <span asp-validation-for=""Valor"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Data"" class=""control-label"">Data</label>
                <input asp-for=""Data"" class=""form-control"" name=""Data""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1267, "\"", 1286, 1);
#line 25 "C:\pim\FrotaPim.Web\Views\Manutencao\Editar.cshtml"
WriteAttributeValue("", 1275, Model.Data, 1275, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1287, 246, true);
            WriteLiteral(" />\r\n                <span asp-validation-for=\"Data\" class=\"text-danger\"></span>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">Veículo</label>\r\n                <div>\r\n                     ");
            EndContext();
            BeginContext(1534, 113, false);
#line 31 "C:\pim\FrotaPim.Web\Views\Manutencao\Editar.cshtml"
                Write(Html.DropDownList("IDCarro", new SelectList(@Model.Carros, "IDCarro", "Placa", "0"), new {@class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(1647, 365, true);
            WriteLiteral(@"
                </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrotaPim.Web.Models.ViewsModels.ManutencaoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
