#pragma checksum "C:\Users\abdul.haidar\source\repos\Attendance\Attendance\Views\Attendance\Employee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33d9e5dd325d7d0328abf186b58e8c72de3b69cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Attendance_Employee), @"mvc.1.0.view", @"/Views/Attendance/Employee.cshtml")]
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
#line 1 "C:\Users\abdul.haidar\source\repos\Attendance\Attendance\Views\_ViewImports.cshtml"
using Attendance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul.haidar\source\repos\Attendance\Attendance\Views\_ViewImports.cshtml"
using Attendance.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33d9e5dd325d7d0328abf186b58e8c72de3b69cd", @"/Views/Attendance/Employee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a669975357b271ab91d96f7de4cc023aa79e7d45", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Attendance_Employee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/EmployeeScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\abdul.haidar\source\repos\Attendance\Attendance\Views\Attendance\Employee.cshtml"
  
    ViewData["Title"] = "Employee";
    Layout = "~/Views/Layout/Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<!-- Main Content -->
<div id=""content"">

    <!-- Begin Page Content -->
    <div class=""container-fluid"">

        <!-- Page Heading -->
        


        <!-- Modal -->
        <div class=""modal fade "" id=""userModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""userModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog modal-lg"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title text-dark"" id=""userModalLabel"">New User</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33d9e5dd325d7d0328abf186b58e8c72de3b69cd6037", async() => {
                WriteLiteral("                            \r\n                            <div class=\"form-group\">\r\n                                <input type=\"hidden\" class=\"form-control\" id=\"idRole\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1142, "\"", 1156, 0);
                EndWriteAttribute();
                BeginWriteAttribute("readonly", " readonly=\"", 1157, "\"", 1168, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <input type=\"hidden\" class=\"form-control\" id=\"idDepartment\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1353, "\"", 1367, 0);
                EndWriteAttribute();
                BeginWriteAttribute("readonly", " readonly=\"", 1368, "\"", 1379, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <input  type=""hidden"" class=""form-control"" id=""nik"" placeholder=""Enter Nik"">
                            </div>
                            <div class=""form-row"">                                
                                <div class=""form-group col-md-6"">
                                    <label for=""name"">Name</label>
                                    <input");
                BeginWriteAttribute("required", " required=\"", 1790, "\"", 1801, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"" class=""form-control"" id=""name"" placeholder=""Enter Name"">
                                </div>
                                <div class=""form-group col-md-6"">
                                    <label for=""phone"">Phone</label>
                                    <input");
                BeginWriteAttribute("required", " required=\"", 2092, "\"", 2103, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"" class=""form-control"" id=""phone"" placeholder=""Enter Phone"">
                                </div>
                            </div>
                            <div class=""form-row"">
                                <div class=""form-group col-md-4"">
                                    <label for=""email"">Email</label>
                                    <input");
                BeginWriteAttribute("required", " required=\"", 2484, "\"", 2495, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"" class=""form-control"" id=""email"" placeholder=""Enter Email"">
                                </div>
                                <div class=""form-group col-md-4"">
                                    <label for=""gender"">Gender</label>
                                    <select");
                BeginWriteAttribute("required", " required=\"", 2791, "\"", 2802, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"gender\" class=\"form-control\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33d9e5dd325d7d0328abf186b58e8c72de3b69cd9405", async() => {
                    WriteLiteral("Choose Gender");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33d9e5dd325d7d0328abf186b58e8c72de3b69cd11321", async() => {
                    WriteLiteral("Man");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33d9e5dd325d7d0328abf186b58e8c72de3b69cd12582", async() => {
                    WriteLiteral("Women");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </select>
                                </div>

                                <div class=""form-group col-md-4"">
                                    <label for=""birthDate"">Birth Date</label>
                                    <input");
                BeginWriteAttribute("required", " required=\"", 3365, "\"", 3376, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""date"" class=""form-control"" id=""birthDate"" placeholder="" Phone"">
                                </div>

                            </div>
                            <div id=""uspw"" class=""form-row"">
                                <div class=""form-group col-md-6"">
                                    <label for=""username"">Username</label>
                                    <input");
                BeginWriteAttribute("required", " required=\"", 3774, "\"", 3785, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"" class=""form-control"" id=""username"" placeholder=""Enter Username"">
                                </div>

                                <div class=""form-group col-md-6"">
                                    <label for=""password"">Password</label>
                                    <input");
                BeginWriteAttribute("required", " required=\"", 4092, "\"", 4103, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" class=\"form-control\" id=\"password\" placeholder=\"Enter Password\">\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-row\">\r\n");
                WriteLiteral("                                <div class=\"form-group col-md-12\">\r\n                                    <label for=\"department\">Department</label>\r\n                                    <select");
                BeginWriteAttribute("required", " required=\"", 4916, "\"", 4927, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"department\" class=\"form-control\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33d9e5dd325d7d0328abf186b58e8c72de3b69cd16007", async() => {
                    WriteLiteral("Choose Department");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </select>
                                </div>

                            </div>
                            <div class=""form-row"">
                                <div class=""form-group col-md-12"">
                                    <label for=""address"">Address</label>
                                    <input");
                BeginWriteAttribute("required", " required=\"", 5432, "\"", 5443, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" class=\"form-control\" id=\"address\" placeholder=\"Enter Address\">\r\n                                </div>\r\n                            </div>\r\n\r\n\r\n                        ");
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
            WriteLiteral(@"
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-success"" id=""buttonSubmit"" onclick=""Save()"">Save</button>
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    </div>
                </div>
            </div>
        </div>

        <!-- DataTales  -->
        <div class=""card shadow mb-4"">
            <div class=""card-header py-3"">
                <div class=""row"">
                    <div class=""my-auto ml-2"">
                        <h1 class=""h3 mb-2 font-weight-bold text-white"">Management User</h1>
                    </div>
                    <div class=""ml-auto"">
                        <button id=""addButton"" type=""button"" style=""color: aliceblue; background-color: #059299;"" class=""btn btn"" onclick=""select();"" data-toggle=""modal"" data-target=""#userModal""><i class=""fas fa-plus""></i></button>
                    </div>
     ");
            WriteLiteral(@"           </div>
                
            </div>
            <div class=""card-body"">
                <div class=""table-responsive text-nowrap"">
                    <table class=""table table-bordered"" id=""tbEmployee"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>NO</th>
                                <th>NIK</th>
                                <th>NAME</th>
                                <th>DEPARTMENT</th>
                                <th>ROLE</th>
                                <th>EMAIL</th>
                                <th>PHONE</th>
                                <th>GENDER</th>
                                <th>ADDRESS</th>
                                <th>BIRTH DATE</th>
                                <th>USERNAME</th>                                
                                <th>ACTION</th>
                            </tr>
                        </thead>

           ");
            WriteLiteral("         </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n    <!-- /.container-fluid -->\r\n\r\n</div>\r\n<!-- End of Main Content -->\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33d9e5dd325d7d0328abf186b58e8c72de3b69cd22033", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
