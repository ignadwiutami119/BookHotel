#pragma checksum "G:\BookHotel\Views\Officer\AvailableRoom.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae6f3bb03630d436d5b7f06491d78503b518c75e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Officer_AvailableRoom), @"mvc.1.0.view", @"/Views/Officer/AvailableRoom.cshtml")]
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
#line 1 "G:\BookHotel\Views\_ViewImports.cshtml"
using BookingHotel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\BookHotel\Views\_ViewImports.cshtml"
using BookingHotel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae6f3bb03630d436d5b7f06491d78503b518c75e", @"/Views/Officer/AvailableRoom.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ece906f2ca0a0179f3774a5c048a6302d2efbf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Officer_AvailableRoom : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\BookHotel\Views\Officer\AvailableRoom.cshtml"
  
    Layout = "_LayoutOfficer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n\r\n  body {\r\n    background-color: #EBF5FB;\r\n    }\r\n</style>\r\n");
#nullable restore
#line 11 "G:\BookHotel\Views\Officer\AvailableRoom.cshtml"
  var get = ViewBag.Transaction;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br><br>
        <h2 class=""text-center"" style=""color:#FF5693; font-size:33px"">Available Room</h2>
<br><br>
<table style=""background:white; margin-top:5px; padding-left:15px; box-shadow: 1px 1px 10px #5499C7;"" class=""table table-hover text-left"" id=""customers"">
<thead class=""thead-dark"">
");
#nullable restore
#line 17 "G:\BookHotel\Views\Officer\AvailableRoom.cshtml"
      var date = DateTime.Now;
    var dt = date.ToString("dd MMMM yyyy");
    var one = date.AddDays(1).ToString("dd MMMM yyyy");
    var two = date.AddDays(2).ToString("dd MMMM yyyy");
    var three = date.AddDays(3).ToString("dd MMMM yyyy");
    var four = date.AddDays(4).ToString("dd MMMM yyyy");
    var five = date.AddDays(5).ToString("dd MMMM yyyy");
    var six = date.AddDays(6).ToString("dd MMMM yyyy");   
    

#line default
#line hidden
#nullable disable
            WriteLiteral("  <tr>\r\n    <th></th>\r\n    <th>");
#nullable restore
#line 28 "G:\BookHotel\Views\Officer\AvailableRoom.cshtml"
   Write(dt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <th>");
#nullable restore
#line 29 "G:\BookHotel\Views\Officer\AvailableRoom.cshtml"
   Write(one);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <th>");
#nullable restore
#line 30 "G:\BookHotel\Views\Officer\AvailableRoom.cshtml"
   Write(two);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <th>");
#nullable restore
#line 31 "G:\BookHotel\Views\Officer\AvailableRoom.cshtml"
   Write(three);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <th>");
#nullable restore
#line 32 "G:\BookHotel\Views\Officer\AvailableRoom.cshtml"
   Write(four);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <th>");
#nullable restore
#line 33 "G:\BookHotel\Views\Officer\AvailableRoom.cshtml"
   Write(five);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <th>");
#nullable restore
#line 34 "G:\BookHotel\Views\Officer\AvailableRoom.cshtml"
   Write(six);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n  </tr>\r\n</thead>\r\n");
#nullable restore
#line 37 "G:\BookHotel\Views\Officer\AvailableRoom.cshtml"
   
     var room = ViewBag.Room;
     var booked = ViewBag.Booked;
 foreach (var a in room){

#line default
#line hidden
#nullable disable
            WriteLiteral("  <tr>\r\n    <td></td>\r\n    <td></td>\r\n    <td></td>\r\n    <td></td>\r\n    <td></td>\r\n    <td></td>\r\n    <td></td>\r\n    <td></td>\r\n  </tr> ");
#nullable restore
#line 50 "G:\BookHotel\Views\Officer\AvailableRoom.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<script type=\"text/javascript\">\r\nfunction Detail(btn)\r\n{\r\n    var get = btn.id;\r\n    Id = get.substring(4,get.Length);\r\n    location.href=\'/Officer/Detail?Id=\'+Id;\r\n}\r\n\r\n</script>\r\n");
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