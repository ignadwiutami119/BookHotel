#pragma checksum "D:\Try Out\BookHotel\Views\Guest\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70aca3abaf00b7724574ca73961437f3a0711117"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Guest_Home), @"mvc.1.0.view", @"/Views/Guest/Home.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70aca3abaf00b7724574ca73961437f3a0711117", @"/Views/Guest/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ece906f2ca0a0179f3774a5c048a6302d2efbf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Guest_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\Try Out\BookHotel\Views\Guest\Home.cshtml"
  
    Layout = "_LayoutGuest";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n\r\n  body {\r\n    background-color: #EBF5FB;\r\n    }\r\n</style>\r\n<br><br>\r\n");
#nullable restore
#line 12 "D:\Try Out\BookHotel\Views\Guest\Home.cshtml"
  
  var guest = ViewBag.Guest;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-left\">\r\n<h4>Your Saldo Balance <br> Rp. ");
#nullable restore
#line 18 "D:\Try Out\BookHotel\Views\Guest\Home.cshtml"
                           Write(guest.Deposit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<a onclick=\"location.href=\'/Guest/Topup\'\">Top up saldo</a>\r\n</div>\r\n\r\n    <h3 class=\"text-center\" style=\"color:#FF5693; font-size:33px\">Here rooms ready for you</h3>\r\n<br><br>\r\n");
#nullable restore
#line 24 "D:\Try Out\BookHotel\Views\Guest\Home.cshtml"
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
#line 35 "D:\Try Out\BookHotel\Views\Guest\Home.cshtml"
   Write(date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 35 "D:\Try Out\BookHotel\Views\Guest\Home.cshtml"
           Write(dateout);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 36 "D:\Try Out\BookHotel\Views\Guest\Home.cshtml"
  }
  else if(status != "filter"){
    get = ViewBag.Room;
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br><br>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70aca3abaf00b7724574ca73961437f3a07111176592", async() => {
                WriteLiteral(@"
   <div class=""form-group"">
      <div class=""text-left"">
        <label for=""datein"">Date In</label>
        <input id=""datein"" type=""date"" name=""datein"">
        <label for=""dateout"">Date Out</label>
        <input id=""dateout"" type=""date"" name=""dateout"">
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70aca3abaf00b7724574ca73961437f3a07111177141", async() => {
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
#line 62 "D:\Try Out\BookHotel\Views\Guest\Home.cshtml"
   
   if(getbooked.Count == 0){
      foreach (var a in get){

#line default
#line hidden
#nullable disable
            WriteLiteral("  <tr>\r\n    <td>");
#nullable restore
#line 66 "D:\Try Out\BookHotel\Views\Guest\Home.cshtml"
   Write(a.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 67 "D:\Try Out\BookHotel\Views\Guest\Home.cshtml"
   Write(a.Class);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 68 "D:\Try Out\BookHotel\Views\Guest\Home.cshtml"
   Write(a.Facilities);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 69 "D:\Try Out\BookHotel\Views\Guest\Home.cshtml"
   Write(a.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><button  class=\"btn btn-success\"");
            BeginWriteAttribute("id", " id=\"", 1892, "\"", 1906, 2);
            WriteAttributeValue("", 1897, "btn-", 1897, 4, true);
#nullable restore
#line 70 "D:\Try Out\BookHotel\Views\Guest\Home.cshtml"
WriteAttributeValue("", 1901, a.Id, 1901, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"javascript:Book(this)\">Book</button></td>\r\n  </tr> \r\n");
#nullable restore
#line 72 "D:\Try Out\BookHotel\Views\Guest\Home.cshtml"
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
#line 79 "D:\Try Out\BookHotel\Views\Guest\Home.cshtml"
   Write(a.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 80 "D:\Try Out\BookHotel\Views\Guest\Home.cshtml"
   Write(a.Class);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 81 "D:\Try Out\BookHotel\Views\Guest\Home.cshtml"
   Write(a.Facilities);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 82 "D:\Try Out\BookHotel\Views\Guest\Home.cshtml"
   Write(a.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><button  class=\"btn btn-success\"");
            BeginWriteAttribute("id", " id=\"", 2221, "\"", 2235, 2);
            WriteAttributeValue("", 2226, "btn-", 2226, 4, true);
#nullable restore
#line 83 "D:\Try Out\BookHotel\Views\Guest\Home.cshtml"
WriteAttributeValue("", 2230, a.Id, 2230, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"javascript:Book(this)\">Book</button></td>\r\n  </tr> ");
#nullable restore
#line 84 "D:\Try Out\BookHotel\Views\Guest\Home.cshtml"
        }}} }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table> <br><br><br>\r\n\r\n<script type=\"text/javascript\">\r\nfunction Book(btn)\r\n{\r\n    var get = btn.id;\r\n    Id = get.substring(4,get.Length);\r\n    location.href=\'/Guest/BookingForm?Id=\'+Id;\r\n}\r\n\r\n</script>\r\n");
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
