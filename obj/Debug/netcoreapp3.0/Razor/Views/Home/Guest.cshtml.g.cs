#pragma checksum "D:\Try Out\BookHotel\Views\Home\Guest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d52151f4eaa35fcd98f9c2d8188ae603f60005a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Guest), @"mvc.1.0.view", @"/Views/Home/Guest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d52151f4eaa35fcd98f9c2d8188ae603f60005a4", @"/Views/Home/Guest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ece906f2ca0a0179f3774a5c048a6302d2efbf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Guest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Available", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Guest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\Try Out\BookHotel\Views\Home\Guest.cshtml"
  
    Layout = "_LayoutGuest";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n\r\n  body {\r\n    background-color: #EBF5FB;\r\n    }\r\n</style>\r\n<br><br>\r\n");
#nullable restore
#line 12 "D:\Try Out\BookHotel\Views\Home\Guest.cshtml"
  
  var guest = ViewBag.Guest;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h3 class=\"text-center\" style=\"color:#FF5693; font-size:33px\">Here rooms ready for you</h3>\r\n<br><br>\r\n");
#nullable restore
#line 18 "D:\Try Out\BookHotel\Views\Home\Guest.cshtml"
  var get = ViewBag;
  var getbooked = ViewBag.RoomBooked;
  var status = ViewBag.Status;
  if(status == "filter"){
    Console.WriteLine("masuk sini ga");
    var dt = ViewBag.Date;
    var dtout = ViewBag.Dateout;
    var dateout = dtout.ToString("dd MMMM yyyy");
    var date = dt.ToString("dd MMMM yyyy");
    get = ViewBag.RoomFilter;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Room Available on</h3>\r\n    <h5>");
#nullable restore
#line 29 "D:\Try Out\BookHotel\Views\Home\Guest.cshtml"
   Write(date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 29 "D:\Try Out\BookHotel\Views\Home\Guest.cshtml"
           Write(dateout);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 30 "D:\Try Out\BookHotel\Views\Home\Guest.cshtml"
  }
  else if(status != "filter"){
    get = ViewBag.Room;
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br><br>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d52151f4eaa35fcd98f9c2d8188ae603f60005a46233", async() => {
                WriteLiteral(@"
   <div class=""form-group"">
      <div class=""text-left"">
        <label for=""datein"">Date In</label>
        <input id=""datein"" type=""date"" name=""datein"">
        <label for=""dateout"">Date Out</label>
        <input id=""dateout"" type=""date"" name=""dateout"">
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d52151f4eaa35fcd98f9c2d8188ae603f60005a46782", async() => {
                    WriteLiteral("Check Availability");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("          \r\n      </div>\r\n    </div>");
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
            WriteLiteral(@"
<table style=""background:white; margin-top:5px; padding-left:15px; box-shadow: 1px 1px 10px #5499C7;"" class=""table table-hover text-left"" id=""customers"">
<thead class=""thead-dark"">
  <tr>
    <th>Room Number</th>
    <th>Class</th>
    <th>Facilities</th>
    <th>Description</th>
    <th></th>
  </tr>
</thead>
");
#nullable restore
#line 56 "D:\Try Out\BookHotel\Views\Home\Guest.cshtml"
   
   if(getbooked.Count == 0){
      foreach (var a in get){

#line default
#line hidden
#nullable disable
            WriteLiteral("  <tr>\r\n    <td>");
#nullable restore
#line 60 "D:\Try Out\BookHotel\Views\Home\Guest.cshtml"
   Write(a.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 61 "D:\Try Out\BookHotel\Views\Home\Guest.cshtml"
   Write(a.Class);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 62 "D:\Try Out\BookHotel\Views\Home\Guest.cshtml"
   Write(a.Facilities);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 63 "D:\Try Out\BookHotel\Views\Home\Guest.cshtml"
   Write(a.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><button  class=\"btn btn-success\"");
            BeginWriteAttribute("id", " id=\"", 1742, "\"", 1756, 2);
            WriteAttributeValue("", 1747, "btn-", 1747, 4, true);
#nullable restore
#line 64 "D:\Try Out\BookHotel\Views\Home\Guest.cshtml"
WriteAttributeValue("", 1751, a.Id, 1751, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"javascript:Book(this)\">Book</button></td>\r\n  </tr> \r\n");
#nullable restore
#line 66 "D:\Try Out\BookHotel\Views\Home\Guest.cshtml"
  }}

  else {
 foreach (var a in get){
   foreach(var b in getbooked){
  if(a.Number != b){

#line default
#line hidden
#nullable disable
            WriteLiteral("  <tr>\r\n    <td>");
#nullable restore
#line 73 "D:\Try Out\BookHotel\Views\Home\Guest.cshtml"
   Write(a.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 74 "D:\Try Out\BookHotel\Views\Home\Guest.cshtml"
   Write(a.Class);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 75 "D:\Try Out\BookHotel\Views\Home\Guest.cshtml"
   Write(a.Facilities);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 76 "D:\Try Out\BookHotel\Views\Home\Guest.cshtml"
   Write(a.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><button  class=\"btn btn-success\"");
            BeginWriteAttribute("id", " id=\"", 2071, "\"", 2085, 2);
            WriteAttributeValue("", 2076, "btn-", 2076, 4, true);
#nullable restore
#line 77 "D:\Try Out\BookHotel\Views\Home\Guest.cshtml"
WriteAttributeValue("", 2080, a.Id, 2080, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"javascript:Book(this)\">Book</button></td>\r\n  </tr> ");
#nullable restore
#line 78 "D:\Try Out\BookHotel\Views\Home\Guest.cshtml"
        }}} }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<script type=\"text/javascript\">\r\nfunction Book(btn)\r\n{\r\n    var get = btn.id;\r\n    Id = get.substring(4,get.Length);\r\n    location.href=\'/Guest/BookingForm?Id=\'+Id;\r\n}\r\n\r\n</script>\r\n");
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
