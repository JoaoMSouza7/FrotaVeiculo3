#pragma checksum "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46c24bf2e4a2b3b8b8af5ea1784ab25abef3f79c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoa_Index), @"mvc.1.0.view", @"/Views/Pessoa/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pessoa/Index.cshtml", typeof(AspNetCore.Views_Pessoa_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46c24bf2e4a2b3b8b8af5ea1784ab25abef3f79c", @"/Views/Pessoa/Index.cshtml")]
    public class Views_Pessoa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FrotaPim.Web.Models.ViewsModels.PessoaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
  
    ViewData["Title"] = "Quadro de Funcionários";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(176, 979, true);
            WriteLiteral(@"<div>
    <hr />
    <td>
        <a href=""/Cargo"" class=""btn btn-secondary btn-sm"">Cargos</a>
    </td>
    <td> <b>|</b> </td> 
    <td>
        <a href=""/Carro"" class=""btn btn-secondary btn-sm"">Carros</a>
    </td>
    <td> <b>|</b> </td>
    <td>
        <a href=""/ContasAPagar"" class=""btn btn-secondary btn-sm"">Contas a Pagar</a>
    </td>
    <td> <b>|</b> </td>    
    <td>
        <a href=""/Endereco"" class=""btn btn-secondary btn-sm"">Endereço</a>
    </td>
    <td> <b>|</b> </td>
    <td>
        <a href=""/Estoque"" class=""btn btn-secondary btn-sm"">Estoque</a>
    </td>
    <td> <b>|</b> </td>
    <td>
        <a href=""/Manutencao"" class=""btn btn-secondary btn-sm"">Manutenções</a>
    </td>
    <td> <b>|</b> </td>
    <td>
        <a href=""/Multa"" class=""btn btn-secondary btn-sm"">Multa</a>
    </td>
    <td> <b>|</b> </td>
    <td>
        <a href=""/Seguro"" class=""btn btn-secondary btn-sm"">Seguro</a>
    </td>
<hr/>
</div>
<h2>");
            EndContext();
            BeginContext(1156, 17, false);
#line 42 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(1173, 190, true);
            WriteLiteral("</h1>\r\n\r\n<p>\r\n    <a href=\"/Pessoa/Criar\" class=\"btn btn-primary btn-sm\">Adicionar Funcionário</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1364, 40, false);
#line 51 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1404, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1460, 39, false);
#line 54 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CPF));

#line default
#line hidden
            EndContext();
            BeginContext(1499, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1555, 44, false);
#line 57 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Admissao));

#line default
#line hidden
            EndContext();
            BeginContext(1599, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1655, 44, false);
#line 60 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(1699, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1755, 45, false);
#line 63 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NomeCargo));

#line default
#line hidden
            EndContext();
            BeginContext(1800, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 69 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1918, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1967, 39, false);
#line 72 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2006, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2062, 38, false);
#line 75 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CPF));

#line default
#line hidden
            EndContext();
            BeginContext(2100, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2156, 43, false);
#line 78 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Admissao));

#line default
#line hidden
            EndContext();
            BeginContext(2199, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2255, 43, false);
#line 81 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(2298, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2354, 44, false);
#line 84 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NomeCargo));

#line default
#line hidden
            EndContext();
            BeginContext(2398, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2455, "\"", 2491, 2);
            WriteAttributeValue("", 2462, "/Pessoa/Editar/", 2462, 15, true);
#line 87 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
WriteAttributeValue("", 2477, item.IDPessoa, 2477, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2492, 64, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Editar</a> |\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2556, "\"", 2594, 2);
            WriteAttributeValue("", 2563, "/Pessoa/Detalhes/", 2563, 17, true);
#line 88 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
WriteAttributeValue("", 2580, item.IDPessoa, 2580, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2595, 159, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Detalhes</a> |\r\n                <a href=\"#deleteModal\" class=\"deleteItem btn btn-danger btn-sm\" data-toggle=\"modal\" data-name=\"");
            EndContext();
            BeginContext(2755, 9, false);
#line 89 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
                                                                                                          Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2764, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("code", " code=\"", 2765, "\"", 2786, 1);
#line 89 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
WriteAttributeValue("", 2772, item.IDPessoa, 2772, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2787, 113, true);
            WriteLiteral("><i class=\"fas fa-trash\" data-toggle=\"tooltip\" title=\"Delete\"></i>Deletar</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 92 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2903, 1124, true);
            WriteLiteral(@"    </tbody>
</table>
<div id=""deleteModal"" class=""modal fade"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Deletar</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
            </div>
            <div class=""modal-body"">
                <p>Tem certeza que deseja deletar a pessoa <b class=""data-name bold""></b>?</p>
                <p class=""text-warning"">Está ação não tem volta!</p>
            </div>
            <div class=""modal-footer"">
                <form class=""form-group"" asp-controller=""Pessoa"" asp-action=""Delete"" method=""delete"">
                    <div class=""form-actions no-color"">
                        <button id=""btnContinueDelete"" type=""submit"" class=""btn btn-danger btn-sm"">Apagar</button>
                        <button type=""button"" class=""btn btn-primary btn-sm"" data-dismiss=""modal"">Cancelar</button>
       ");
            WriteLiteral("             </div>\r\n                </form>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FrotaPim.Web.Models.ViewsModels.PessoaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
