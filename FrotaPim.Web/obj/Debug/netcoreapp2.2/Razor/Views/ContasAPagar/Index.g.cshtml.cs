#pragma checksum "C:\pim\FrotaPim.Web\Views\ContasAPagar\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ba961d87e081fcbdcdadb67c749666920a8f7bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContasAPagar_Index), @"mvc.1.0.view", @"/Views/ContasAPagar/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ContasAPagar/Index.cshtml", typeof(AspNetCore.Views_ContasAPagar_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ba961d87e081fcbdcdadb67c749666920a8f7bf", @"/Views/ContasAPagar/Index.cshtml")]
    public class Views_ContasAPagar_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FrotaPim.Web.Models.ViewsModels.ContasAPagarViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Index.cshtml"
  
    ViewData["Title"] = "Contas a Pagar";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(174, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(181, 17, false);
#line 8 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(198, 203, true);
            WriteLiteral("</h2>\r\n\r\n<p>\r\n    <a href=\"/ContasAPagar/Criar\" class=\"btn btn-primary btn-sm\">Criar nova conta</a>\r\n</p>\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(402, 49, false);
#line 17 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CentroDeCusto));

#line default
#line hidden
            EndContext();
            BeginContext(451, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(507, 47, false);
#line 20 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TipoDespesa));

#line default
#line hidden
            EndContext();
            BeginContext(554, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(610, 45, false);
#line 23 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(655, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(711, 46, false);
#line 26 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Vencimento));

#line default
#line hidden
            EndContext();
            BeginContext(757, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(813, 41, false);
#line 29 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(854, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(972, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1021, 48, false);
#line 38 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CentroDeCusto));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1125, 46, false);
#line 41 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TipoDespesa));

#line default
#line hidden
            EndContext();
            BeginContext(1171, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1227, 44, false);
#line 44 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1271, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1327, 45, false);
#line 47 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Vencimento));

#line default
#line hidden
            EndContext();
            BeginContext(1372, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1428, 40, false);
#line 50 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1468, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1525, "\"", 1566, 2);
            WriteAttributeValue("", 1532, "/ContasAPagar/Editar/", 1532, 21, true);
#line 53 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Index.cshtml"
WriteAttributeValue("", 1553, item.IdConta, 1553, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1567, 64, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Editar</a> |\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1631, "\"", 1674, 2);
            WriteAttributeValue("", 1638, "/ContasAPagar/Detalhes/", 1638, 23, true);
#line 54 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Index.cshtml"
WriteAttributeValue("", 1661, item.IdConta, 1661, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1675, 159, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Detalhes</a> |\r\n                <a href=\"#deleteModal\" class=\"deleteItem btn btn-danger btn-sm\" data-toggle=\"modal\" data-name=\"");
            EndContext();
            BeginContext(1835, 16, false);
#line 55 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Index.cshtml"
                                                                                                          Write(item.TipoDespesa);

#line default
#line hidden
            EndContext();
            BeginContext(1851, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("code", " code=\"", 1852, "\"", 1872, 1);
#line 55 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Index.cshtml"
WriteAttributeValue("", 1859, item.IdConta, 1859, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1873, 113, true);
            WriteLiteral("><i class=\"fas fa-trash\" data-toggle=\"tooltip\" title=\"Delete\"></i>Deletar</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 58 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1989, 1129, true);
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
                <p>Tem certeza que deseja deletar a conta <b class=""data-name bold""></b>?</p>
                <p class=""text-warning"">Está ação não tem volta!</p>
            </div>
            <div class=""modal-footer"">
                <form class=""form-group"" asp-controller=""ContasAPagar"" asp-action=""Delete"" method=""delete"">
                    <div class=""form-actions no-color"">
                        <button id=""btnContinueDelete"" type=""submit"" class=""btn btn-danger btn-sm"">Apagar</button>
                        <button type=""button"" class=""btn btn-primary btn-sm"" data-dismiss=""modal"">Cancelar</button>
  ");
            WriteLiteral("                  </div>\r\n                </form>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FrotaPim.Web.Models.ViewsModels.ContasAPagarViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
