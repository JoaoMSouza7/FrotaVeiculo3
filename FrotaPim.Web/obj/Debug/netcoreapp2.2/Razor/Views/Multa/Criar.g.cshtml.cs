#pragma checksum "C:\pim\FrotaPim.Web\Views\Multa\Criar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56ca65b5160fdf5f50af8280e26df58dd4f4e283"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Multa_Criar), @"mvc.1.0.view", @"/Views/Multa/Criar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Multa/Criar.cshtml", typeof(AspNetCore.Views_Multa_Criar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56ca65b5160fdf5f50af8280e26df58dd4f4e283", @"/Views/Multa/Criar.cshtml")]
    public class Views_Multa_Criar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FrotaPim.Web.Models.ViewsModels.MultaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\Multa\Criar.cshtml"
  
    ViewData["Title"] = "Adicionar Multa";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(155, 67, true);
            WriteLiteral("<div class=\"row header\">\r\n    <div class=\"col-md-12\">\r\n        <h3>");
            EndContext();
            BeginContext(223, 17, false);
#line 9 "C:\pim\FrotaPim.Web\Views\Multa\Criar.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(240, 1410, true);
            WriteLiteral(@"</h3>
        <a href=""/Multas"" class=""btn btn-secondary btn-sm"">Voltar</a>
    </div>
</div>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Gravidade"" class=""control-label"">Gravidade</label>
                <input asp-for=""Gravidade"" class=""form-control"" name=""Gravidade""/>
                <span asp-validation-for=""Gravidade"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DataMulta"" class=""control-label"">Data da Multa</label>
                <input type=""date"" asp-for=""DataMulta"" class=""form-control"" name=""DataMulta""/>
                <span asp-validation-for=""DataMulta"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ValorMulta"" class=""control-label"">Valor da Multa</lab");
            WriteLiteral(@"el>
                <input type=""number"" min=""1"" step=""any"" placeholder=""R$"" asp-for=""ValorMulta"" class=""form-control"" name=""ValorMulta""/>
                <span asp-validation-for=""ValorMulta"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"">Pessoa</label>
                <div>
                    ");
            EndContext();
            BeginContext(1651, 107, false);
#line 36 "C:\pim\FrotaPim.Web\Views\Multa\Criar.cshtml"
               Write(Html.DropDownList("Id", new SelectList(@Model.Pessoas, "Id", "Nome", "0"), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1758, 189, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">Veículo</label>\r\n                <div>\r\n                    ");
            EndContext();
            BeginContext(1948, 112, false);
#line 42 "C:\pim\FrotaPim.Web\Views\Multa\Criar.cshtml"
               Write(Html.DropDownList("Id", new SelectList(@Model.Carros, "IDCarro", "Placa", "0"), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2060, 230, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-success btn-sm\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2308, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 53 "C:\pim\FrotaPim.Web\Views\Multa\Criar.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrotaPim.Web.Models.ViewsModels.MultaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591