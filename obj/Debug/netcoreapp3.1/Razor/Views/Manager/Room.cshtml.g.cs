#pragma checksum "D:\TRAININGC#\BookingHotel\Views\Manager\Room.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae2a1a2b583557861376a04e95432dbf216c982f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_Room), @"mvc.1.0.view", @"/Views/Manager/Room.cshtml")]
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
#line 1 "D:\TRAININGC#\BookingHotel\Views\_ViewImports.cshtml"
using BookingHotel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TRAININGC#\BookingHotel\Views\_ViewImports.cshtml"
using BookingHotel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae2a1a2b583557861376a04e95432dbf216c982f", @"/Views/Manager/Room.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ece906f2ca0a0179f3774a5c048a6302d2efbf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Manager_Room : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\TRAININGC#\BookingHotel\Views\Manager\Room.cshtml"
  
    Layout = "_LayoutManager";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n\r\n  body {\r\n    background-color: #EBF5FB;\r\n    }\r\n</style>\r\n");
#nullable restore
#line 11 "D:\TRAININGC#\BookingHotel\Views\Manager\Room.cshtml"
  var get = ViewBag.Room;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br><br>
        <h2 class=""text-center"" style=""color:#FF5693; font-size:33px"">Room List</h2>
<br><br>
<button class=""btn btn-success"" onclick=""location.href='/Manager/AddRoom'"">New Room</button>
<table style=""background:white; margin-top:5px; padding-left:15px; box-shadow: 1px 1px 10px #5499C7;"" class=""table table-hover text-left"" id=""customers"">
<thead class=""thead-dark"">
  <tr>
    <th>Room Number</th>
    <th>Class</th>
    <th>Status</th>
    <th>Facilities</th>
    <th>Description</th>
    <th></th>
  </tr>
</thead>
");
#nullable restore
#line 27 "D:\TRAININGC#\BookingHotel\Views\Manager\Room.cshtml"
   
 foreach (var a in get){

#line default
#line hidden
#nullable disable
            WriteLiteral("  <tr>\r\n    <td>");
#nullable restore
#line 30 "D:\TRAININGC#\BookingHotel\Views\Manager\Room.cshtml"
   Write(a.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 31 "D:\TRAININGC#\BookingHotel\Views\Manager\Room.cshtml"
   Write(a.Class);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 32 "D:\TRAININGC#\BookingHotel\Views\Manager\Room.cshtml"
   Write(a.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 33 "D:\TRAININGC#\BookingHotel\Views\Manager\Room.cshtml"
   Write(a.Facilities);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 34 "D:\TRAININGC#\BookingHotel\Views\Manager\Room.cshtml"
   Write(a.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><button  class=\"btn btn-success\"");
            BeginWriteAttribute("id", " id=\"", 889, "\"", 903, 2);
            WriteAttributeValue("", 894, "btn-", 894, 4, true);
#nullable restore
#line 35 "D:\TRAININGC#\BookingHotel\Views\Manager\Room.cshtml"
WriteAttributeValue("", 898, a.Id, 898, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"javascript:Edit(this)\">Edit</button> <button");
            BeginWriteAttribute("id", " id=\"", 958, "\"", 972, 2);
            WriteAttributeValue("", 963, "btn-", 963, 4, true);
#nullable restore
#line 35 "D:\TRAININGC#\BookingHotel\Views\Manager\Room.cshtml"
WriteAttributeValue("", 967, a.Id, 967, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"javascript:Remove(this)\" class=\"btn btn-danger\">Remove</button></td>\r\n  </tr> ");
#nullable restore
#line 36 "D:\TRAININGC#\BookingHotel\Views\Manager\Room.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</table>

<script type=""text/javascript"">
function Edit(btn)
{
    var get = btn.id;
    Id = get.substring(4,get.Length);
    location.href='/Manager/EditRoom?Id='+Id;
}

function Remove(btn)
{
    var get = btn.id;
    Id = get.substring(4,get.Length);
    location.href='/Manager/Remove?Id='+Id;
}

</script>
");
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
