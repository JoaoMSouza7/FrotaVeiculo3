#pragma checksum "C:\pim\FrotaPim.Web\Views\Estoque\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1221104181123d075e38f7af3fce20b41e11fd87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estoque_Index), @"mvc.1.0.view", @"/Views/Estoque/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Estoque/Index.cshtml", typeof(AspNetCore.Views_Estoque_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1221104181123d075e38f7af3fce20b41e11fd87", @"/Views/Estoque/Index.cshtml")]
    public class Views_Estoque_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FrotaPim.Web.Models.ViewsModels.EstoqueViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\Estoque\Index.cshtml"
  
    ViewData["Title"] = "Estoque";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(162, 1102, true);
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
        <a href=""/Manutencao"" class=""btn btn-secondary btn-sm"">Manutenções</a>
    </td>
    <td> <b>|</b> </td>
    <td>
        <a href=""/Multa"" class=""btn btn-secondary btn-sm"">Multas</a>
    </td>
    <td> <b>|</b> </td>
    <td>
        <a href=""/Pessoa"" class=""btn btn-secondary btn-sm"">Funcionários</a>
    </td>
    <td> <b>|</b> </td>
    <td>
        <a href=""/Seguro"" class=""btn btn-secondary btn-sm"">Seguro</a>
    </td>
    <td> <b>|</b> </td>
    <td>
        <a href=""/Viagem");
            WriteLiteral("\" class=\"btn btn-secondary btn-sm\">Viagens</a>\r\n    </td>\r\n<hr/>\r\n</div>\r\n<h1>");
            EndContext();
            BeginContext(1265, 17, false);
#line 46 "C:\pim\FrotaPim.Web\Views\Estoque\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(1282, 313, true);
            WriteLiteral(@"</h1>

<p>
    <a href=""/Estoque/Criar"" class=""btn btn-primary btn-sm"">Adicionar ao estoque</a>
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Peça
            </th>
            <th>
                Descrição
            </th>
            <th>
                ");
            EndContext();
            BeginContext(1596, 46, false);
#line 61 "C:\pim\FrotaPim.Web\Views\Estoque\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fornecedor));

#line default
#line hidden
            EndContext();
            BeginContext(1642, 115, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Valor\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1758, 46, false);
#line 67 "C:\pim\FrotaPim.Web\Views\Estoque\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(1804, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 73 "C:\pim\FrotaPim.Web\Views\Estoque\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1922, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1971, 43, false);
#line 76 "C:\pim\FrotaPim.Web\Views\Estoque\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NomePeca));

#line default
#line hidden
            EndContext();
            BeginContext(2014, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2070, 44, false);
#line 79 "C:\pim\FrotaPim.Web\Views\Estoque\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(2114, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2170, 45, false);
#line 82 "C:\pim\FrotaPim.Web\Views\Estoque\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fornecedor));

#line default
#line hidden
            EndContext();
            BeginContext(2215, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2271, 44, false);
#line 85 "C:\pim\FrotaPim.Web\Views\Estoque\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ValorPeca));

#line default
#line hidden
            EndContext();
            BeginContext(2315, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2371, 45, false);
#line 88 "C:\pim\FrotaPim.Web\Views\Estoque\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(2416, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2473, "\"", 2511, 2);
            WriteAttributeValue("", 2480, "/Estoque/Editar/", 2480, 16, true);
#line 91 "C:\pim\FrotaPim.Web\Views\Estoque\Index.cshtml"
WriteAttributeValue("", 2496, item.IdEstoque, 2496, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2512, 64, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Editar</a> |\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2576, "\"", 2616, 2);
            WriteAttributeValue("", 2583, "/Estoque/Detalhes/", 2583, 18, true);
#line 92 "C:\pim\FrotaPim.Web\Views\Estoque\Index.cshtml"
WriteAttributeValue("", 2601, item.IdEstoque, 2601, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2617, 159, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Detalhes</a> |\r\n                <a href=\"#deleteModal\" class=\"deleteItem btn btn-danger btn-sm\" data-toggle=\"modal\" data-name=\"");
            EndContext();
            BeginContext(2777, 13, false);
#line 93 "C:\pim\FrotaPim.Web\Views\Estoque\Index.cshtml"
                                                                                                          Write(item.NomePeca);

#line default
#line hidden
            EndContext();
            BeginContext(2790, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("code", " code=\"", 2791, "\"", 2813, 1);
#line 93 "C:\pim\FrotaPim.Web\Views\Estoque\Index.cshtml"
WriteAttributeValue("", 2798, item.IdEstoque, 2798, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2814, 113, true);
            WriteLiteral("><i class=\"fas fa-trash\" data-toggle=\"tooltip\" title=\"Delete\"></i>Deletar</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 96 "C:\pim\FrotaPim.Web\Views\Estoque\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2930, 1123, true);
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
                <p>Tem certeza que deseja deletar a peça <b class=""data-name bold""></b>?</p>
                <p class=""text-warning"">Está ação não tem volta!</p>
            </div>
            <div class=""modal-footer"">
                <form class=""form-group"" asp-controller=""Estoque"" asp-action=""Delete"" method=""delete"">
                    <div class=""form-actions no-color"">
                        <button id=""btnContinueDelete"" type=""submit"" class=""btn btn-danger btn-sm"">Apagar</button>
                        <button type=""button"" class=""btn btn-primary btn-sm"" data-dismiss=""modal"">Cancelar</button>
        ");
            WriteLiteral("            </div>\r\n                </form>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FrotaPim.Web.Models.ViewsModels.EstoqueViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
