#pragma checksum "C:\pim\FrotaPim.Web\Views\Cargo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0adb07831ecf86885ab112d6b361c39b6a7791d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cargo_Index), @"mvc.1.0.view", @"/Views/Cargo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cargo/Index.cshtml", typeof(AspNetCore.Views_Cargo_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0adb07831ecf86885ab112d6b361c39b6a7791d", @"/Views/Cargo/Index.cshtml")]
    public class Views_Cargo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FrotaPim.Web.Models.ViewsModels.CargoViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\Cargo\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(158, 182, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a href=\"/Cargo/Criar\" class=\"btn btn-primary\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(341, 40, false);
#line 17 "C:\pim\FrotaPim.Web\Views\Cargo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(381, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(437, 45, false);
#line 20 "C:\pim\FrotaPim.Web\Views\Cargo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(482, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 26 "C:\pim\FrotaPim.Web\Views\Cargo\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(600, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(649, 39, false);
#line 29 "C:\pim\FrotaPim.Web\Views\Cargo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(688, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(744, 44, false);
#line 32 "C:\pim\FrotaPim.Web\Views\Cargo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(788, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 845, "\"", 874, 2);
            WriteAttributeValue("", 852, "/Cargo/Editar/", 852, 14, true);
#line 35 "C:\pim\FrotaPim.Web\Views\Cargo\Index.cshtml"
WriteAttributeValue("", 866, item.Id, 866, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(875, 43, true);
            WriteLiteral(" class=\"btn\">Edit</a> |\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 918, "\"", 949, 2);
            WriteAttributeValue("", 925, "/Cargo/Detalhes/", 925, 16, true);
#line 36 "C:\pim\FrotaPim.Web\Views\Cargo\Index.cshtml"
WriteAttributeValue("", 941, item.Id, 941, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(950, 58, true);
            WriteLiteral(" class=\"btn btn-primary\">Details</a> |\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1008, "\"", 1038, 2);
            WriteAttributeValue("", 1015, "/Cargo/Deletar/", 1015, 15, true);
#line 37 "C:\pim\FrotaPim.Web\Views\Cargo\Index.cshtml"
WriteAttributeValue("", 1030, item.Id, 1030, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1039, 59, true);
            WriteLiteral(" class=\"btn\">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 40 "C:\pim\FrotaPim.Web\Views\Cargo\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1101, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FrotaPim.Web.Models.ViewsModels.CargoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
