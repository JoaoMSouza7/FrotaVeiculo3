#pragma checksum "C:\pim\FrotaPim.Web\Views\Seguro\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37e0a8c0747f392c630cd842d28bd634b4884411"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seguro_Index), @"mvc.1.0.view", @"/Views/Seguro/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Seguro/Index.cshtml", typeof(AspNetCore.Views_Seguro_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37e0a8c0747f392c630cd842d28bd634b4884411", @"/Views/Seguro/Index.cshtml")]
    public class Views_Seguro_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FrotaPim.Web.Models.ViewsModels.SeguroViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\Seguro\Index.cshtml"
  
    ViewData["Title"] = "Seguros";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(161, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(168, 17, false);
#line 8 "C:\pim\FrotaPim.Web\Views\Seguro\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(185, 193, true);
            WriteLiteral("</h2>\r\n\r\n<p>\r\n    <a href=\"/Seguro/Criar\" class=\"btn btn-primary btn-sm\">Adicionar Novo Seguro</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                <b>");
            EndContext();
            BeginContext(379, 43, false);
#line 17 "C:\pim\FrotaPim.Web\Views\Seguro\Index.cshtml"
              Write(Html.DisplayNameFor(model => model.Apolice));

#line default
#line hidden
            EndContext();
            BeginContext(422, 62, true);
            WriteLiteral("</b>\r\n            </th>\r\n            <th>\r\n                <b>");
            EndContext();
            BeginContext(485, 46, false);
#line 20 "C:\pim\FrotaPim.Web\Views\Seguro\Index.cshtml"
              Write(Html.DisplayNameFor(model => model.Seguradora));

#line default
#line hidden
            EndContext();
            BeginContext(531, 62, true);
            WriteLiteral("</b>\r\n            </th>\r\n            <th>\r\n                <b>");
            EndContext();
            BeginContext(594, 41, false);
#line 23 "C:\pim\FrotaPim.Web\Views\Seguro\Index.cshtml"
              Write(Html.DisplayNameFor(model => model.Placa));

#line default
#line hidden
            EndContext();
            BeginContext(635, 62, true);
            WriteLiteral("</b>\r\n            </th>\r\n            <th>\r\n                <b>");
            EndContext();
            BeginContext(698, 47, false);
#line 26 "C:\pim\FrotaPim.Web\Views\Seguro\Index.cshtml"
              Write(Html.DisplayNameFor(model => model.ValorSeguro));

#line default
#line hidden
            EndContext();
            BeginContext(745, 90, true);
            WriteLiteral("\r\n            </th></b>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "C:\pim\FrotaPim.Web\Views\Seguro\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(867, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(916, 42, false);
#line 35 "C:\pim\FrotaPim.Web\Views\Seguro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apolice));

#line default
#line hidden
            EndContext();
            BeginContext(958, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1014, 45, false);
#line 38 "C:\pim\FrotaPim.Web\Views\Seguro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Seguradora));

#line default
#line hidden
            EndContext();
            BeginContext(1059, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1115, 40, false);
#line 41 "C:\pim\FrotaPim.Web\Views\Seguro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Placa));

#line default
#line hidden
            EndContext();
            BeginContext(1155, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1211, 46, false);
#line 44 "C:\pim\FrotaPim.Web\Views\Seguro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ValorSeguro));

#line default
#line hidden
            EndContext();
            BeginContext(1257, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1314, "\"", 1344, 2);
            WriteAttributeValue("", 1321, "/Seguro/Editar/", 1321, 15, true);
#line 47 "C:\pim\FrotaPim.Web\Views\Seguro\Index.cshtml"
WriteAttributeValue("", 1336, item.Id, 1336, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1345, 64, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Editar</a> |\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1409, "\"", 1441, 2);
            WriteAttributeValue("", 1416, "/Seguro/Detalhes/", 1416, 17, true);
#line 48 "C:\pim\FrotaPim.Web\Views\Seguro\Index.cshtml"
WriteAttributeValue("", 1433, item.Id, 1433, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1442, 159, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Detalhes</a> |\r\n                <a href=\"#deleteModal\" class=\"deleteItem btn btn-danger btn-sm\" data-toggle=\"modal\" data-name=\"");
            EndContext();
            BeginContext(1602, 12, false);
#line 49 "C:\pim\FrotaPim.Web\Views\Seguro\Index.cshtml"
                                                                                                          Write(item.Apolice);

#line default
#line hidden
            EndContext();
            BeginContext(1614, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("code", " code=\"", 1615, "\"", 1630, 1);
#line 49 "C:\pim\FrotaPim.Web\Views\Seguro\Index.cshtml"
WriteAttributeValue("", 1622, item.Id, 1622, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1631, 113, true);
            WriteLiteral("><i class=\"fas fa-trash\" data-toggle=\"tooltip\" title=\"Delete\"></i>Deletar</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 52 "C:\pim\FrotaPim.Web\Views\Seguro\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1747, 1135, true);
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
                <p>Tem certeza que deseja deletar o seguro de Apolice <b class=""data-name bold""></b>?</p>
                <p class=""text-warning"">Está ação não tem volta!</p>
            </div>
            <div class=""modal-footer"">
                <form class=""form-group"" asp-controller=""Seguro"" asp-action=""Delete"" method=""delete"">
                    <div class=""form-actions no-color"">
                        <button id=""btnContinueDelete"" type=""submit"" class=""btn btn-danger btn-sm"">Apagar</button>
                        <button type=""button"" class=""btn btn-primary btn-sm"" data-dismiss=""modal"">Cancelar</butto");
            WriteLiteral("n>\r\n                    </div>\r\n                </form>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FrotaPim.Web.Models.ViewsModels.SeguroViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
