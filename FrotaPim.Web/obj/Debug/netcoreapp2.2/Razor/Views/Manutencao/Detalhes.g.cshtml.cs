#pragma checksum "C:\pim\FrotaPim.Web\Views\Manutencao\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c227dc5462165947146b0f0cbc5f2e4a3682070"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manutencao_Detalhes), @"mvc.1.0.view", @"/Views/Manutencao/Detalhes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manutencao/Detalhes.cshtml", typeof(AspNetCore.Views_Manutencao_Detalhes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c227dc5462165947146b0f0cbc5f2e4a3682070", @"/Views/Manutencao/Detalhes.cshtml")]
    public class Views_Manutencao_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FrotaPim.Web.Models.ViewsModels.ManutencaoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\Manutencao\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(153, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(160, 17, false);
#line 8 "C:\pim\FrotaPim.Web\Views\Manutencao\Detalhes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(177, 93, true);
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(271, 55, false);
#line 14 "C:\pim\FrotaPim.Web\Views\Manutencao\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.DescricaoManutencao));

#line default
#line hidden
            EndContext();
            BeginContext(326, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(388, 51, false);
#line 17 "C:\pim\FrotaPim.Web\Views\Manutencao\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.DescricaoManutencao));

#line default
#line hidden
            EndContext();
            BeginContext(439, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(500, 41, false);
#line 20 "C:\pim\FrotaPim.Web\Views\Manutencao\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(541, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(603, 37, false);
#line 23 "C:\pim\FrotaPim.Web\Views\Manutencao\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(640, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(701, 40, false);
#line 26 "C:\pim\FrotaPim.Web\Views\Manutencao\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(741, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(803, 36, false);
#line 29 "C:\pim\FrotaPim.Web\Views\Manutencao\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(839, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(900, 41, false);
#line 32 "C:\pim\FrotaPim.Web\Views\Manutencao\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Placa));

#line default
#line hidden
            EndContext();
            BeginContext(941, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1003, 37, false);
#line 35 "C:\pim\FrotaPim.Web\Views\Manutencao\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Placa));

#line default
#line hidden
            EndContext();
            BeginContext(1040, 49, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1089, "\"", 1115, 2);
            WriteAttributeValue("", 1096, "../Editar/", 1096, 10, true);
#line 40 "C:\pim\FrotaPim.Web\Views\Manutencao\Detalhes.cshtml"
WriteAttributeValue("", 1106, Model.Id, 1106, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1116, 122, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrotaPim.Web.Models.ViewsModels.ManutencaoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
