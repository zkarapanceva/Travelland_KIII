#pragma checksum "C:\Users\zoric\source\repos\TravellandAdminApplication\TravellandAdminApplication\Views\Reservation\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3baecb8980f305c744fcc8dd0c75efc48fdb2dcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_Details), @"mvc.1.0.view", @"/Views/Reservation/Details.cshtml")]
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
#line 1 "C:\Users\zoric\source\repos\TravellandAdminApplication\TravellandAdminApplication\Views\_ViewImports.cshtml"
using TravellandAdminApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zoric\source\repos\TravellandAdminApplication\TravellandAdminApplication\Views\_ViewImports.cshtml"
using TravellandAdminApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3baecb8980f305c744fcc8dd0c75efc48fdb2dcf", @"/Views/Reservation/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c56214c36b5403414892613f0fa8347e7575c817", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravellandAdminApplication.Models.Reservation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <p>\r\n        <a class=\"btn btn-success\">");
#nullable restore
#line 11 "C:\Users\zoric\source\repos\TravellandAdminApplication\TravellandAdminApplication\Views\Reservation\Details.cshtml"
                              Write(Model.Client.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </p>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\zoric\source\repos\TravellandAdminApplication\TravellandAdminApplication\Views\Reservation\Details.cshtml"
     for (int i = 0; i < Model.Offers.Count(); i++)
    {
        var item = Model.Offers.ElementAt(i).SelectedOffer;

        if (i % 3 == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 21 "C:\Users\zoric\source\repos\TravellandAdminApplication\TravellandAdminApplication\Views\Reservation\Details.cshtml"
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 m-4\">\r\n                <div class=\"card\" style=\"width: 18rem; height: 30rem;\">\r\n                    <img class=\"card-img-top\" style=\"height: 70%\"");
            BeginWriteAttribute("src", " src=\"", 684, "\"", 706, 1);
#nullable restore
#line 25 "C:\Users\zoric\source\repos\TravellandAdminApplication\TravellandAdminApplication\Views\Reservation\Details.cshtml"
WriteAttributeValue("", 690, item.OfferImage, 690, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                    <div class=\"card-body\">\r\n                        <h3>");
#nullable restore
#line 27 "C:\Users\zoric\source\repos\TravellandAdminApplication\TravellandAdminApplication\Views\Reservation\Details.cshtml"
                       Write(item.OfferDestination);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p>");
#nullable restore
#line 28 "C:\Users\zoric\source\repos\TravellandAdminApplication\TravellandAdminApplication\Views\Reservation\Details.cshtml"
                      Write(item.OfferDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 33 "C:\Users\zoric\source\repos\TravellandAdminApplication\TravellandAdminApplication\Views\Reservation\Details.cshtml"

            if (i % 3 == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 37 "C:\Users\zoric\source\repos\TravellandAdminApplication\TravellandAdminApplication\Views\Reservation\Details.cshtml"
        }

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravellandAdminApplication.Models.Reservation> Html { get; private set; }
    }
}
#pragma warning restore 1591