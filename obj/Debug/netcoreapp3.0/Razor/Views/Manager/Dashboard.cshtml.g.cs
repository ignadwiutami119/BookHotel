#pragma checksum "G:\BookHotel\Views\Manager\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aca47eb5df59379cbca5c9779f2373427715177b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_Dashboard), @"mvc.1.0.view", @"/Views/Manager/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aca47eb5df59379cbca5c9779f2373427715177b", @"/Views/Manager/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ece906f2ca0a0179f3774a5c048a6302d2efbf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Manager_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\BookHotel\Views\Manager\Dashboard.cshtml"
  
    Layout = "_LayoutManager";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aca47eb5df59379cbca5c9779f2373427715177b3314", async() => {
                WriteLiteral(@"
<style>
    body {
  background-color: #EBF5FB;
         }

    .card {
    padding-top: 20px;
    margin: 10px 0 20px 0;
    background-color: #ffffff;
    border-top-width: 0;
    border-bottom-width: 2px;
    -webkit-border-radius: 3px;
    -moz-border-radius: 3px;
    border-radius: 3px;
    -webkit-box-shadow: solid;
    -moz-box-shadow: solid;
    box-shadow: solid;
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
    -moz-border-radius: 50%;
    border-radius: 50%;
}

.card .card-heading.image .card-heading-header {
    display: i");
                WriteLiteral(@"nline-block;
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
.card .card-comments .comments-collapse-toggle span {
    padding-right: 5px;
    overflow: hidden;
    font-size: 12px;
    color: #999;
    text-overflow:");
                WriteLiteral(@" ellipsis;
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
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
}

.card.people .card-info .tit");
                WriteLiteral(@"le {
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
    position: relative;
    padding-top: 0;
    overflow: hidden;
    text-align: center;
    background-color: white;
}

  
.card.hovercard .cardheader {
    background: #1F618D;
    background-size: cover;
    height: 70px;
}
.card.hovercard .cardjudul {
    background: #17202A;
    background");
                WriteLiteral(@"-size: cover;
    height: 350px;
}

.card.hovercard .body {
    background-color: rgba(214, 224, 226, 0.2);
    background-size: cover;
    height: 250px;
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
    color: white;
    vertical-align: middle;
}

.card.hovercard .info .desc {
    overflow: hidden;
    font-size: 12px;
    line-height: 20px;
    color: #737373;
    text-overflow: ellipsis;
}

.card.hovercard .bottom {
    padding: 0 20px;
    margin-bottom: 17px;
}

.btn{ border-radius: 50%; width:32px; height:32px; li");
                WriteLiteral("ne-height:18px;  }\r\n</style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aca47eb5df59379cbca5c9779f2373427715177b9614", async() => {
                WriteLiteral(@"

 <br><br><br>
 
<div class=""container"">
	<div class=""row"">
		<div class=""col-lg-12 col-sm-5"">

            <div class=""card hovercard"">
                <div class=""cardjudul "">
                    <img style=""width:80%"" src=""https://res.cloudinary.com/simplotel/image/upload/x_0,y_180,w_4288,h_2411,r_0,c_crop,q_60,fl_progressive/w_1500,c_fit,f_auto/trimrooms-jaipur---mount-blue/DSC_7909_copy_r1qr7q"">
                </div>
            </div>
            </div> </div></div>
            <br><br>

<div class=""container"">
	<div class=""row"">
		<div class=""col-lg-4 col-sm-5"">
");
                WriteLiteral(@"            <div class=""card hovercard"" style=""box-shadow: 1px 1px 10px #5499C7;"">
                <div class=""cardheader "">
                    <br>
                    <h4 style=""color:#F5FBFF; font-family:Helvetica, sans-serif"">Total Employee</h4>
                </div>
                <div class=""info"">
                    <div class=""title"">
                        <h1 style=""color:#FF5693""><b></b></h1>
                    </div>
                </div>
                <div class=""bottom"">
                    <p style=""color:#21618C"">test</p>
                </div>
            </div>
            </div>

        <div class=""col-lg-4 col-sm-5"">
             <div class=""card hovercard "" style=""box-shadow: 1px 1px 10px #5499C7 ;"">
                <div class=""cardheader "">
                      <br>
                    <h4 style=""color:#F5FBFF; font-family:Helvetica, sans-serif"">Out Today</h4>
                </div>
                <div class=""info"">
                    <div class=""title");
                WriteLiteral(@""">
                        <h1 style=""color:#FF5693""><b>leave</b></h1>
                    </div>
                </div>
                <div class=""bottom"">
                    <p style=""color:#21618C"">leave person out today</p>
                </div>
                </div>
            </div>

        <div class=""col-lg-4 col-sm-5"">
             <div class=""card hovercard"" style=""box-shadow: 1px 1px 10px #5499C7 ;"">
                <div class=""cardheader "">
                    <br>
                    <h4 style=""color:#F5FBFF; font-family:Helvetica, sans-serif"">Today's Presence</h4>
                </div>
                <div class=""info"">
                    <div class=""title"">
                        <h1 style=""color:#FF5693""><b>presence</b></h1>
                    </div>
                </div>
                <div class=""bottom"">
                    <p style=""color:#21618C"">presence person presence</p>
                </div>
                </div>
            </div>
        </di");
                WriteLiteral(@"v>
<br>
    <div class=""row"">
        <div class=""col-lg-6 col-sm-5"">
             <div class=""card hovercard"" style=""box-shadow: 1px 1px 15px #5499C7 ;"">
                <div class=""cardheader "">
                    <br>
                    <h4 style=""color:#F5FBFF; font-family:Helvetica, sans-serif"">Upcoming Event</h4>
                </div>
                <div class=""body"">
                <div style=""margin-left:47px; margin-right:50px""><br>
                    <table style=""background:white"" class=""table table-hover text-center"">
            <tbody class=""text-center"">
  
    <br>
    <thead class=""thead-dark"" class=""text-center;"">
  </thead>
        var date = a.day.ToString(""dd MMMM yyyy"");
            <tr><td><img style=""width:20px"" src=""https://lh4.googleusercontent.com/proxy/dCm4c2Zj3X73VGjvFo_9RofpstH-iHcQM7eD8ZExA3Kr9bCLSL35pfc_njReCHtxqiSB05eL7a_uLLBG_FmSbE8o_uJQy0qr6x4BlPEr-3lcvCQ""></td>
                <td style=""color:#21618C""><b></b></td>
                <td style=""color:");
                WriteLiteral(@"#21618C""></td>
            </tr>
 </tbody> 
    </table></div>
                </div>
                </div>
            </div>

                <div class=""row"">
        <div class=""col-lg-6 col-sm-5"">
             <div class=""card hovercard"" style=""box-shadow: 1px 1px 15px #5499C7 ;"">
                <div class=""cardheader "">
                    <br>
                    <h4 style=""color:#F5FBFF; font-family:Helvetica, sans-serif"">New Applicants</h4>
                </div>
                <div class=""body"">
                <div style=""margin-left:47px; margin-right:50px""><br>
                <table style=""background:white"" class=""table table-hover text-center"">
            <tbody>
    <br>
    <thead class=""thead-dark"" class=""text-center;"">
  </thead>  
            <tr><td><img style=""width:20px"" src=""https://freeiconshop.com/wp-content/uploads/edd/person-outline.png""></td>
                <td style=""color:#21618C""><b></b></td>
                <td style=""color:#21618C"">Occupation</td>");
                WriteLiteral(@"
                <td style=""color:#21618C"">Placement</td>
            </tr> }
            } 
    }
 </tbody> 
    </table></div>

                </div>
                </div>
            </div> 
</div>

	</div>
    <br><br><br><br>
</div>
  </div>
</div><br>
");
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
            WriteLiteral("\r\n</html>");
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