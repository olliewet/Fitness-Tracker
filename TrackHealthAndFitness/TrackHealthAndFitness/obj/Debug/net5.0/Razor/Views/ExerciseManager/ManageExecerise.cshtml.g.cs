#pragma checksum "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbfdde8b1504a4b969f960f4ad84496926c2da0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ExerciseManager_ManageExecerise), @"mvc.1.0.view", @"/Views/ExerciseManager/ManageExecerise.cshtml")]
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
#line 1 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\_ViewImports.cshtml"
using TrackHealthAndFitness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\_ViewImports.cshtml"
using TrackHealthAndFitness.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbfdde8b1504a4b969f960f4ad84496926c2da0a", @"/Views/ExerciseManager/ManageExecerise.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c28a1802f951afc08876d3ac107d8d7258ff84d", @"/Views/_ViewImports.cshtml")]
    public class Views_ExerciseManager_ManageExecerise : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExerciseTracker>
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
  
    ViewData["Title"] = "Select Exercise";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbfdde8b1504a4b969f960f4ad84496926c2da0a4120", async() => {
                WriteLiteral(@"
    <!-- Tab links -->
    <div class=""tab"">
        <button class=""button"" onclick=""openTab(event, 'Track')"" id=""defaultOpen"">Track</button>
        <button class=""button"" onclick=""openTab(event, 'History')"">History</button>
  
    </div>

    <!-- Tab content -->
    <div id=""Track"" class=""tabcontent"">
        <div class=""tile is-ancestor"" style=""margin-left: 20%; margin-right: 20%;"">
            <!--First Column-->
            <div class=""tile is-parent"">
                <!--Getting the Type Of Content From the User-->
                <article class=""tile is-child is-12 notification content-box-boxshadow is-link"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbfdde8b1504a4b969f960f4ad84496926c2da0a5060", async() => {
                    WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <label");
                    BeginWriteAttribute("for", " for=\"", 927, "\"", 933, 0);
                    EndWriteAttribute();
                    WriteLiteral(">Weight (kgs)</label>\r\n                            <input type=\"text\" class=\"form-control\" id=\"enterWeight\"");
                    BeginWriteAttribute("value", " value=\"", 1041, "\"", 1049, 0);
                    EndWriteAttribute();
                    WriteLiteral(" placeholder=\"Enter Weight\">\r\n                        </div>\r\n                    ");
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
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbfdde8b1504a4b969f960f4ad84496926c2da0a6992", async() => {
                    WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <label");
                    BeginWriteAttribute("for", " for=\"", 1253, "\"", 1259, 0);
                    EndWriteAttribute();
                    WriteLiteral(">Reps</label>\r\n                            <input type=\"text\" class=\"form-control\" id=\"enterReps\"");
                    BeginWriteAttribute("value", " value=\"", 1357, "\"", 1365, 0);
                    EndWriteAttribute();
                    WriteLiteral(" placeholder=\"Enter Reps\">\r\n                        </div>\r\n                    ");
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
                    <!-- Submit Button -->
                    <div>
                        <button class=""button is-purple"" onclick=""SubmitExercise();"">Submit</button>
                    </div>
                </article>
            </div>
        </div>
        <p></p>
    </div>

    <div id=""History"" class=""tabcontent"">
        <div id=""main"">
            <div class=""columns"">
                <div class=""column"">
                    <article class=""tile notification is-white white-box"">
                        <div id=""navButtons"">

                        </div>
                    </article>
                </div>
                <div class=""column"">
                    <article class=""tile notification is-white white-box"">
                        <p class=""subtitle""></p>
                    </article>
                </div>
            </div>
            <div class=""gap-10""></div>
            <article class=""tile notification is-white white-box users-box");
                WriteLiteral(@""">
                <table id=""usersTable"" class=""table"">
                    <thead>
                        <tr id=""head"" class=""head"">
                            <th scope=""col"">Muscle Group</th>
                            <th scope=""col"">Select</th>
                        </tr>
                    </thead>
                    <tbody class=""userTable"">
                        <tr>
                            <td id=""ExerciseType""></td>
                            <td id=""selection"">
                                <button onclick=""location.href = ''"" class=""btn btn-success"">Select Page</button>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </article>
        </div>
    </div>



    
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
            WriteLiteral(@"
<script>
    document.getElementById(""defaultOpen"").click();

  

    function openTab(evt, tabName) {
        // Declare all variables
        var i, tabcontent, tablinks;

        // Get all elements with class=""tabcontent"" and hide them
        tabcontent = document.getElementsByClassName(""tabcontent"");
        for (i = 0; i < tabcontent.length; i++) {
            tabcontent[i].style.display = ""none"";
        }

        // Get all elements with class=""tablinks"" and remove the class ""active""
        tablinks = document.getElementsByClassName(""tablinks"");
        for (i = 0; i < tablinks.length; i++) {
            tablinks[i].className = tablinks[i].className.replace("" active"", """");
        }

        // Show the current tab, and add an ""active"" class to the button that opened the tab
        document.getElementById(tabName).style.display = ""block"";
        evt.currentTarget.className += "" active"";
    }

    function SubmitExercise() {
        var url = ""exercisemanager/api/adde");
            WriteLiteral("xecerise\";\r\n        //Update to New Controller\r\n        const progress = {\r\n            muscle: \'");
#nullable restore
#line 118 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                Write(Model.TypeOfExercise);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            exerciseName:\'");
#nullable restore
#line 119 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                     Write(Model.ExerciseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            Weight: document.getElementById(\'enterWeight\').value,\r\n            Reps: document.getElementById(\'enterReps\').value\r\n        };\r\n        $.post( \"/ExerciseManager/AddExecerise\",progress,function(data) {\r\n                RedirectToPage(\'");
#nullable restore
#line 124 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                           Write(Html.Raw(Url.Action("SelectExercise", "ExerciseManager")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n            });\r\n    }\r\n\r\n\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExerciseTracker> Html { get; private set; }
    }
}
#pragma warning restore 1591
