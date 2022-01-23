#pragma checksum "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Room\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed535ffaecdde3a8517c5e1ded2bfe972a5b0a1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_Index), @"mvc.1.0.view", @"/Views/Room/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App.Models.ViewModels.Hotel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed535ffaecdde3a8517c5e1ded2bfe972a5b0a1b", @"/Views/Room/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91c0919da7705681ff1011bc12c1c1670520f654", @"/Views/_ViewImports.cshtml")]
    public class Views_Room_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Room\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- banner -->
<section class=""hotel-banner-simple hotel-transition-bottom hotelmenu"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">

                <div class=""hotel-center hotel-title-frame"">
                    <h1 class=""hotel-mb-20 hotel-h1-inner"">Otaqlar</h1>
                    <p class=""hotel-mb-30"">Laborum accusantium libero commodi. Voluptate consequatur itaque expedita accusamus impedit perspiciatis asperiores necessitatibus assumenda magnam ipsa.</p>
                    <ul class=""hotel-breadcrumbs"">
                        <li><a href=""index.html"">Ana Səhifə</a></li>
                        <li><span>Otaqlar</span></li>
                    </ul>
                </div>

            </div>
        </div>
    </div>
</section>
<!-- banner end -->
<!-- menu -->
<section class=""hotel-p-100-100"">
    <div class=""container"">

        ");
