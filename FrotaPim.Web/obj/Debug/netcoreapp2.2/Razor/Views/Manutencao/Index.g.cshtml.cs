#pragma checksum "C:\pim\FrotaPim.Web\Views\Manutencao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d94f654c827eb75e2263bdc29513816fbb731c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manutencao_Index), @"mvc.1.0.view", @"/Views/Manutencao/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manutencao/Index.cshtml", typeof(AspNetCore.Views_Manutencao_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d94f654c827eb75e2263bdc29513816fbb731c8", @"/Views/Manutencao/Index.cshtml")]
    public class Views_Manutencao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FrotaPim.Web.Models.ViewsModels.ManutencaoViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\Manutencao\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(163, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(170, 17, false);
#line 8 "C:\pim\FrotaPim.Web\Views\Manutencao\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(187, 193, true);
            WriteLiteral("</h1>\r\n\r\n<p>\r\n    <a href=\"/Manutencao/Criar\" class=\"btn btn-primary btn-sm\">Adicionar Manutenção</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(381, 55, false);
#line 17 "C:\pim\FrotaPim.Web\Views\Manutencao\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DescricaoManutencao));

#line default
#line hidden
            EndContext();
            BeginContext(436, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(492, 41, false);
#line 20 "C:\pim\FrotaPim.Web\Views\Manutencao\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(533, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(589, 40, false);
#line 23 "C:\pim\FrotaPim.Web\Views\Manutencao\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(629, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(685, 41, false);
#line 26 "C:\pim\FrotaPim.Web\Views\Manutencao\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Placa));

#line default
#line hidden
            EndContext();
            BeginContext(726, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "C:\pim\FrotaPim.Web\Views\Manutencao\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(861, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(910, 54, false);
#line 36 "C:\pim\FrotaPim.Web\Views\Manutencao\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DescricaoManutencao));

#line default
#line hidden
            EndContext();
            BeginContext(964, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1020, 40, false);
#line 39 "C:\pim\FrotaPim.Web\Views\Manutencao\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1116, 39, false);
#line 42 "C:\pim\FrotaPim.Web\Views\Manutencao\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
            EndContext();
            BeginContext(1155, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1211, 40, false);
#line 45 "C:\pim\FrotaPim.Web\Views\Manutencao\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Placa));

#line default
#line hidden
            EndContext();
            BeginContext(1251, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1308, "\"", 1342, 2);
            WriteAttributeValue("", 1315, "/Manutencao/Editar/", 1315, 19, true);
#line 48 "C:\pim\FrotaPim.Web\Views\Manutencao\Index.cshtml"
WriteAttributeValue("", 1334, item.Id, 1334, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1343, 64, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Editar</a> |\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1407, "\"", 1443, 2);
            WriteAttributeValue("", 1414, "/Manutencao/Detalhes/", 1414, 21, true);
#line 49 "C:\pim\FrotaPim.Web\Views\Manutencao\Index.cshtml"
WriteAttributeValue("", 1435, item.Id, 1435, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1444, 159, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Detalhes</a> |\r\n                <a href=\"#deleteModal\" class=\"deleteItem btn btn-danger btn-sm\" data-toggle=\"modal\" data-name=\"");
            EndContext();
            BeginContext(1604, 24, false);
#line 50 "C:\pim\FrotaPim.Web\Views\Manutencao\Index.cshtml"
                                                                                                          Write(item.DescricaoManutencao);

#line default
#line hidden
            EndContext();
            BeginContext(1628, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("code", " code=\"", 1629, "\"", 1644, 1);
#line 50 "C:\pim\FrotaPim.Web\Views\Manutencao\Index.cshtml"
WriteAttributeValue("", 1636, item.Id, 1636, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1645, 113, true);
            WriteLiteral("><i class=\"fas fa-trash\" data-toggle=\"tooltip\" title=\"Delete\"></i>Deletar</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 53 "C:\pim\FrotaPim.Web\Views\Manutencao\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1769, 1104, true);
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
                <p>Tem certeza que deseja deletar a Manutenção <b class=""data-name bold""></b>?</p>
                <p class=""text-warning"">Está ação não tem volta!</p>
            </div>
            <div class=""modal-footer"">
                <form class=""form-group"" asp-action=""Delete"" method=""delete"">
                    <div class=""form-actions no-color"">
                        <button id=""btnContinueDelete"" type=""submit"" class=""btn btn-danger btn-sm"">Apagar</button>
                        <button type=""button"" class=""btn btn-primary btn-sm"" data-dismiss=""modal"">Cancelar</button>
                    </div>
            WriteLiteral("\n                </form>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FrotaPim.Web.Models.ViewsModels.ManutencaoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591