#pragma checksum "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cb4e927e14f2893d2b74b182233993f243ef383"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Endereco_Index), @"mvc.1.0.view", @"/Views/Endereco/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Endereco/Index.cshtml", typeof(AspNetCore.Views_Endereco_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb4e927e14f2893d2b74b182233993f243ef383", @"/Views/Endereco/Index.cshtml")]
    public class Views_Endereco_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FrotaPim.Web.Models.ViewsModels.EnderecoViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml"
  
    ViewData["Title"] = "Endereços";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(165, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(172, 17, false);
#line 8 "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(189, 93, true);
            WriteLiteral("</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(283, 39, false);
#line 14 "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Rua));

#line default
#line hidden
            EndContext();
            BeginContext(322, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(378, 42, false);
#line 17 "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(420, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(476, 42, false);
#line 20 "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(518, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(574, 39, false);
#line 23 "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CEP));

#line default
#line hidden
            EndContext();
            BeginContext(613, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(669, 42, false);
#line 26 "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(711, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(767, 42, false);
#line 29 "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(809, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(927, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(976, 38, false);
#line 38 "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rua));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1070, 41, false);
#line 41 "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1167, 41, false);
#line 44 "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1208, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1264, 38, false);
#line 47 "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CEP));

#line default
#line hidden
            EndContext();
            BeginContext(1302, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1358, 41, false);
#line 50 "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1399, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1455, 41, false);
#line 53 "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1496, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1553, "\"", 1593, 2);
            WriteAttributeValue("", 1560, "/Endereco/Editar/", 1560, 17, true);
#line 56 "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml"
WriteAttributeValue("", 1577, item.IdEndereco, 1577, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1594, 64, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Editar</a> |\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1658, "\"", 1700, 2);
            WriteAttributeValue("", 1665, "/Endereco/Detalhes/", 1665, 19, true);
#line 57 "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml"
WriteAttributeValue("", 1684, item.IdEndereco, 1684, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1701, 159, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Detalhes</a> |\r\n                <a href=\"#deleteModal\" class=\"deleteItem btn btn-danger btn-sm\" data-toggle=\"modal\" data-name=\"");
            EndContext();
            BeginContext(1861, 8, false);
#line 58 "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml"
                                                                                                          Write(item.CEP);

#line default
#line hidden
            EndContext();
            BeginContext(1869, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("code", " code=\"", 1870, "\"", 1893, 1);
#line 58 "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml"
WriteAttributeValue("", 1877, item.IdEndereco, 1877, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1894, 113, true);
            WriteLiteral("><i class=\"fas fa-trash\" data-toggle=\"tooltip\" title=\"Delete\"></i>Deletar</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 61 "C:\pim\FrotaPim.Web\Views\Endereco\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2010, 1139, true);
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
                <p>Tem certeza que deseja deletar o endereço de CEP <b class=""data-name bold""></b>?</p>
                <p class=""text-warning"">Está ação não tem volta!</p>
            </div>
            <div class=""modal-footer"">
                <form class=""form-group"" asp-controller=""Endereco"" asp-action=""Delete"" method=""delete"">
                    <div class=""form-actions no-color"">
                        <button id=""btnContinueDelete"" type=""submit"" class=""btn btn-danger btn-sm"">Apagar</button>
                        <button type=""button"" class=""btn btn-primary btn-sm"" data-dismiss=""modal"">Cancelar</but");
            WriteLiteral("ton>\r\n                    </div>\r\n                </form>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FrotaPim.Web.Models.ViewsModels.EnderecoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
