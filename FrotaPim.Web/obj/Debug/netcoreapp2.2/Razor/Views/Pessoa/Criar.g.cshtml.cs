#pragma checksum "C:\pim\FrotaPim.Web\Views\Pessoa\Criar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7771d81cc1f6a0f26cd3634a708d62e230c1a272"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoa_Criar), @"mvc.1.0.view", @"/Views/Pessoa/Criar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pessoa/Criar.cshtml", typeof(AspNetCore.Views_Pessoa_Criar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7771d81cc1f6a0f26cd3634a708d62e230c1a272", @"/Views/Pessoa/Criar.cshtml")]
    public class Views_Pessoa_Criar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FrotaPim.Web.Models.ViewsModels.PessoaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\Pessoa\Criar.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(147, 69, true);
            WriteLiteral("\r\n<div class=\"row header\">\r\n    <div class=\"col-md-12\">\r\n        <h3>");
            EndContext();
            BeginContext(217, 17, false);
#line 10 "C:\pim\FrotaPim.Web\Views\Pessoa\Criar.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(234, 1643, true);
            WriteLiteral(@"</h3>
        <a href=""/Pessoa"" class=""btn btn-secondary btn-sm"">Voltar</a>
    </div>
</div>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Criar"" asp-controller=""Pessoa"" method=""post"" asp-anti-forgery>
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Nome"" class=""control-label"">Nome</label>
                <input asp-for=""Nome"" class=""form-control"" name=""Nome""/>
                <span asp-validation-for=""Nome"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CPF"" class=""control-label"">CPF</label>
                <input asp-for=""CPF"" class=""form-control"" name=""CPF""/>
                <span asp-validation-for=""CPF"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Admissao"" class=""control-label"">Admissao</label>
                <inp");
            WriteLiteral(@"ut type=""date"" asp-for=""Admissao"" class=""form-control"" name=""Admissao""/>
                <span asp-validation-for=""Admissao"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Telefone"" class=""control-label"">Telefone</label>
                <input asp-for=""Telefone"" class=""form-control"" name=""Telefone""/>
                <span asp-validation-for=""Telefone"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"">Cargo</label>
                <div>
                    ");
            EndContext();
            BeginContext(1878, 116, false);
#line 42 "C:\pim\FrotaPim.Web\Views\Pessoa\Criar.cshtml"
               Write(Html.DropDownList("CargoId", new SelectList(@Model.Cargos, "CargoId", "Nome", "0"), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1994, 230, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-success btn-sm\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2242, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 53 "C:\pim\FrotaPim.Web\Views\Pessoa\Criar.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrotaPim.Web.Models.ViewsModels.PessoaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