#nullable restore
#line 30 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Room\Index.cshtml"
   Write(await Component.InvokeAsync("Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        <!-- <div class=""hotel-filter hotel-mb-60"">
      <a href=""#"" data-filter=""*"" class=""hotel-work-category hotel-current"">Bütün Kateqoriyalar</a>
      <a href=""#"" data-filter="".main"" class=""hotel-work-category"">Ana Yeməklər</a>
      <a href=""#"" data-filter="".desserts"" class=""hotel-work-category"">Şirniyyatlar</a>
      <a href=""#"" data-filter="".salads"" class=""hotel-work-category"">Salatlar</a>
    </div> -->


        <div class=""hotel-masonry-grid hotel-3-col"">

            <div class=""hotel-grid-sizer""></div>
            <div class=""hotel-masonry-grid-item hotel-masonry-grid-item-33 deluxe"">

                <!-- room card -->
                <div class=""hotel-room-card"">
                    <div class=""hotel-cover-frame imgLoad"">
                        <a href=""roomSuite.html""><img class=""lozad"" data-src=""img/rooms/1.jpg"" alt=""cover""></a>
                    </div>
                    <div class=""hotel-description-frame"">
                        <div class=""hotel-room-features");
            WriteLiteral(@""">
                            <div class=""hotel-feature imgLoad"">
                                <div class=""hotel-icon-frame""><img class=""lozad"" data-src=""img/icons/bed.svg"" alt=""icon""></div>
                                <span>4 Nəfərlik</span>
                            </div>
                            <div class=""hotel-feature imgLoad"">
                                <div class=""hotel-icon-frame""><img class=""lozad"" data-src=""img/icons/square.svg"" alt=""icon""></div>
                                <span>95 Ft²</span>
                            </div>
                        </div>
                        <a href=""roomSuite.html"">
                            <h3 class=""hotel-mb-20"">A Class Otaq</h3>
                        </a>
                        <div class=""hotel-text-light hotel-text-sm hotel-mb-20"">Lorem ipsum dolor sit amet consectetur adipisicing elit. Quidem, iste!</div>
                        <div class=""hotel-card-bottom imgLoad"">
                            <div class=""");
            WriteLiteral(@"hotel-price"">475 M <span>/gecə</span></div>
                            <a href=""roomSuite.html"" class=""hotel-btn""><img class=""lozad"" data-src=""img/icons/bookmark.svg"" alt=""icon"">Rezerv et</a>
                        </div>
                    </div>
                </div>
                <!-- room card end -->

            </div>
            <div class=""hotel-masonry-grid-item hotel-masonry-grid-item-33 deluxe"">

                <!-- room card -->
                <div class=""hotel-room-card"">
                    <div class=""hotel-cover-frame imgLoad"">
                        <a href=""roomSuite.html""><img class=""lozad"" data-src=""img/rooms/2.jpg"" alt=""cover""></a>
                        <div class=""hotel-badge"">Populyar</div>
                    </div>
                    <div class=""hotel-description-frame"">
                        <div class=""hotel-room-features imgLoad"">
                            <div class=""hotel-feature"">
                                <div class=""hotel-icon-frame""><");
            WriteLiteral(@"img class=""lozad"" data-src=""img/icons/bed.svg"" alt=""icon""></div>
                                <span>4 Nəfərlik</span>
                            </div>
                            <div class=""hotel-feature imgLoad"">
                                <div class=""hotel-icon-frame""><img class=""lozad"" data-src=""img/icons/square.svg"" alt=""icon""></div>
                                <span>90 Ft²</span>
                            </div>
                        </div>
                        <a href=""roomSuite.html"">
                            <h3 class=""hotel-mb-20"">B Class Otaq</h3>
                        </a>
                        <div class=""hotel-text-light hotel-text-sm hotel-mb-20"">Lorem ipsum dolor sit amet consectetur adipisicing elit. Consequatur, in.</div>
                        <div class=""hotel-card-bottom imgLoad"">
                            <div class=""hotel-price"">475 M <span>/gecə</span></div>
                            <a href=""roomSuite.html"" class=""hotel-btn""><img class=""l");
            WriteLiteral(@"ozad"" data-src=""img/icons/bookmark.svg"" alt=""icon"">Rezerv et</a>
                        </div>
                    </div>
                </div>
                <!-- room card end -->

            </div>
            <div class=""hotel-masonry-grid-item hotel-masonry-grid-item-33 deluxe"">

                <!-- room card -->
                <div class=""hotel-room-card"">
                    <div class=""hotel-cover-frame imgLoad"">
                        <a href=""roomSuite.html""><img class=""lozad"" data-src=""img/rooms/3.jpg"" alt=""cover""></a>
                    </div>
                    <div class=""hotel-description-frame"">
                        <div class=""hotel-room-features"">
                            <div class=""hotel-feature imgLoad"">
                                <div class=""hotel-icon-frame""><img class=""lozad"" data-src=""img/icons/bed.svg"" alt=""icon""></div>
                                <span>4 Nəfərlik</span>
                            </div>
                            <div cl");
            WriteLiteral(@"ass=""hotel-feature imgLoad"">
                                <div class=""hotel-icon-frame""><img class=""lozad"" data-src=""img/icons/square.svg"" alt=""icon""></div>
                                <span>100 Ft²</span>
                            </div>
                        </div>
                        <a href=""roomSuite.html"">
                            <h3 class=""hotel-mb-20"">C Class Otaq</h3>
                        </a>
                        <div class=""hotel-text-light hotel-text-sm hotel-mb-20"">Libero non aut dignissimos optio hic laudantium ex maiores enim et consequatur corrupti omnis.</div>
                        <div class=""hotel-card-bottom imgLoad"">
                            <div class=""hotel-price"">475 M <span>/gecə</span></div>
                            <a href=""roomSuite.html"" class=""hotel-btn""><img class=""lozad"" data-src=""img/icons/bookmark.svg"" alt=""icon"">Rezerv et</a>
                        </div>
                    </div>
                </div>
                <!-- r");
            WriteLiteral(@"oom card end -->

            </div>
            <div class=""hotel-masonry-grid-item hotel-masonry-grid-item-33 standart"">

                <!-- room card -->
                <div class=""hotel-room-card hotel-scroll-animation"">
                    <div class=""hotel-cover-frame imgLoad"">
                        <a href=""room.html""><img class=""lozad"" data-src=""img/rooms/4.jpg"" alt=""cover""></a>
                    </div>
                    <div class=""hotel-description-frame"">
                        <div class=""hotel-room-features"">
                            <div class=""hotel-feature imgLoad"">
                                <div class=""hotel-icon-frame""><img class=""lozad"" data-src=""img/icons/bed.svg"" alt=""icon""></div>
                                <span>3 Nəfərlik</span>
                            </div>
                            <div class=""hotel-feature imgLoad"">
                                <div class=""hotel-icon-frame""><img class=""lozad"" data-src=""img/icons/square.svg"" alt=""icon");
            WriteLiteral(@"""></div>
                                <span>55 Ft²</span>
                            </div>
                        </div>
                        <a href=""room.html"">
                            <h3 class=""hotel-mb-20"">A Class Otaq</h3>
                        </a>
                        <div class=""hotel-text-light hotel-text-sm hotel-mb-20"">Lorem ipsum, dolor sit amet consectetur adipisicing elit. Vel quasi voluptatibus hic.</div>
                        <div class=""hotel-card-bottom imgLoad"">
                            <div class=""hotel-price"">250 M <span>/gecə</span></div>
                            <a href=""room.html"" class=""hotel-btn""><img class=""lozad"" data-src=""img/icons/bookmark.svg"" alt=""icon"">Rezerv et</a>
                        </div>
                    </div>
                </div>
                <!-- room card end -->

            </div>
            <div class=""hotel-masonry-grid-item hotel-masonry-grid-item-33 standart"">

                <!-- room card -->
       ");
            WriteLiteral(@"         <div class=""hotel-room-card hotel-scroll-animation"">
                    <div class=""hotel-cover-frame imgLoad"">
                        <a href=""room.html""><img class=""lozad"" data-src=""img/rooms/1.jpg"" alt=""cover""></a>
                    </div>
                    <div class=""hotel-description-frame"">
                        <div class=""hotel-room-features"">
                            <div class=""hotel-feature imgLoad"">
                                <div class=""hotel-icon-frame""><img class=""lozad"" data-src=""img/icons/bed.svg"" alt=""icon""></div>
                                <span>3 Nəfərlik</span>
                            </div>
                            <div class=""hotel-feature imgLoad"">
                                <div class=""hotel-icon-frame""><img class=""lozad"" data-src=""img/icons/square.svg"" alt=""icon""></div>
                                <span>50 Ft²</span>
                            </div>
                        </div>
                        <a href=""room.htm");
            WriteLiteral(@"l"">
                            <h3 class=""hotel-mb-20"">D Class Otaq</h3>
                        </a>
                        <div class=""hotel-text-light hotel-text-sm hotel-mb-20"">Libero non aut dignissimos optio hic laudantium ex maiores enim et consequatur corrupti omnis.</div>
                        <div class=""hotel-card-bottom imgLoad"">
                            <div class=""hotel-price"">250 M <span> /gecə</span></div>
                            <a href=""room.html"" class=""hotel-btn""><img class=""lozad"" data-src=""img/icons/bookmark.svg"" alt=""icon"">Rezerv et</a>
                        </div>
                    </div>
                </div>
                <!-- room card end -->

            </div>
            <div class=""hotel-masonry-grid-item hotel-masonry-grid-item-33 standart"">

                <!-- room card -->
                <div class=""hotel-room-card hotel-scroll-animation"">
                    <div class=""hotel-cover-frame imgLoad"">
                        <a href=""room.");
            WriteLiteral(@"html""><img class=""lozad"" data-src=""img/rooms/1.jpg"" alt=""cover""></a>
                    </div>
                    <div class=""hotel-description-frame"">
                        <div class=""hotel-room-features"">
                            <div class=""hotel-feature imgLoad"">
                                <div class=""hotel-icon-frame""><img class=""lozad"" data-src=""img/icons/bed.svg"" alt=""icon""></div>
                                <span>3 Nəfərlik</span>
                            </div>
                            <div class=""hotel-feature imgLoad"">
                                <div class=""hotel-icon-frame""><img class=""lozad"" data-src=""img/icons/square.svg"" alt=""icon""></div>
                                <span>55 Ft²</span>
                            </div>
                        </div>
                        <a href=""room.html"">
                            <h3 class=""hotel-mb-20"">X Class Otaq</h3>
                        </a>
                        <div class=""hotel-text-light hot");
            WriteLiteral(@"el-text-sm hotel-mb-20"">Libero non aut dignissimos optio hic laudantium ex maiores enim et consequatur corrupti omnis.</div>
                        <div class=""hotel-card-bottom imgLoad"">
                            <div class=""hotel-price"">250 M <span>/night</span></div>
                            <a href=""room.html"" class=""hotel-btn""><img class=""lozad"" data-src=""img/icons/bookmark.svg"" alt=""icon"">Rezerv et</a>
                        </div>
                    </div>
                </div>
                <!-- room card end -->

            </div>
            <div class=""hotel-masonry-grid-item hotel-masonry-grid-item-33 economy"">

                <!-- room card -->
                <div class=""hotel-room-card hotel-scroll-animation"">
                    <div class=""hotel-cover-frame imgLoad"">
                        <a href=""roomEco.html""><img class=""lozad"" data-src=""img/rooms/1.jpg"" alt=""cover""></a>
                        <div class=""hotel-badge"">Populyar</div>
                    </div");
            WriteLiteral(@">
                    <div class=""hotel-description-frame"">
                        <div class=""hotel-room-features"">
                            <div class=""hotel-feature imgLoad"">
                                <div class=""hotel-icon-frame""><img class=""lozad"" data-src=""img/icons/bed.svg"" alt=""icon""></div>
                                <span>1 Nəfərlik</span>
                            </div>
                            <div class=""hotel-feature imgLoad"">
                                <div class=""hotel-icon-frame""><img class=""lozad"" data-src=""img/icons/square.svg"" alt=""icon""></div>
                                <span>25 Ft²</span>
                            </div>
                        </div>
                        <a href=""roomEco.html"">
                            <h3 class=""hotel-mb-20"">Ekonomik Otaq</h3>
                        </a>
                        <div class=""hotel-text-light hotel-text-sm hotel-mb-20"">Libero non aut dignissimos optio hic laudantium ex maiores enim et ");
            WriteLiteral(@"consequatur corrupti omnis.</div>
                        <div class=""hotel-card-bottom imgLoad"">
                            <div class=""hotel-price"">75 M <span>/gecə</span></div>
                            <a href=""roomEco.html"" class=""hotel-btn""><img class=""lozad"" data-src=""img/icons/bookmark.svg"" alt=""icon"">Rezerv Et</a>
                        </div>

                    </div>
                </div>
                <!-- room card end -->

            </div>
            <div class=""hotel-masonry-grid-item hotel-masonry-grid-item-33 economy"">

                <!-- room card -->
                <div class=""hotel-room-card hotel-scroll-animation"">
                    <div class=""hotel-cover-frame imgLoad"">
                        <a href=""roomEco.html""><img class=""lozad"" data-src=""img/rooms/2.jpg"" alt=""cover""></a>
                    </div>
                    <div class=""hotel-description-frame"">
                        <div class=""hotel-room-features"">
                            <div");
            WriteLiteral(@" class=""hotel-feature imgLoad"">
                                <div class=""hotel-icon-frame""><img class=""lozad"" data-src=""img/icons/bed.svg"" alt=""icon""></div>
                                <span>1 Nəfərlik</span>
                            </div>
                            <div class=""hotel-feature imgLoad"">
                                <div class=""hotel-icon-frame""><img class=""lozad"" data-src=""img/icons/square.svg"" alt=""icon""></div>
                                <span>35 Ft²</span>
                            </div>
                        </div>
                        <a href=""roomEco.html"">
                            <h3 class=""hotel-mb-20"">Ekonomik Otaq</h3>
                        </a>
                        <div class=""hotel-text-light hotel-text-sm hotel-mb-20"">Libero non aut dignissimos optio hic laudantium ex maiores enim et consequatur corrupti omnis.</div>
                        <div class=""hotel-card-bottom imgLoad"">
                            <div class=""hotel-price"">");
            WriteLiteral(@"65 M <span>/gecə</span></div>
                            <a href=""roomEco.html"" class=""hotel-btn""><img class=""lozad"" data-src=""img/icons/bookmark.svg"" alt=""icon"">Rezerv Et</a>
                        </div>
                    </div>
                </div>
                <!-- room card end -->

            </div>
            <div class=""hotel-masonry-grid-item hotel-masonry-grid-item-33 economy"">

                <!-- room card -->
                <div class=""hotel-room-card hotel-scroll-animation"">
                    <div class=""hotel-cover-frame imgLoad"">
                        <a href=""roomEco.html""><img class=""lozad"" data-src=""img/rooms/3.jpg"" alt=""cover""></a>
                    </div>
                    <div class=""hotel-description-frame"">
                        <div class=""hotel-room-features"">
                            <div class=""hotel-feature imgLoad"">
                                <div class=""hotel-icon-frame""><img class=""lozad"" data-src=""img/icons/bed.svg"" alt=""icon""><");
            WriteLiteral(@"/div>
                                <span>1 Nəfərlik</span>
                            </div>
                            <div class=""hotel-feature imgLoad"">
                                <div class=""hotel-icon-frame""><img class=""lozad"" data-src=""img/icons/square.svg"" alt=""icon""></div>
                                <span>30 Ft²</span>
                            </div>
                        </div>
                        <a href=""roomEco.html"">
                            <h3 class=""hotel-mb-20"">Ekonomik Otaq</h3>
                        </a>
                        <div class=""hotel-text-light hotel-text-sm hotel-mb-20"">Libero non aut dignissimos optio hic laudantium ex maiores enim et consequatur corrupti omnis.</div>
                        <div class=""hotel-card-bottom imgLoad"">
                            <div class=""hotel-price"">70 M <span>/gecə</span></div>
                            <a href=""roomEco.html"" class=""hotel-btn""><img class=""lozad"" data-src=""img/icons/bookmark.svg"" al");
            WriteLiteral("t=\"icon\">Rezerv Et</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <!-- room card end -->\r\n\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n<!-- menu end -->\r\n");
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