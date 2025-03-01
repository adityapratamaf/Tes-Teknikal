#pragma checksum "C:\Users\saput\OneDrive\Desktop\Angsuran\Angsuran\Views\Angsuran\Hasil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f3a359c77522f61abc2bf7973caf9f9a6474346"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Angsuran_Hasil), @"mvc.1.0.view", @"/Views/Angsuran/Hasil.cshtml")]
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
#line 1 "C:\Users\saput\OneDrive\Desktop\Angsuran\Angsuran\Views\_ViewImports.cshtml"
using Angsuran;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saput\OneDrive\Desktop\Angsuran\Angsuran\Views\_ViewImports.cshtml"
using Angsuran.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f3a359c77522f61abc2bf7973caf9f9a6474346", @"/Views/Angsuran/Hasil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"436f49196442faa700920e444ecb1d9859d9a3c9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Angsuran_Hasil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AngsuranMVC.Models.JadwalAngsuranModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\saput\OneDrive\Desktop\Angsuran\Angsuran\Views\Angsuran\Hasil.cshtml"
  
    ViewData["Title"] = "Skema Angsuran";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"text-center\"> <strong>SKEMA ANGSURAN</strong></h2>\r\n\r\n<hr>\r\n\r\n<h5> <strong>A. Ringkasan</strong> </h5>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\saput\OneDrive\Desktop\Angsuran\Angsuran\Views\Angsuran\Hasil.cshtml"
 if (Model.Any())
{
    var pokokHutang = Model.First().OTR - Model.First().DP;
    var totalBunga = pokokHutang * Model.First().Bunga;
    var totalHutang = pokokHutang + totalBunga;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row mt-3 mb-3\">\r\n        <div class=\"col-md-6\">\r\n            <h6>Nama Klien : ");
#nullable restore
#line 21 "C:\Users\saput\OneDrive\Desktop\Angsuran\Angsuran\Views\Angsuran\Hasil.cshtml"
                        Write(Model.First().Client_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <h6>Nomor Kontrak : ");
#nullable restore
#line 22 "C:\Users\saput\OneDrive\Desktop\Angsuran\Angsuran\Views\Angsuran\Hasil.cshtml"
                           Write(Model.First().KontrakNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <h6>Harga OTR : ");
#nullable restore
#line 23 "C:\Users\saput\OneDrive\Desktop\Angsuran\Angsuran\Views\Angsuran\Hasil.cshtml"
                       Write(Model.First().OTR.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <h6>Jumlah DP : ");
#nullable restore
#line 24 "C:\Users\saput\OneDrive\Desktop\Angsuran\Angsuran\Views\Angsuran\Hasil.cshtml"
                       Write(Model.First().DP.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        </div>\r\n\r\n        <div class=\"col-md-6\">\r\n            <h6>Pokok Hutang : ");
#nullable restore
#line 28 "C:\Users\saput\OneDrive\Desktop\Angsuran\Angsuran\Views\Angsuran\Hasil.cshtml"
                          Write(pokokHutang.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <h6>Bunga : ");
#nullable restore
#line 29 "C:\Users\saput\OneDrive\Desktop\Angsuran\Angsuran\Views\Angsuran\Hasil.cshtml"
                    Write((Model.First().Bunga * 100).ToString("F1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</h6>\r\n            <h6>Total Hutang : ");
#nullable restore
#line 30 "C:\Users\saput\OneDrive\Desktop\Angsuran\Angsuran\Views\Angsuran\Hasil.cshtml"
                          Write(totalHutang.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <h6>Jangka Waktu : ");
#nullable restore
#line 31 "C:\Users\saput\OneDrive\Desktop\Angsuran\Angsuran\Views\Angsuran\Hasil.cshtml"
                           Write(Model.First().JangkaWaktu);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Bulan</h6>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 34 "C:\Users\saput\OneDrive\Desktop\Angsuran\Angsuran\Views\Angsuran\Hasil.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h5> <strong>B. Jadwal</strong> </h5>

<table class=""table table-bordered mt-3"">
    <thead>
        <tr>
            <th>Kontrak No</th>
            <th>Angsuran Ke</th>
            <th>Angsuran / Bulan</th>
            <th>Tanggal Jatuh Tempo</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 48 "C:\Users\saput\OneDrive\Desktop\Angsuran\Angsuran\Views\Angsuran\Hasil.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 51 "C:\Users\saput\OneDrive\Desktop\Angsuran\Angsuran\Views\Angsuran\Hasil.cshtml"
               Write(item.KontrakNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "C:\Users\saput\OneDrive\Desktop\Angsuran\Angsuran\Views\Angsuran\Hasil.cshtml"
               Write(item.AngsuranKe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 53 "C:\Users\saput\OneDrive\Desktop\Angsuran\Angsuran\Views\Angsuran\Hasil.cshtml"
               Write(item.AngsuranPerBulan.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 54 "C:\Users\saput\OneDrive\Desktop\Angsuran\Angsuran\Views\Angsuran\Hasil.cshtml"
               Write(item.TanggalJatuhTempo.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 56 "C:\Users\saput\OneDrive\Desktop\Angsuran\Angsuran\Views\Angsuran\Hasil.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f3a359c77522f61abc2bf7973caf9f9a64743469155", async() => {
                WriteLiteral("Kembali");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AngsuranMVC.Models.JadwalAngsuranModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
