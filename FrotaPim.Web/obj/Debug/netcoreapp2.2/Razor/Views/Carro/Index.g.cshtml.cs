#pragma checksum "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc2a709435ab1e10c51df1c0c1f9dfd3781e9fa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carro_Index), @"mvc.1.0.view", @"/Views/Carro/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Carro/Index.cshtml", typeof(AspNetCore.Views_Carro_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc2a709435ab1e10c51df1c0c1f9dfd3781e9fa3", @"/Views/Carro/Index.cshtml")]
    public class Views_Carro_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FrotaPim.Web.Models.ViewsModels.CarroViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
  
    ViewData["Title"] = "Veículos";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(161, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(168, 17, false);
#line 8 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(185, 184, true);
            WriteLiteral("</h2>\r\n\r\n<p>\r\n    <a href=\"/Carro/Criar\" class=\"btn btn-primary btn-sm\">Criar novo cargo</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(370, 41, false);
#line 17 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Placa));

#line default
#line hidden
            EndContext();
            BeginContext(411, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(467, 40, false);
#line 20 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(507, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(563, 41, false);
#line 23 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Marca));

#line default
#line hidden
            EndContext();
            BeginContext(604, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(660, 42, false);
#line 26 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Modelo));

#line default
#line hidden
            EndContext();
            BeginContext(702, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(758, 47, false);
#line 29 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Combustivel));

#line default
#line hidden
            EndContext();
            BeginContext(805, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(861, 39, false);
#line 32 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cor));

#line default
#line hidden
            EndContext();
            BeginContext(900, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(956, 39, false);
#line 35 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ano));

#line default
#line hidden
            EndContext();
            BeginContext(995, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1051, 46, false);
#line 38 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model._Motorista));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 44 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1215, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1264, 40, false);
#line 47 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Placa));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1360, 39, false);
#line 50 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(1399, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1455, 40, false);
#line 53 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Marca));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1551, 41, false);
#line 56 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Modelo));

#line default
#line hidden
            EndContext();
            BeginContext(1592, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1648, 46, false);
#line 59 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Combustivel));

#line default
#line hidden
            EndContext();
            BeginContext(1694, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1750, 38, false);
#line 62 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cor));

#line default
#line hidden
            EndContext();
            BeginContext(1788, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1844, 38, false);
#line 65 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ano));

#line default
#line hidden
            EndContext();
            BeginContext(1882, 54, true);
            WriteLiteral("\r\n            </td>\r\n           <td>\r\n                ");
            EndContext();
            BeginContext(1937, 45, false);
#line 68 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item._Motorista));

#line default
#line hidden
            EndContext();
            BeginContext(1982, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2039, "\"", 2073, 2);
            WriteAttributeValue("", 2046, "/Carro/Editar/", 2046, 14, true);
#line 71 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
WriteAttributeValue("", 2060, item.IDCarro, 2060, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2074, 64, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Editar</a> |\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2138, "\"", 2174, 2);
            WriteAttributeValue("", 2145, "/Carro/Detalhes/", 2145, 16, true);
#line 72 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
WriteAttributeValue("", 2161, item.IDCarro, 2161, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2175, 159, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Detalhes</a> |\r\n                <a href=\"#deleteModal\" class=\"deleteItem btn btn-danger btn-sm\" data-toggle=\"modal\" data-name=\"");
            EndContext();
            BeginContext(2335, 10, false);
#line 73 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
                                                                                                          Write(item.Placa);

#line default
#line hidden
            EndContext();
            BeginContext(2345, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("code", " code=\"", 2346, "\"", 2366, 1);
#line 73 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
WriteAttributeValue("", 2353, item.IDCarro, 2353, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2367, 113, true);
            WriteLiteral("><i class=\"fas fa-trash\" data-toggle=\"tooltip\" title=\"Delete\"></i>Deletar</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 76 "C:\pim\FrotaPim.Web\Views\Carro\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2483, 1138, true);
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
                <p>Tem certeza que deseja deletar o carro com a placa <b class=""data-name bold""></b>?</p>
                <p class=""text-warning"">Está ação não tem volta!</p>
            </div>
            <div class=""modal-footer"">
                <form class=""form-group"" asp-controller=""Carro"" asp-action=""Delete"" method=""delete"">
                    <div class=""form-actions no-color"">
                        <button id=""btnContinueDelete"" type=""submit"" class=""btn btn-danger btn-sm"">Apagar</button>
                        <button type=""button"" class=""btn btn-primary btn-sm"" data-dismiss=""modal"">Cancelar</butt");
            WriteLiteral("on>\r\n                    </div>\r\n                </form>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FrotaPim.Web.Models.ViewsModels.CarroViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
