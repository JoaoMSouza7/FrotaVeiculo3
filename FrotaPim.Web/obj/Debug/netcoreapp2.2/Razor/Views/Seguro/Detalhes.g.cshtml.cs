#pragma checksum "C:\pim\FrotaPim.Web\Views\Seguro\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed7e9af03597509ff7be56cbe19a4de8ade8c3ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seguro_Detalhes), @"mvc.1.0.view", @"/Views/Seguro/Detalhes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Seguro/Detalhes.cshtml", typeof(AspNetCore.Views_Seguro_Detalhes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed7e9af03597509ff7be56cbe19a4de8ade8c3ea", @"/Views/Seguro/Detalhes.cshtml")]
    public class Views_Seguro_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FrotaPim.Web.Models.ViewsModels.SeguroViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\Seguro\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(149, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(156, 17, false);
#line 8 "C:\pim\FrotaPim.Web\Views\Seguro\Detalhes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(173, 93, true);
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(267, 43, false);
#line 14 "C:\pim\FrotaPim.Web\Views\Seguro\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Apolice));

#line default
#line hidden
            EndContext();
            BeginContext(310, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(372, 39, false);
#line 17 "C:\pim\FrotaPim.Web\Views\Seguro\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Apolice));

#line default
#line hidden
            EndContext();
            BeginContext(411, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(472, 46, false);
#line 20 "C:\pim\FrotaPim.Web\Views\Seguro\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Seguradora));

#line default
#line hidden
            EndContext();
            BeginContext(518, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(580, 42, false);
#line 23 "C:\pim\FrotaPim.Web\Views\Seguro\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Seguradora));

#line default
#line hidden
            EndContext();
            BeginContext(622, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(683, 41, false);
#line 26 "C:\pim\FrotaPim.Web\Views\Seguro\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Placa));

#line default
#line hidden
            EndContext();
            BeginContext(724, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(786, 37, false);
#line 29 "C:\pim\FrotaPim.Web\Views\Seguro\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Placa));

#line default
#line hidden
            EndContext();
            BeginContext(823, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(884, 51, false);
#line 32 "C:\pim\FrotaPim.Web\Views\Seguro\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.DataContratacao));

#line default
#line hidden
            EndContext();
            BeginContext(935, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(997, 47, false);
#line 35 "C:\pim\FrotaPim.Web\Views\Seguro\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.DataContratacao));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1105, 48, false);
#line 38 "C:\pim\FrotaPim.Web\Views\Seguro\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.DataValidade));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1215, 44, false);
#line 41 "C:\pim\FrotaPim.Web\Views\Seguro\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.DataValidade));

#line default
#line hidden
            EndContext();
            BeginContext(1259, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1320, 47, false);
#line 44 "C:\pim\FrotaPim.Web\Views\Seguro\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorSeguro));

#line default
#line hidden
            EndContext();
            BeginContext(1367, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1429, 43, false);
#line 47 "C:\pim\FrotaPim.Web\Views\Seguro\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.ValorSeguro));

#line default
#line hidden
            EndContext();
            BeginContext(1472, 49, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1521, "\"", 1547, 2);
            WriteAttributeValue("", 1528, "../Editar/", 1528, 10, true);
#line 52 "C:\pim\FrotaPim.Web\Views\Seguro\Detalhes.cshtml"
WriteAttributeValue("", 1538, Model.Id, 1538, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1548, 153, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\"><i class=\"fa fa-edit mx-2\"></i>Editar</a> |\r\n    <a href=\"../Index\" class=\"btn btn-secondary btn-sm\">Voltar</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrotaPim.Web.Models.ViewsModels.SeguroViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
