#pragma checksum "C:\pim\FrotaPim.Web\Views\ContasAPagar\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d47a8e8cd27a6b457139d95b77d8f0f76f0befcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContasAPagar_Detalhes), @"mvc.1.0.view", @"/Views/ContasAPagar/Detalhes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ContasAPagar/Detalhes.cshtml", typeof(AspNetCore.Views_ContasAPagar_Detalhes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d47a8e8cd27a6b457139d95b77d8f0f76f0befcb", @"/Views/ContasAPagar/Detalhes.cshtml")]
    public class Views_ContasAPagar_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FrotaPim.Web.Models.ViewsModels.ContasAPagarViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes da Despesa";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(166, 37, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>");
            EndContext();
            BeginContext(204, 17, false);
#line 11 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Detalhes.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(221, 86, true);
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(308, 49, false);
#line 15 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.CentroDeCusto));

#line default
#line hidden
            EndContext();
            BeginContext(357, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(421, 45, false);
#line 18 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.CentroDeCusto));

#line default
#line hidden
            EndContext();
            BeginContext(466, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(529, 47, false);
#line 21 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoDespesa));

#line default
#line hidden
            EndContext();
            BeginContext(576, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(640, 43, false);
#line 24 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.TipoDespesa));

#line default
#line hidden
            EndContext();
            BeginContext(683, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(746, 45, false);
#line 27 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(791, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(855, 41, false);
#line 30 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(896, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(959, 46, false);
#line 33 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Vencimento));

#line default
#line hidden
            EndContext();
            BeginContext(1005, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1069, 42, false);
#line 36 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Vencimento));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1174, 41, false);
#line 39 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1215, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1279, 37, false);
#line 42 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1316, 49, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1365, "\"", 1396, 2);
            WriteAttributeValue("", 1372, "../Editar/", 1372, 10, true);
#line 47 "C:\pim\FrotaPim.Web\Views\ContasAPagar\Detalhes.cshtml"
WriteAttributeValue("", 1382, Model.IdConta, 1382, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1397, 122, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Editar</a> |\r\n    <a href=\"../Index\" class=\"btn btn-secondary btn-sm\">Voltar</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrotaPim.Web.Models.ViewsModels.ContasAPagarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591