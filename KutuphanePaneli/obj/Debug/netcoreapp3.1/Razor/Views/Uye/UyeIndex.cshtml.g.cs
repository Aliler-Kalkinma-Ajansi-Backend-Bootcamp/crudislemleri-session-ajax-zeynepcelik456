#pragma checksum "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Uye\UyeIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d819cd72263a95d80672691a6a5015b4e9d7da1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Uye_UyeIndex), @"mvc.1.0.view", @"/Views/Uye/UyeIndex.cshtml")]
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
#nullable restore
#line 1 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\_ViewImports.cshtml"
using KutuphanePaneli;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\_ViewImports.cshtml"
using KutuphanePaneli.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d819cd72263a95d80672691a6a5015b4e9d7da1", @"/Views/Uye/UyeIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdddf134c2c212dee595d80fc1e04f58074a7a42", @"/Views/_ViewImports.cshtml")]
    public class Views_Uye_UyeIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KutuphanePaneli.Models.TblUye>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Uye", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UyeEkle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Uye\UyeIndex.cshtml"
  
    ViewData["Title"] = "Uyeler";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"h3 mb-2 text-gray-800\"> Üyeler</h1>\r\n<div class=\"card shadow mb-4\">\r\n    <div class=\"card-header py-3\">\r\n        <h6 class=\"m-0 font-weight-bold text-primary\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d819cd72263a95d80672691a6a5015b4e9d7da14562", async() => {
                WriteLiteral("Yeni Uye Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h6>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">

                <table class=""table"">
                    <thead>
                        <tr>
                            <th>
                                Ad
                            </th>
                            <th>
                                Soyad
                            </th>
                            <th>
                                Mail
                            </th>
                            <th>
                                Telefon
                            </th>
                            <th>

                            </th>
                            <th>

                            </th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 42 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Uye\UyeIndex.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 46 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Uye\UyeIndex.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 49 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Uye\UyeIndex.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 52 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Uye\UyeIndex.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Maİl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 55 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Uye\UyeIndex.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 58 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Uye\UyeIndex.cshtml"
                               Write(Html.ActionLink("Guncelle", "UyeGetir", "Uye",
                                        new { id = item.Id },
                                        new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n\r\n                                    ");
#nullable restore
#line 64 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Uye\UyeIndex.cshtml"
                               Write(Html.ActionLink("Sil", "UyeSil", "Uye",
                                    new { id = item.Id },
                                    new { @class = "btn btn-danger" }

                                   ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 72 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Uye\UyeIndex.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n\r\n\r\n\r\n\r\n            </table>\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KutuphanePaneli.Models.TblUye>> Html { get; private set; }
    }
}
#pragma warning restore 1591
