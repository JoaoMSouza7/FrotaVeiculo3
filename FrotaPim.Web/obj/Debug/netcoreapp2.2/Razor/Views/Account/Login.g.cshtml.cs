#pragma checksum "C:\pim\FrotaPim.Web\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "619e6644bb87038447a09ccfeb9fc68eeafff610"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"619e6644bb87038447a09ccfeb9fc68eeafff610", @"/Views/Account/Login.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FrotaPim.Web.Models.ViewsModels.LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\pim\FrotaPim.Web\Views\Account\Login.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(145, 17, false);
#line 8 "C:\pim\FrotaPim.Web\Views\Account\Login.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(162, 1403, true);
            WriteLiteral(@"</h2>
<div class=""row"">
    <div class=""col-md-8"">
        <section>
            <form asp-controller=""Account"" asp-action=""Login"" method=""post"" class=""form-group"">
                <hr />
                <div asp-validation-summary=""All"" class=""text-danger""></div>
                <div class=""form-group"">
                    <label asp-for=""Email"" class=""col-md-2 control-label""><b>Email</b></label>
                    <div class=""col-md-10"">
                        <input asp-for=""Email"" class=""form-control"" name=""Email"" type=""require""/>
                        <span asp-validation-for=""Email"" class=""text-danger""></span>
                    </div>
                </div>
                <div class=""form-group"">
                    <label asp-for=""Password"" class=""col-md-2 control-label""><b>Senha</b></label>
                    <div class=""col-md-10"">
                        <input asp-for=""Password"" class=""form-control"" name=""Password"" type=""require""/>
                        <span asp-validation-for=""Password""");
            WriteLiteral(@" class=""text-danger""></span>
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""col-md-offset-2 col-md-10"">
                        <button type=""submit"" class=""btn btn-primary btn-sm"">Login</button>
                    </div>
                </div>
            </form>
        </section>
    </div>
</div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1583, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 39 "C:\pim\FrotaPim.Web\Views\Account\Login.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrotaPim.Web.Models.ViewsModels.LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
