#pragma checksum "C:\pim\FrotaPim.Web\Views\Cargo\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba57944264ebdbd09a5646cd898fbaec20e04177"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cargo_index), @"mvc.1.0.view", @"/Views/Cargo/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cargo/index.cshtml", typeof(AspNetCore.Views_Cargo_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba57944264ebdbd09a5646cd898fbaec20e04177", @"/Views/Cargo/index.cshtml")]
    public class Views_Cargo_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FrotaPim.Web.Models.ViewsModels.CargoViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\pim\FrotaPim.Web\Views\Cargo\index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(109, 280, true);
            WriteLiteral(@"
<div class=""row header"">
    <div class=""col-md-12"">
        <h3>Categories</h3>
        <a href=""/Cargo/CriarOuEditar"" class=""btn btn-primary"">Novo</a>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-12"">
        <table class=""table table-hover"">
            <tbody>
");
            EndContext();
#line 16 "C:\pim\FrotaPim.Web\Views\Cargo\index.cshtml"
                 foreach(var viewModel in @Model)
                {

#line default
#line hidden
            BeginContext(457, 98, true);
            WriteLiteral("                    <tr>\n                        <td>\n                            <a class=\"name\">");
            EndContext();
            BeginContext(556, 19, false);
#line 20 "C:\pim\FrotaPim.Web\Views\Cargo\index.cshtml"
                                       Write(viewModel.NomeCargo);

#line default
#line hidden
            EndContext();
            BeginContext(575, 94, true);
            WriteLiteral("</a>\n                        </td>\n                        <td>\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 669, "\"", 710, 2);
            WriteAttributeValue("", 676, "/Cargo/CriarOuEditar/", 676, 21, true);
#line 23 "C:\pim\FrotaPim.Web\Views\Cargo\index.cshtml"
WriteAttributeValue("", 697, viewModel.Id, 697, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(711, 78, true);
            WriteLiteral(" class=\"btn\">Edit</a>\n                        </td>\n                    </tr>\n");
            EndContext();
#line 26 "C:\pim\FrotaPim.Web\Views\Cargo\index.cshtml"
                }

#line default
#line hidden
            BeginContext(807, 55, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>");
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
