#pragma checksum "C:\Users\Admin\source\repos\EmployeeManagement\emp\Pages\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8e662832aa9a990018f2884d5792762130e19db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(emp.Pages.Pages_Index1), @"mvc.1.0.view", @"/Pages/Index1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Index1.cshtml", typeof(emp.Pages.Pages_Index1))]
namespace emp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Admin\source\repos\EmployeeManagement\emp\Pages\_ViewImports.cshtml"
using emp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8e662832aa9a990018f2884d5792762130e19db", @"/Pages/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"253af1e86030d52261570a37b50c493db36e0235", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 366, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc7f7276a2a043b08f2aa90df958e8ef", async() => {
                BeginContext(31, 353, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <title></title>
    <script src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.4.5/angular.min.js"">
        <script src=""https://cdnjs.cloudflare.com/ajax/libs/angular.js/1.4.7/angular-route.min.js""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css""</script>
");
                EndContext();
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
            EndContext();
            BeginContext(391, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(393, 4649, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e54d484b9c94bec8a3e41e32988f15f", async() => {
                BeginContext(399, 4592, true);
                WriteLiteral(@"
    <h2>Index</h2>
    <div ng-app=""emp"">
        <div ng-controller=""HomeController"" ng-init=""GetAllData()"" class=""divList"">
            <p class=""divHead"">List of Employee</p>
            <table cellpadding=""12"" class=""table table-bordered table-hover"">
                <tr>
                    <td>
                        <b>FirstName</b>
                    </td>
                    <td>
                        <b>LastName</b>
                    </td>
                    <td>
                        <b>City</b>
                    </td>
                    <td>
                        <b>Contact</b>
                    </td>
                    <td>
                        <b>Gender</b>
                    </td>
                    <td>
                        <b>Actions</b>
                    </td>
                </tr>
                <tr ng-repeat=""Emp in employees"">
                    <td>
                        {{Emp.FirstName}}
                    </td>
            ");
                WriteLiteral(@"        <td>
                        {{Emp.LastName}}
                    </td>
                    <td>
                        {{Emp.City}}
                    </td>
                    <td>
                        {{Emp.Contact}}
                    </td>
                    <td>
                        {{Emp.Gender}}
                    </td>
                    <td>
                        <input type=""button"" class=""btn btn-warning"" value=""Update"" ng-click=""UpdateEmp(Emp)"" />
                        <input type=""button"" class=""btn btn-danger"" value=""Delete"" ng-click=""DeleteEmp(Emp)"" />
                    </td>
                </tr>
            </table>
            <div class=""form-horizontal"" role=""form"">
                <div class=""container"">
                    <div class=""row"">
                        <h2>
                            <span id=""spn"">Add New Employee</span>
                        </h2>
                    </div>
                    <div class=""row"">
       ");
                WriteLiteral(@"                 <div class=""col-sm-6 col-lg-4"">
                            <div class=""form-group"">
                                <label class=""col-md-4 control-label"">FirstName:</label>
                                <div class=""col-md-8"">
                                    <input type=""text"" class=""form-control"" id=""inputEmail"" placeholder=""FirstName"" ng-model=""FirstName"">
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-6 col-lg-4"">
                                <div class=""form-group"">
                                    <label class=""col-md-4 control-label"">LastName:</label>
                                    <div class=""col-md-8"">
                                        <input type=""text"" class=""form-control"" id=""inputEmail"" placeholder=""LastName"" ng-model=""LastName"">
                                    </div>
                           ");
                WriteLiteral(@"     </div>
                            </div>
                            <div class=""col-sm-6 col-lg-4"">
                                <div class=""form-group"">
                                    <label class=""col-md-4 control-label"">City:</label>
                                    <div class=""col-md-8"">
                                        <input type=""text"" class=""form-control"" id=""inputPassword"" placeholder=""City"" ng-model=""City"">
                                    </div>
                                </div>
                            </div>
                            <div class=""col-sm-6 col-lg-4"">
                                <div class=""form-group"">
                                    <label class=""col-md-4 control-label"">Contact:</label>
                                    <div class=""col-md-8"">
                                        <input type=""text"" class=""form-control"" id=""inputLabel3"" placeholder=""Contact"" ng-model=""Contact"">
                                    </di");
                WriteLiteral(@"v>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-6 col-lg-4"">
                                <input type=""button"" id=""btnSave"" class=""form-control btn-space"" value=""Submit"" ng-click=""InsertData()"" />
                            </div>
                        </div>
                    </div>
            </div>
        </div>
        ");
                EndContext();
                BeginContext(4992, 21, false);
#line 108 "C:\Users\Admin\source\repos\EmployeeManagement\emp\Pages\Index1.cshtml"
   Write(Html.Hidden("EmpID_"));

#line default
#line hidden
                EndContext();
                BeginContext(5013, 22, true);
                WriteLiteral("\r\n\r\n    </div>\r\n\r\n\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(5042, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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