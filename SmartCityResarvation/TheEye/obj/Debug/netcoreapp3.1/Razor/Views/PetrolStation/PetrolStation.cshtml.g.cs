#pragma checksum "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\PetrolStation\PetrolStation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f55cc567231628fd433dcdc96a6e1cfced1540af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PetrolStation_PetrolStation), @"mvc.1.0.view", @"/Views/PetrolStation/PetrolStation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f55cc567231628fd433dcdc96a6e1cfced1540af", @"/Views/PetrolStation/PetrolStation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25fd987d7388ad707b6b8d314dfa2b63ad979348", @"/Views/_ViewImports.cshtml")]
    public class Views_PetrolStation_PetrolStation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TheEye.Entities.Concrete.PetrolStation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\PetrolStation\PetrolStation.cshtml"
  
    ViewBag.Title = "Petrol Ofisleri";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\PetrolStation\PetrolStation.cshtml"
Write(await Html.PartialAsync("MainSite/_Banner"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <br />\r\n    <div class=\"input-group mb-3\">\r\n        <input id=\"input-text\" type=\"text\" class=\"form-control\" placeholder=\"Arama Yap...\" aria-label=\"Recipient\'s username\" aria-describedby=\"button-addon2\">\r\n    </div>\r\n");
#nullable restore
#line 11 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\PetrolStation\PetrolStation.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""card mb-3"" style=""max-width: 1540px;"">
            <div class=""row no-gutters"">
                <div class=""col-md-4"">
                    <img src=""https://images.unsplash.com/photo-1488672219853-a0281f9ac59d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1952&q=80""
                         class=""card-img""
                         height=""100%""");
            BeginWriteAttribute("alt", "\r\n                         alt=\"", 822, "\"", 854, 0);
            EndWriteAttribute();
            WriteLiteral(@"/>
                </div>
                <div class=""col-md-8"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Card title</h5>
                        <div class=""col-md-12"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">Bulunan Akaryakıt Türleri</th>
                                        <th scope=""col"">Market</th>
                                        <th scope=""col"">Araç Yıkama</th>
                                        <th scope=""col"">Araç Lastiği</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>");
#nullable restore
#line 36 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\PetrolStation\PetrolStation.cshtml"
                                       Write(item.PetrolFuelType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 37 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\PetrolStation\PetrolStation.cshtml"
                                       Write(item.PetrolMarkets);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 38 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\PetrolStation\PetrolStation.cshtml"
                                       Write(item.PetrolWashing);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 39 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\PetrolStation\PetrolStation.cshtml"
                                       Write(item.PetrolTire);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                        
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <p class=""card-text"">
                            <small class=""text-muted"">Last updated 3 mins ago</small>
                        </p>
                        <button type=""button"" class=""btn btn-primary btn-sm"">
                            Petrol İstasyonu Detayı
                        </button>
                        <br/>
                        <br/>
                        Doluluk Oranı
                        <div class=""progress"">
                            <div class=""progress-bar bg-success""
                                 role=""progressbar""
                                 style=""width: 25%""
                                 aria-valuenow=""25""
                                 aria-valuemin=""0""
                                 aria-valuemax=""100"">
        ");
            WriteLiteral("                        25%\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 68 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\PetrolStation\PetrolStation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TheEye.Entities.Concrete.PetrolStation>> Html { get; private set; }
    }
}
#pragma warning restore 1591