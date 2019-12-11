#pragma checksum "C:\pim\FrotaPim.Web\Views\Viagem\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e66f23c19d88a427c3e24b7f23713b3f0b5c8ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Viagem_Index), @"mvc.1.0.view", @"/Views/Viagem/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Viagem/Index.cshtml", typeof(AspNetCore.Views_Viagem_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e66f23c19d88a427c3e24b7f23713b3f0b5c8ca", @"/Views/Viagem/Index.cshtml")]
    public class Views_Viagem_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FrotaPim.Web.Models.ViewsModels.ViagemViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\Viagem\Index.cshtml"
  
    ViewData["Title"] = "Viagens";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(155, 1065, true);
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
        <a href=""/Multa"" class=""btn btn-secondary btn-sm"">Multas</a>
    </td>
    <td> <b>|</b> </td>
    <td>
        <a href=""/Pessoa"" class=""btn btn-secondary btn-sm"">Funcionários</a>
    </td>
    <td> <b>|</b> </td>
    <td>
        <a href=""/Seguro"" class=""btn btn-secondary btn-sm");
            WriteLiteral("\">Seguros</a>\n    </td>\n<hr/>\n</div>\n<h2>");
            EndContext();
            BeginContext(1221, 17, false);
#line 46 "C:\pim\FrotaPim.Web\Views\Viagem\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(1238, 606, true);
            WriteLiteral(@"</h2>

<p>
    <a href=""/Viagem/Criar"" class=""btn btn-primary btn-sm""><i class=""fas fa-plus mx-2""></i>Adicionar Viagem</a>
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Origem
            </th>
            <th>
                Destino
            </th>
            <th>
                KM's
            </th>
            <th>
                Custo da Viagem
            </th>
            <th>
                Carro
            </th>
            <th>
                Motorista
            </th>            
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 76 "C:\pim\FrotaPim.Web\Views\Viagem\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1875, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(1922, 41, false);
#line 79 "C:\pim\FrotaPim.Web\Views\Viagem\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Origem));

#line default
#line hidden
            EndContext();
            BeginContext(1963, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2016, 42, false);
#line 82 "C:\pim\FrotaPim.Web\Views\Viagem\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Destino));

#line default
#line hidden
            EndContext();
            BeginContext(2058, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2111, 37, false);
#line 85 "C:\pim\FrotaPim.Web\Views\Viagem\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.KM));

#line default
#line hidden
            EndContext();
            BeginContext(2148, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2201, 40, false);
#line 88 "C:\pim\FrotaPim.Web\Views\Viagem\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(2241, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2294, 40, false);
#line 91 "C:\pim\FrotaPim.Web\Views\Viagem\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Placa));

#line default
#line hidden
            EndContext();
            BeginContext(2334, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2387, 45, false);
#line 94 "C:\pim\FrotaPim.Web\Views\Viagem\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NomePessoa));

#line default
#line hidden
            EndContext();
            BeginContext(2432, 54, true);
            WriteLiteral("\n            </td>\n            <td>\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2486, "\"", 2516, 2);
            WriteAttributeValue("", 2493, "/Viagem/Editar/", 2493, 15, true);
#line 97 "C:\pim\FrotaPim.Web\Views\Viagem\Index.cshtml"
WriteAttributeValue("", 2508, item.Id, 2508, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2517, 94, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\"><i class=\"fa fa-edit mx-2\"></i>Editar</a> |\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2611, "\"", 2643, 2);
            WriteAttributeValue("", 2618, "/Viagem/Detalhes/", 2618, 17, true);
#line 98 "C:\pim\FrotaPim.Web\Views\Viagem\Index.cshtml"
WriteAttributeValue("", 2635, item.Id, 2635, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2644, 158, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Detalhes</a> |\n                <a href=\"#deleteModal\" class=\"deleteItem btn btn-danger btn-sm\" data-toggle=\"modal\" data-name=\"");
            EndContext();
            BeginContext(2803, 11, false);
#line 99 "C:\pim\FrotaPim.Web\Views\Viagem\Index.cshtml"
                                                                                                          Write(item.Origem);

#line default
#line hidden
            EndContext();
            BeginContext(2814, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(2818, 12, false);
#line 99 "C:\pim\FrotaPim.Web\Views\Viagem\Index.cshtml"
                                                                                                                         Write(item.Destino);

#line default
#line hidden
            EndContext();
            BeginContext(2830, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("code", " code=\"", 2831, "\"", 2846, 1);
#line 99 "C:\pim\FrotaPim.Web\Views\Viagem\Index.cshtml"
WriteAttributeValue("", 2838, item.Id, 2838, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2847, 115, true);
            WriteLiteral("><i class=\"fas fa-trash mx-2\" data-toggle=\"tooltip\" title=\"Delete\"></i>Deletar</a>\n            </td>\n        </tr>\n");
            EndContext();
#line 102 "C:\pim\FrotaPim.Web\Views\Viagem\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2964, 1101, true);
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
                <p>Tem certeza que deseja deletar a Viagem <b class=""data-name bold""></b>?</p>
                <p class=""text-warning"">Está ação não tem volta!</p>
            </div>
            <div class=""modal-footer"">
                <form class=""form-group"" asp-controller=""Viagem"" asp-action=""Delete"" method=""delete"">
                    <div class=""form-actions no-color"">
                        <button id=""btnContinueDelete"" type=""submit"" class=""btn btn-danger btn-sm"">Apagar</button>
                        <button type=""button"" class=""btn btn-primary btn-sm"" data-dismiss=""modal"">Cancelar</button>
                    </div");
            WriteLiteral(">\n                </form>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FrotaPim.Web.Models.ViewsModels.ViagemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
