#pragma checksum "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2f0d4ab76bd08056c2302a845bba9153494a1b5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2f0d4ab76bd08056c2302a845bba9153494a1b5", @"/Views/Pessoa/Index.cshtml")]
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
            BeginContext(176, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(183, 17, false);
#line 8 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(200, 190, true);
            WriteLiteral("</h1>\r\n\r\n<p>\r\n    <a href=\"/Pessoa/Criar\" class=\"btn btn-primary btn-sm\">Adicionar Funcionário</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(391, 40, false);
#line 17 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(431, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(487, 39, false);
#line 20 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CPF));

#line default
#line hidden
            EndContext();
            BeginContext(526, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(582, 44, false);
#line 23 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Admissao));

#line default
#line hidden
            EndContext();
            BeginContext(626, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(682, 44, false);
#line 26 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(726, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(782, 45, false);
#line 29 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NomeCargo));

#line default
#line hidden
            EndContext();
            BeginContext(827, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(945, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(994, 39, false);
#line 38 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1089, 38, false);
#line 41 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CPF));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1183, 43, false);
#line 44 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Admissao));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1282, 43, false);
#line 47 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(1325, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1381, 44, false);
#line 50 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NomeCargo));

#line default
#line hidden
            EndContext();
            BeginContext(1425, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1482, "\"", 1518, 2);
            WriteAttributeValue("", 1489, "/Pessoa/Editar/", 1489, 15, true);
#line 53 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
WriteAttributeValue("", 1504, item.IDPessoa, 1504, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1519, 64, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Editar</a> |\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1583, "\"", 1621, 2);
            WriteAttributeValue("", 1590, "/Pessoa/Detalhes/", 1590, 17, true);
#line 54 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
WriteAttributeValue("", 1607, item.IDPessoa, 1607, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1622, 159, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Detalhes</a> |\r\n                <a href=\"#deleteModal\" class=\"deleteItem btn btn-danger btn-sm\" data-toggle=\"modal\" data-name=\"");
            EndContext();
            BeginContext(1782, 9, false);
#line 55 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
                                                                                                          Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1791, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("code", " code=\"", 1792, "\"", 1813, 1);
#line 55 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
WriteAttributeValue("", 1799, item.IDPessoa, 1799, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1814, 113, true);
            WriteLiteral("><i class=\"fas fa-trash\" data-toggle=\"tooltip\" title=\"Delete\"></i>Deletar</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 58 "C:\pim\FrotaPim.Web\Views\Pessoa\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1930, 1124, true);
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
