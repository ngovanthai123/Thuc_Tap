#pragma checksum "E:\TT\WebLapTop\WebLapTop\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0fbe53d1905ecdf6a2f0b094a46aff946c3ecf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 1 "E:\TT\WebLapTop\WebLapTop\Areas\Admin\Views\_ViewImports.cshtml"
using WebLapTop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\TT\WebLapTop\WebLapTop\Areas\Admin\Views\_ViewImports.cshtml"
using WebLapTop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0fbe53d1905ecdf6a2f0b094a46aff946c3ecf6", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4759a366bcb97d677f53bfbebf25a1cc2a4b5274", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\TT\WebLapTop\WebLapTop\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""main-content container-fluid"">
    <div class=""page-title"">
        <h3>Dashboard</h3>
        <p class=""text-subtitle text-muted"">A good dashboard to display your statistics</p>
    </div>
    <section class=""section"">
        <div class=""row mb-2"">
            <div class=""col-12 col-md-3"">
                <div class=""card card-statistic"">
                    <div class=""card-body p-0"">
                        <div class=""d-flex flex-column"">
                            <div class='px-3 py-3 d-flex justify-content-between'>
                                <h3 class='card-title'>BALANCE</h3>
                                <div class=""card-right d-flex align-items-center"">
                                    <p>$50 </p>
                                </div>
                            </div>
                            <div class=""chart-wrapper"">
                                <canvas id=""canvas1"" style=""height:100px !important""></canvas>
                            </div>
  ");
            WriteLiteral(@"                      </div>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-md-3"">
                <div class=""card card-statistic"">
                    <div class=""card-body p-0"">
                        <div class=""d-flex flex-column"">
                            <div class='px-3 py-3 d-flex justify-content-between'>
                                <h3 class='card-title'>Revenue</h3>
                                <div class=""card-right d-flex align-items-center"">
                                    <p>$532,2 </p>
                                </div>
                            </div>
                            <div class=""chart-wrapper"">
                                <canvas id=""canvas2"" style=""height:100px !important""></canvas>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-md-3"">
                <div");
            WriteLiteral(@" class=""card card-statistic"">
                    <div class=""card-body p-0"">
                        <div class=""d-flex flex-column"">
                            <div class='px-3 py-3 d-flex justify-content-between'>
                                <h3 class='card-title'>ORDERS</h3>
                                <div class=""card-right d-flex align-items-center"">
                                    <p>1,544 </p>
                                </div>
                            </div>
                            <div class=""chart-wrapper"">
                                <canvas id=""canvas3"" style=""height:100px !important""></canvas>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-md-3"">
                <div class=""card card-statistic"">
                    <div class=""card-body p-0"">
                        <div class=""d-flex flex-column"">
                            <");
            WriteLiteral(@"div class='px-3 py-3 d-flex justify-content-between'>
                                <h3 class='card-title'>Sales Today</h3>
                                <div class=""card-right d-flex align-items-center"">
                                    <p>423 </p>
                                </div>
                            </div>
                            <div class=""chart-wrapper"">
                                <canvas id=""canvas4"" style=""height:100px !important""></canvas>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row mb-4"">
            <div class=""col-md-8"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class='card-heading p-1 pl-3'>Sales</h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""c");
            WriteLiteral(@"ol-md-4 col-12"">
                                <div class=""pl-3"">
                                    <h1 class='mt-5'>$21,102</h1>
                                    <p class='text-xs'><span class=""text-green""><i data-feather=""bar-chart"" width=""15""></i> +19%</span> than last month</p>
                                    <div class=""legends"">
                                        <div class=""legend d-flex flex-row align-items-center"">
                                            <div class='w-3 h-3 rounded-full bg-info mr-2'></div><span class='text-xs'>Last Month</span>
                                        </div>
                                        <div class=""legend d-flex flex-row align-items-center"">
                                            <div class='w-3 h-3 rounded-full bg-blue mr-2'></div><span class='text-xs'>Current Month</span>
                                        </div>
                                    </div>
                                </div>
                  ");
            WriteLiteral(@"          </div>
                            <div class=""col-md-8 col-12"">
                                <canvas id=""bar""></canvas>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header d-flex justify-content-between align-items-center"">
                        <h4 class=""card-title"">Orders Today</h4>
                        <div class=""d-flex "">
                            <i data-feather=""download""></i>
                        </div>
                    </div>
                    <div class=""card-body px-0 pb-0"">
                        <div class=""table-responsive"">
                            <table class='table mb-0' id=""table1"">
                                <thead>
                                    <tr>
                                        <th>Name</th>
                                        <th>Email</th>
                           ");
            WriteLiteral(@"             <th>Phone</th>
                                        <th>City</th>
                                        <th>Status</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Graiden</td>
                                        <td>vehicula.aliquet@semconsequat.co.uk</td>
                                        <td>076 4820 8838</td>
                                        <td>Offenburg</td>
                                        <td>
                                            <span class=""badge bg-success"">Active</span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Dale</td>
                                        <td>fringilla.euismod.enim@quam.ca</td>
                                        <td");
            WriteLiteral(@">0500 527693</td>
                                        <td>New Quay</td>
                                        <td>
                                            <span class=""badge bg-success"">Active</span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Nathaniel</td>
                                        <td>mi.Duis@diam.edu</td>
                                        <td>(012165) 76278</td>
                                        <td>Grumo Appula</td>
                                        <td>
                                            <span class=""badge bg-danger"">Inactive</span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Darius</td>
                                        <td>velit@nec.com</td>
                                 ");
            WriteLiteral(@"       <td>0309 690 7871</td>
                                        <td>Ways</td>
                                        <td>
                                            <span class=""badge bg-success"">Active</span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Ganteng</td>
                                        <td>velit@nec.com</td>
                                        <td>0309 690 7871</td>
                                        <td>Ways</td>
                                        <td>
                                            <span class=""badge bg-success"">Active</span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Oleg</td>
                                        <td>rhoncus.id@Aliquamauctorvelit.net</td>
                      ");
            WriteLiteral(@"                  <td>0500 441046</td>
                                        <td>Rossignol</td>
                                        <td>
                                            <span class=""badge bg-success"">Active</span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Kermit</td>
                                        <td>diam.Sed.diam@anteVivamusnon.org</td>
                                        <td>(01653) 27844</td>
                                        <td>Patna</td>
                                        <td>
                                            <span class=""badge bg-success"">Active</span>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
      ");
            WriteLiteral(@"      </div>
            <div class=""col-md-4"">
                <div class=""card "">
                    <div class=""card-header"">
                        <h4>Your Earnings</h4>
                    </div>
                    <div class=""card-body"">
                        <div id=""radialBars""></div>
                        <div class=""text-center mb-5"">
                            <h6>From last month</h6>
                            <h1 class='text-green'>+$2,134</h1>
                        </div>
                    </div>
                </div>
                <div class=""card widget-todo"">
                    <div class=""card-header border-bottom d-flex justify-content-between align-items-center"">
                        <h4 class=""card-title d-flex"">
                            <i class='bx bx-check font-medium-5 pl-25 pr-75'></i>Progress
                        </h4>

                    </div>
                    <div class=""card-body px-0 py-1"">
                        <table clas");
            WriteLiteral(@"s='table table-borderless'>
                            <tr>
                                <td class='col-3'>UI Design</td>
                                <td class='col-6'>
                                    <div class=""progress progress-info"">
                                        <div class=""progress-bar"" role=""progressbar"" style=""width: 60%"" aria-valuenow=""0""
                                             aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </td>
                                <td class='col-3 text-center'>60%</td>
                            </tr>
                            <tr>
                                <td class='col-3'>VueJS</td>
                                <td class='col-6'>
                                    <div class=""progress progress-success"">
                                        <div class=""progress-bar"" role=""progressbar"" style=""width: 35%"" aria-valuenow=""0""
                 ");
            WriteLiteral(@"                            aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </td>
                                <td class='col-3 text-center'>30%</td>
                            </tr>
                            <tr>
                                <td class='col-3'>Laravel</td>
                                <td class='col-6'>
                                    <div class=""progress progress-danger"">
                                        <div class=""progress-bar"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""0""
                                             aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </td>
                                <td class='col-3 text-center'>50%</td>
                            </tr>
                            <tr>
                                <td class='col-3'>ReactJS</td>
                                ");
            WriteLiteral(@"<td class='col-6'>
                                    <div class=""progress progress-primary"">
                                        <div class=""progress-bar"" role=""progressbar"" style=""width: 80%"" aria-valuenow=""0""
                                             aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </td>
                                <td class='col-3 text-center'>80%</td>
                            </tr>
                            <tr>
                                <td class='col-3'>Go</td>
                                <td class='col-6'>
                                    <div class=""progress progress-secondary"">
                                        <div class=""progress-bar"" role=""progressbar"" style=""width: 65%"" aria-valuenow=""0""
                                             aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </td>
  ");
            WriteLiteral("                              <td class=\'col-3 text-center\'>65%</td>\r\n                            </tr>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n");
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