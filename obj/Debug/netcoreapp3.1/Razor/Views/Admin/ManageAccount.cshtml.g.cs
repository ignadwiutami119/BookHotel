#pragma checksum "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d1456af2e28f21869261931abbc75a146b6c95c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManageAccount), @"mvc.1.0.view", @"/Views/Admin/ManageAccount.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d1456af2e28f21869261931abbc75a146b6c95c", @"/Views/Admin/ManageAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ece906f2ca0a0179f3774a5c048a6302d2efbf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ManageAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
  
    Layout = "_LayoutHotel";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
<html>
<style>
   body {
    background-color: #EBF5FB;
    }

    .card {
    padding-top: 20px;
    margin: 10px 0 20px 0;
    background-color: rgba(214, 224, 226, 0.2);
    border-top-width: 0;
    border-bottom-width: 2px;
    -webkit-border-radius: 3px;
    -moz-border-radius: 3px;
    border-radius: 3px;
    -webkit-box-shadow: none;
    -moz-box-shadow: none;
    box-shadow: none;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
}

.card .card-heading {
    padding: 0 20px;
    margin: 0;
}

.card .card-heading.simple {
    font-size: 20px;
    font-weight: 300;
    color: #777;
    border-bottom: 1px solid #e5e5e5;
}

.card .card-heading.image img {
    display: inline-block;
    width: 46px;
    height: 46px;
    margin-right: 15px;
    vertical-align: top;
    border: 0;
    -webkit-border-radius: 50%;
  ");
            WriteLiteral(@"  -moz-border-radius: 50%;
    border-radius: 50%;
}

.card .card-heading.image .card-heading-header {
    display: inline-block;
    vertical-align: top;
}

.card .card-heading.image .card-heading-header h3 {
    margin: 0;
    font-size: 14px;
    line-height: 16px;
    color: #262626;
}

.card .card-heading.image .card-heading-header span {
    font-size: 12px;
    color: #999999;
}

.card .card-body {
    padding: 0 20px;
    margin-top: 20px;
}

.card .card-media {
    padding: 0 20px;
    margin: 0 -14px;
}

.card .card-media img {
    max-width: 100%;
    max-height: 100%;
}

.card .card-actions {
    min-height: 30px;
    padding: 0 20px 20px 20px;
    margin: 20px 0 0 0;
}

.card .card-comments {
    padding: 20px;
    margin: 0;
    background-color: #f8f8f8;
}

.card .card-comments .comments-collapse-toggle {
    padding: 0;
    margin: 0 20px 12px 20px;
}

.card .card-comments .comments-collapse-toggle a,
.card .card-comments .comments-collapse");
            WriteLiteral(@"-toggle span {
    padding-right: 5px;
    overflow: hidden;
    font-size: 12px;
    color: #999;
    text-overflow: ellipsis;
    white-space: nowrap;
}

.card-comments .media-heading {
    font-size: 13px;
    font-weight: bold;
}

.card.people {
    position: relative;
    display: inline-block;
    width: 500px;
    height: 300px;
    padding-top: 0;
    margin-left: 20px;
    overflow: hidden;
    vertical-align: top;
}

.card.people:first-child {
    margin-left: 0;
}

.card.people .card-top {
    position: absolute;
    top: 0;
    left: 0;
    display: inline-block;
    width: 170px;
    height: 150px;
    background-color: #ffffff;
}

.card.people .card-top.green {
    background-color: #53a93f;
}

.card.people .card-top.blue {
    background-color: #427fed;
}

.card.people .card-info {
    position: absolute;
    top: 150px;
    display: inline-block;
    width: 100%;
    height: 101px;
    overflow: hidden;
    background: #ffffff;
    -webkit");
            WriteLiteral(@"-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
}

.card.people .card-info .title {
    display: block;
    margin: 8px 14px 0 14px;
    overflow: hidden;
    font-size: 16px;
    font-weight: bold;
    line-height: 18px;
    color: #404040;
}

.card.people .card-info .desc {
    display: block;
    margin: 8px 14px 0 14px;
    overflow: hidden;
    font-size: 12px;
    line-height: 16px;
    color: #737373;
    text-overflow: ellipsis;
}

.card.people .card-bottom {
    position: absolute;
    bottom: 0;
    left: 0;
    display: inline-block;
    width: 100%;
    padding: 10px 20px;
    line-height: 29px;
    text-align: center;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
}

.card.hovercard {
    box-shadow: 1px 1px 10px #5499C7;
    position: relative;
    padding-right: 15px;
    padding-left: 15px;
    overflow: hidden;
    text-align: center;
    background-color: whit");
            WriteLiteral(@"e;
}

.btn:focus{
background: #ffffff;
}
  
.card.hovercard .cardheader {
    background-color: rgba(214, 224, 226, 0.2);
    height: 500px;
}
.card.hovercard .cardjudul {
    background: #0c0f11;
    background-size: cover;
    height: 350px;
}

.card.hovercard .body {
    background-size: cover;
    height: 290px;
}

.card.hovercard .avatar {
    position: relative;
    top: -50px;
    margin-bottom: -50px;
}

.card.hovercard .avatar img {
    width: 100px;
    height: 100px;
    max-width: 100px;
    max-height: 100px;
    -webkit-border-radius: 50%;
    -moz-border-radius: 50%;
    border-radius: 50%;
    border: 5px solid rgba(20,105,148,0.5);
}

.card.hovercard .info {
    padding: 4px 8px 10px;
}

.card.hovercard .info .title {
    margin-bottom: 4px;
    font-size: 24px;
    line-height: 1;
    color: #262626;
    vertical-align: middle;
}

.card.hovercard .info .desc {
    overflow: hidden;
    font-size: 12px;
    line-height: 20px;
    color: #");
            WriteLiteral(@"737373;
    text-overflow: ellipsis;
}

.card.hovercard .bottom {
    padding: 0 20px;
    margin-bottom: 17px;
}

.navbar:active{
    color:#5DADE2;
}

.btnx {
  border: 2px solid #FF5693;
  color: #FF5693;
  background-color: transparent;
  padding: 6px 50px;
  border-radius: 6px;
  font-size: 12px;
  font-weight: bold;
  cursor: pointer;
}
.custom-file-upload {
    border: 1px solid #ccc;
    display: inline-block;
    padding: 6px 12px;
    cursor: pointer;
}
input[type=""file""] {
    display: none;
}
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d1456af2e28f21869261931abbc75a146b6c95c9328", async() => {
                WriteLiteral(@"
<br><br>
        <h2 class=""text-center"" style=""color:#FF5693; font-size:33px"">Account</h2>
<br><br>
<div class=""container"">


       <div class=""col-lg-12 col-sm-5"">
             <div class=""card hovercard"">
                   <div class=""row"">
");
#nullable restore
#line 303 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
                           var pg = ViewBag.page;
                        if(pg.StatusPage == "Manager"){

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <ul> 
                        <li style=""width:555px""><a style=""background:#FF5693; color:#F0F9FF"" href=""/Admin/ManageAccount?status=Manager"">Manager</a></li>
                        <li style=""width:555px""><a style=""color:#F0F9FF"" href=""/Admin/ManageAccount?status=Officer"">Officer</a></li>
                    </ul>");
#nullable restore
#line 308 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
                         }
                    else{

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <ul> 
                        <li style=""width:555px""><a style=""color:#F0F9FF"" href=""/Admin/ManageAccount?status=Manager"">Manager</a></li>
                        <li style=""width:555px""><a style=""background:#FF5693; color:#F0F9FF"" href=""/Admin/ManageAccount?status=Officer"">Officer</a></li>
                    </ul>
");
#nullable restore
#line 314 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
                    }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                   </div>\r\n                   <br>\r\n\r\n\r\n                   <div class=\"col-lg-12 col-sm-4\">\r\n                       <div class=\"row\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d1456af2e28f21869261931abbc75a146b6c95c11486", async() => {
                    WriteLiteral(@"
                   <div class=""col-lg-11 col-sm-5"">
                    <input type=""text"" id=""keyword"" name=""search"" class=""form-control"" placeholder=""Type to search""></div>
                   <div>
                    <button onclick=""javascript:Search(this)"" class=""btn btn-primary"" type=""button""><span class=""fa fa-search""> Search</span>
                    </button></div>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div><br>    \r\n                <div class=\"body\">\r\n");
#nullable restore
#line 330 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
                    
                    var page = ViewBag.page;
                    if(page.StatusPage == "Manager") {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <table style=\"background:white;\" class=\"table table-hover text-left\"> \r\n            <tbody>\r\n");
#nullable restore
#line 335 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
     var items = ViewBag.Manager;

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br>\r\n    <thead class=\"thead-dark\">\r\n    <tr>\r\n      <th scope=\"col\">Name</th>\r\n      <th scope=\"col\">Email</th>\r\n      <th scope=\"col\">NIP</th>\r\n      <th scope=\"col\">Occupation</th>\r\n      <th scope=\"col\"></th>\r\n    </tr>\r\n  </thead>    \r\n");
#nullable restore
#line 346 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
    foreach(var a in items) { 

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("id", "  id=\"", 8075, "\"", 8089, 2);
                WriteAttributeValue("", 8081, "Id-", 8081, 3, true);
#nullable restore
#line 348 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
WriteAttributeValue("", 8084, a.Id, 8084, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 8090, "\"", 8103, 1);
#nullable restore
#line 348 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
WriteAttributeValue("", 8098, a.Id, 8098, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                WriteLiteral("                <td><b>");
#nullable restore
#line 350 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
                  Write(a.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 351 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
                                 Write(a.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 352 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
                                 Write(a.Phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 353 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
                                 Write(a.NIP);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"text-center\"><button class=\"btn btn-success\">Set as Officer</button></td>\r\n            </tr> \r\n");
#nullable restore
#line 356 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
            } 
    

#line default
#line hidden
#nullable disable
                WriteLiteral(" </tbody> \r\n    </table> ");
#nullable restore
#line 359 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
             }
            
    else {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <table style=\"background:white;\" class=\"table table-hover text-left\"> \r\n            <tbody>\r\n");
#nullable restore
#line 364 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
     var items = ViewBag.Officer;

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br>\r\n    <thead class=\"thead-dark\">\r\n    <tr>\r\n      <th scope=\"col\">Name</th>\r\n      <th scope=\"col\">Email</th>\r\n      <th scope=\"col\">NIP</th>\r\n      <th scope=\"col\">Occupation</th>\r\n      <th scope=\"col\"></th>\r\n    </tr>\r\n  </thead>    \r\n");
#nullable restore
#line 375 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
    foreach(var a in items) { 

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("id", "  id=\"", 9035, "\"", 9049, 2);
                WriteAttributeValue("", 9041, "Id-", 9041, 3, true);
#nullable restore
#line 377 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
WriteAttributeValue("", 9044, a.Id, 9044, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 9050, "\"", 9063, 1);
#nullable restore
#line 377 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
WriteAttributeValue("", 9058, a.Id, 9058, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                WriteLiteral("                <td><b>");
#nullable restore
#line 379 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
                  Write(a.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 380 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
                                 Write(a.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 381 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
                                 Write(a.Phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 382 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
                                 Write(a.NIP);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"text-center\"><button class=\"btn btn-success\">Set as Manager</button></td>\r\n            </tr> \r\n");
#nullable restore
#line 385 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
            } 
    

#line default
#line hidden
#nullable disable
                WriteLiteral(" </tbody> \r\n    </table> ");
#nullable restore
#line 388 "D:\TRAININGC#\BookingHotel\Views\Admin\ManageAccount.cshtml"
             }
                

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </div>\r\n            <br>\r\n        </div>\r\n    </div>\r\n</div>\r\n\t</div>\r\n</div>\r\n  </div>\r\n</div>\r\n\r\n");
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<script type=""text/javascript"">
function AttendanceDetail(btn)
{
    var id = btn.id;
    id = id.substring(4,id.Length);
    var identify = ""Id-""+id;
    var Id = document.getElementById(identify).value;
    location.href='/Attendance/AttendanceList?Id='+Id;
}

function Search()
{
    var keyword = document.getElementById(""keyword"").value;
    console.log(keyword);
    location.href='/Attendance/Search?keyword='+keyword;
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
