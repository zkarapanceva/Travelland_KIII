#pragma checksum "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\UserReservations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "706439ac5d23b17982d7836be5f28e76b3c9d8e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserReservations_Index), @"mvc.1.0.view", @"/Views/UserReservations/Index.cshtml")]
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
#line 1 "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\_ViewImports.cshtml"
using Travelland.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\_ViewImports.cshtml"
using Travelland.Domain.DomainModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\UserReservations\Index.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"706439ac5d23b17982d7836be5f28e76b3c9d8e2", @"/Views/UserReservations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26bc49f26bf4411d078f59a6d929e0b0254e5be7", @"/Views/_ViewImports.cshtml")]
    public class Views_UserReservations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Travelland.Domain.DTO.UserReservationsDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserReservations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PayOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteOfferFromReservations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\UserReservations\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <div class=\"row m-5\">\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\UserReservations\Index.cshtml"
          if (Model.TotalPrice != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "706439ac5d23b17982d7836be5f28e76b3c9d8e25968", async() => {
                WriteLiteral("\r\n                <article>\r\n                    <script src=\"https://checkout.stripe.com/checkout.js\"\r\n                            \r\n                            class=\"stripe-button\"\r\n                            data-key=\"");
#nullable restore
#line 22 "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\UserReservations\Index.cshtml"
                                 Write(Stripe.Value.PublishableKey);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n                            data-locale=\"auto\"\r\n                            data-description=\"Travelland Application Payment\"\r\n                            data-amount=\"");
#nullable restore
#line 25 "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\UserReservations\Index.cshtml"
                                     Write(Model.TotalPrice * 100);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n                            data-label=\"Pay $");
#nullable restore
#line 26 "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\UserReservations\Index.cshtml"
                                        Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                    </script>\r\n                </article>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\UserReservations\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>

    <div class=""row m-5"">
        <table class=""table table-hover table-info table-striped"">
              <thead>
                <tr>
                  <th scope=""col"">#</th>
                  <th scope=""col"">Offer Destination</th>
                  <th scope=""col"">Quantity</th>
                  <th scope=""col"">Offer Price</th>
                  <th scope=""col""></th>
                </tr>
              </thead>
              <tbody>
");
#nullable restore
#line 45 "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\UserReservations\Index.cshtml"
                   if (Model.OfferInUserReservations.Count == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td colspan=\"5\">No active Offers</td>\r\n                        </tr>\r\n");
#nullable restore
#line 50 "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\UserReservations\Index.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\UserReservations\Index.cshtml"
                         for (int i=0;i<Model.OfferInUserReservations.Count;i++)
                        {
                            var item = Model.OfferInUserReservations[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
#nullable restore
#line 57 "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\UserReservations\Index.cshtml"
                                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 58 "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\UserReservations\Index.cshtml"
                               Write(item.Offer.OfferDestination);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 59 "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\UserReservations\Index.cshtml"
                               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 60 "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\UserReservations\Index.cshtml"
                               Write(item.Offer.OfferPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "706439ac5d23b17982d7836be5f28e76b3c9d8e212388", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\UserReservations\Index.cshtml"
                                                                                                                    WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 63 "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\UserReservations\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\UserReservations\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
                <tr>
                    <th scope=""col"">Total Price: </th>
                    <th scope=""col""></th>
                    <th scope=""col""></th>
                    <th scope=""col""></th>
                    <th scope=""col""></th>
                    <th scope=""col"">");
#nullable restore
#line 72 "C:\Users\zoric\source\repos\TravellandApplication\Travelland.Web\Views\UserReservations\Index.cshtml"
                               Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ???</th>\r\n                </tr>\r\n            <tfoot>\r\n\r\n            </tfoot>\r\n            </table>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<Travelland.Domain.StripeSettings> Stripe { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Travelland.Domain.DTO.UserReservationsDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
