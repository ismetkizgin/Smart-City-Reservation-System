#pragma checksum "C:\Users\ismet\Desktop\Smart-City-Reservation-System\TheEye\TheEye\Views\PetrolStation\PetrolStation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8070e5b7cf8372fa07233e308da2701c1751cc17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PetrolStation_PetrolStation), @"mvc.1.0.view", @"/Views/PetrolStation/PetrolStation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PetrolStation/PetrolStation.cshtml", typeof(AspNetCore.Views_PetrolStation_PetrolStation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8070e5b7cf8372fa07233e308da2701c1751cc17", @"/Views/PetrolStation/PetrolStation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25fd987d7388ad707b6b8d314dfa2b63ad979348", @"/Views/_ViewImports.cshtml")]
    public class Views_PetrolStation_PetrolStation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2485, true);
            WriteLiteral(@"
<div class=""container"">
    <br />
    <div class=""input-group mb-3"">
        <input id=""input-text"" type=""text"" class=""form-control"" placeholder=""Arama Yap..."" aria-label=""Recipient's username"" aria-describedby=""button-addon2"">
    </div>

    <div class=""card mb-3"" style=""max-width: 1540px;"">
        <div class=""row no-gutters"">
            <div class=""col-md-4"">
                <img src=""https://images.unsplash.com/photo-1488672219853-a0281f9ac59d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1952&q=80""
                     class=""card-img""
                     height=""100%""
                     alt=""..."" />
            </div>
            <div class=""col-md-8"">
                <div class=""card-body"">
                    <h5 class=""card-title"">Card title</h5>
                    <div class=""col-md-12"">
                        <table class=""table"">
                            <thead>
                            <th scope=""col"">Market</th>
                            <");
            WriteLiteral(@"th scope=""col"">Araç Yıkama</th>
                            <th scope=""col"">Bulunan Akaryakıt Türleri</th>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Var</td>
                                    <td>Var</td>
                                    <td>LPG Kurşunlu Kurşunsuz</td>
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
                    <br />
                    <br />
                    Doluluk Oranı
                    <div class=""progress"">
                        <div class=""progress-bar bg-");
            WriteLiteral(@"success""
                             role=""progressbar""
                             style=""width: 25%""
                             aria-valuenow=""25""
                             aria-valuemin=""0""
                             aria-valuemax=""100"">
                            25%
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>




");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
