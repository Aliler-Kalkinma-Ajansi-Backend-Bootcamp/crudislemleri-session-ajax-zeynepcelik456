#pragma checksum "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e7cc43e497cc7092bae0f5adce0d66852b687f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e7cc43e497cc7092bae0f5adce0d66852b687f5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdddf134c2c212dee595d80fc1e04f58074a7a42", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KutuphanePaneli.Models.TblHareket>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-primary shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">
                            <p class=""card-category"">Toplam Kitap Sayısı</p>
                        </div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 16 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Home\Index.cshtml"
                                                                       Write(ViewBag.tk);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        <div class=""col-auto"">
                            <i class=""fas fa-book fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-success shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-success text-uppercase mb-1"">
                            Toplam Üye Sayısı
                        </div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 33 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Home\Index.cshtml"
                                                                       Write(ViewBag.tu);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-user fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-info shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-info text-uppercase mb-1"">
                            Toplam Yazar Sayısı
                        </div>
                        <div class=""row no-gutters align-items-center"">
                            <div class=""col-auto"">
                                <div class=""h5 mb-0 mr-3 font-weight-bold text-gray-800"">");
#nullable restore
#line 52 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Home\Index.cshtml"
                                                                                    Write(ViewBag.ty);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                            <div class=""col"">
                            </div>
                        </div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-user-edit fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-warning shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-warning text-uppercase mb-1"">
                            Toplam İşlem Sayısı
                        </div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 73 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Home\Index.cshtml"
                                                                       Write(ViewBag.tı);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-key fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <h6 class=""m-0 font-weight-bold text-primary"">Yapılan Tüm İşlemler</h6>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>
                            Kitap
                        </th>
                        <th>
                            Üye
                        </th>
                        <th>
                            Personel
                        </th>
                        <th>
                            İşlem Durumu
                        </");
            WriteLiteral("th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 108 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Home\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 112 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.KitapNavigation.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 115 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UyeNavigation.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;   ");
#nullable restore
#line 115 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Home\Index.cshtml"
                                                                                        Write(Html.DisplayFor(modelItem => item.UyeNavigation.Soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 118 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PersonelNavigation.Personel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 122 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Islemdurum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 127 "C:\Users\90538\Source\Repos\KutuphanePaneli\KutuphanePaneli\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KutuphanePaneli.Models.TblHareket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
