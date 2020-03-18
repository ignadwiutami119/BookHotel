#pragma checksum "D:\Try Out\BookHotel\Views\Guest\BookingSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "119518dfeb18c20dbf7deeb7b8c290ceedbf56f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Guest_BookingSummary), @"mvc.1.0.view", @"/Views/Guest/BookingSummary.cshtml")]
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
#line 1 "D:\Try Out\BookHotel\Views\_ViewImports.cshtml"
using BookingHotel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Try Out\BookHotel\Views\_ViewImports.cshtml"
using BookingHotel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"119518dfeb18c20dbf7deeb7b8c290ceedbf56f4", @"/Views/Guest/BookingSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ece906f2ca0a0179f3774a5c048a6302d2efbf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Guest_BookingSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookRoom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Guest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Try Out\BookHotel\Views\Guest\BookingSummary.cshtml"
  
    Layout = "_LayoutGuest";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Try Out\BookHotel\Views\Guest\BookingSummary.cshtml"
  
    var name = ViewBag.Name;
    var phone = ViewBag.Phone;
    var number = ViewBag.Number;
    var cls = ViewBag.Class;
    var facilities = ViewBag.Facilities;
    var checkin = ViewBag.Checkin;
    var checkout = ViewBag.Checkout;
    var req = ViewBag.Req;
    var price = ViewBag.Price;
    var range = checkout.Day - checkin.Day;
    var total = range * Convert.ToInt32(price);
    var dtin = checkin.ToString("dd MMMM yyyy");
    var dtout = checkout.ToString("dd MMMM yyyy");

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br>\r\n<h3 class=\"text-center\">Booking Summary</h3><br><br>\r\n<table style=\"background:white; margin-top:5px; padding-left:15px; box-shadow: 1px 1px 10px #5499C7;\" class=\"table table-hover text-left\" id=\"customers\">\r\n  <tr>\r\n    <td>Name</td>\r\n    <td>");
#nullable restore
#line 26 "D:\Try Out\BookHotel\Views\Guest\BookingSummary.cshtml"
   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  </tr>\r\n  <tr>\r\n    <td>Phone</td>\r\n    <td>");
#nullable restore
#line 30 "D:\Try Out\BookHotel\Views\Guest\BookingSummary.cshtml"
   Write(phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  </tr>\r\n  <tr>\r\n    <td>Room Number</td>\r\n    <td>");
#nullable restore
#line 34 "D:\Try Out\BookHotel\Views\Guest\BookingSummary.cshtml"
   Write(number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  </tr>\r\n  <tr>\r\n    <td>Class</td>\r\n    <td>");
#nullable restore
#line 38 "D:\Try Out\BookHotel\Views\Guest\BookingSummary.cshtml"
   Write(cls);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Room</td>\r\n  </tr>\r\n  <tr>\r\n    <td>Facilities</td>\r\n    <td>");
#nullable restore
#line 42 "D:\Try Out\BookHotel\Views\Guest\BookingSummary.cshtml"
   Write(facilities);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  </tr>\r\n  <tr>\r\n    <td>Checkin Date</td>\r\n    <td>");
#nullable restore
#line 46 "D:\Try Out\BookHotel\Views\Guest\BookingSummary.cshtml"
   Write(dtin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  </tr>\r\n  <tr>\r\n    <td>Checkout Date</td>\r\n    <td>");
#nullable restore
#line 50 "D:\Try Out\BookHotel\Views\Guest\BookingSummary.cshtml"
   Write(dtout);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  </tr>\r\n  <tr>\r\n    <td>Special Request Notes</td>\r\n    <td>");
#nullable restore
#line 54 "D:\Try Out\BookHotel\Views\Guest\BookingSummary.cshtml"
   Write(req);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  </tr>\r\n  <tr>\r\n    <td>Price</td>\r\n    <td>Rp. ");
#nullable restore
#line 58 "D:\Try Out\BookHotel\Views\Guest\BookingSummary.cshtml"
       Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / Night</td>\r\n  </tr>\r\n  <tr>\r\n    <td>Total Price</td>\r\n    <td>Rp. ");
#nullable restore
#line 62 "D:\Try Out\BookHotel\Views\Guest\BookingSummary.cshtml"
       Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  </tr>\r\n</table>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "119518dfeb18c20dbf7deeb7b8c290ceedbf56f48210", async() => {
                WriteLiteral("\r\n<input type=\"hidden\" name=\"number\"");
                BeginWriteAttribute("value", " value=\"", 1481, "\"", 1496, 1);
#nullable restore
#line 67 "D:\Try Out\BookHotel\Views\Guest\BookingSummary.cshtml"
WriteAttributeValue("", 1489, number, 1489, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n<input type=\"hidden\" name=\"checkin\"");
                BeginWriteAttribute("value", " value=\"", 1535, "\"", 1551, 1);
#nullable restore
#line 68 "D:\Try Out\BookHotel\Views\Guest\BookingSummary.cshtml"
WriteAttributeValue("", 1543, checkin, 1543, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n<input type=\"hidden\" name=\"checkout\"");
                BeginWriteAttribute("value", " value=\"", 1591, "\"", 1608, 1);
#nullable restore
#line 69 "D:\Try Out\BookHotel\Views\Guest\BookingSummary.cshtml"
WriteAttributeValue("", 1599, checkout, 1599, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n<input type=\"hidden\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 1644, "\"", 1657, 1);
#nullable restore
#line 70 "D:\Try Out\BookHotel\Views\Guest\BookingSummary.cshtml"
WriteAttributeValue("", 1652, name, 1652, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n<input type=\"hidden\" name=\"phone\"");
                BeginWriteAttribute("value", " value=\"", 1694, "\"", 1708, 1);
#nullable restore
#line 71 "D:\Try Out\BookHotel\Views\Guest\BookingSummary.cshtml"
WriteAttributeValue("", 1702, phone, 1702, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n<input type=\"hidden\" name=\"req\"");
                BeginWriteAttribute("value", " value=\"", 1743, "\"", 1755, 1);
#nullable restore
#line 72 "D:\Try Out\BookHotel\Views\Guest\BookingSummary.cshtml"
WriteAttributeValue("", 1751, req, 1751, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n<input type=\"hidden\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 1792, "\"", 1806, 1);
#nullable restore
#line 73 "D:\Try Out\BookHotel\Views\Guest\BookingSummary.cshtml"
WriteAttributeValue("", 1800, total, 1800, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "119518dfeb18c20dbf7deeb7b8c290ceedbf56f411183", async() => {
                    WriteLiteral("Book Now");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br><br><br>");
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