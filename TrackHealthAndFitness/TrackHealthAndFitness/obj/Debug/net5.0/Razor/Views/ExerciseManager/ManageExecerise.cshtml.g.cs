#pragma checksum "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f02a68bc6a313e38305a670459349201d909c46d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f02a68bc6a313e38305a670459349201d909c46d", @"/Views/ExerciseManager/ManageExecerise.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c28a1802f951afc08876d3ac107d8d7258ff84d", @"/Views/_ViewImports.cshtml")]
    public class Views_ExerciseManager_ManageExecerise : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Exercise>
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

    int counter = 0;

    DifferentExercise different = new DifferentExercise();
    different.ExerciseName = Model.ExerciseName;
    different.TypeOfExercise = Model.TypeOfExercise;

    string date = DateTime.Today.ToString();

    //Sorting Through

    bool isEmpty = false;
    if (Model != null)
    {
        isEmpty = true;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f02a68bc6a313e38305a670459349201d909c46d4468", async() => {
                WriteLiteral(@"
    <!-- Tab links -->
    <div class=""tab"">
        <button class=""button"" onclick=""openTab(event, 'Track')"" id=""defaultOpen"">Track</button>
        <button class=""button"" onclick=""openTab(event, 'History')"">History</button>
        <button class=""button"" onclick=""openTab(event, 'OneRepMax')"">One Rep Max</button>
    </div>

    <!-- Tab content -->
    <div id=""Track"" class=""tabcontent"">
        <div class=""tile is-ancestor"" style=""margin-left: 20%; margin-right: 20%;"">
            <!--First Column-->
            <div class=""tile is-parent"">
                <!--Getting the Type Of Content From the User-->
                <article class=""tile is-child is-12 notification content-box-boxshadow is-link"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f02a68bc6a313e38305a670459349201d909c46d5499", async() => {
                    WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <label");
                    BeginWriteAttribute("for", " for=\"", 1361, "\"", 1367, 0);
                    EndWriteAttribute();
                    WriteLiteral(">Weight (kgs)</label>\r\n                            <input type=\"text\" class=\"form-control\" id=\"enterWeight\"");
                    BeginWriteAttribute("value", " value=\"", 1475, "\"", 1483, 0);
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f02a68bc6a313e38305a670459349201d909c46d7433", async() => {
                    WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <label");
                    BeginWriteAttribute("for", " for=\"", 1687, "\"", 1693, 0);
                    EndWriteAttribute();
                    WriteLiteral(">Reps</label>\r\n                            <input type=\"text\" class=\"form-control\" id=\"enterReps\"");
                    BeginWriteAttribute("value", " value=\"", 1791, "\"", 1799, 0);
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

        <table id=""usersTable""");
                BeginWriteAttribute("style", " style=\"", 2186, "\"", 2194, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""table"">
            <thead>
                <tr id=""head"" class=""head"">
                    <th scope=""col"">Exercise Name</th>
                    <th scope=""col"">Set</th>
                    <th scope=""col"">Muscle Group</th>
                    <th scope=""col"">Reps</th>
                    <th scope=""col"">Weight</th>
                    <th scope=""col"">Personal Best</th>
                </tr>
            </thead>

");
#nullable restore
#line 72 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
             foreach (ExerciseTracker item in Model.dayList)
            {
                if (item != null)
                {
                    {
                        counter = counter + 1;
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td id=\"ExerciseName\">");
#nullable restore
#line 80 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                                         Write(item.ExerciseName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td id=\"Set\">");
#nullable restore
#line 81 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                                Write(counter);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td id=\"Group\">");
#nullable restore
#line 82 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                                  Write(item.TypeOfExercise);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td id=\"Reps\">");
#nullable restore
#line 83 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                                 Write(item.Reps);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td id=\"Weight\">");
#nullable restore
#line 84 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                                   Write(item.Weight);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 85 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                         if (item.PersonalBest == true)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td id=\"Weight\">true</td>\r\n");
#nullable restore
#line 88 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td id=\"Weight\">false</td>\r\n");
#nullable restore
#line 92 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 94 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </table>
        <br />

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
");
#nullable restore
#line 118 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
             foreach (var group in Model.exerciseTrackers.GroupBy(x => x.Date))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <table id=\"usersTable\"");
                BeginWriteAttribute("style", " style=\"", 4388, "\"", 4396, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""table"">
                    <thead>
                        <tr id=""head"" class=""head"">
                            <th scope=""col"">Exercise Name</th>
                            <th scope=""col"">Muscle Group</th>
                            <th scope=""col"">Reps</th>
                            <th scope=""col"">Weight</th>
                            <th scope=""col"">Personal Best</th>
                            <th scope=""col"">Delete Exercise</th>
                        </tr>
                    </thead>
");
#nullable restore
#line 131 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                     foreach (ExerciseTracker item in group)
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td id=\"ExerciseName\">");
#nullable restore
#line 135 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                                             Write(item.ExerciseName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td id=\"Group\">");
#nullable restore
#line 136 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                                      Write(item.TypeOfExercise);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td id=\"Reps\">");
#nullable restore
#line 137 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                                     Write(item.Reps);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td id=\"Weight\">");
#nullable restore
#line 138 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                                       Write(item.Weight);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 139 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                             if (item.PersonalBest == true)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td id=\"Weight\">true</td>\r\n");
#nullable restore
#line 142 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td id=\"Weight\">false</td>\r\n");
#nullable restore
#line 146 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td id=\"Delete\"> <button class=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 5715, "\"", 6034, 5);
                WriteAttributeValue("", 5725, "location.href", 5725, 13, true);
                WriteAttributeValue(" ", 5738, "=", 5739, 2, true);
                WriteAttributeValue(" ", 5740, "\'", 5741, 2, true);
#nullable restore
#line 147 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
WriteAttributeValue("", 5742, Html.Raw(Url.Action("DeleteExercise", "ExerciseManager", new { date = item.Date, Id = item.Id, inputID = item.InputID, ExerciseName = item.ExerciseName, TypeOfExercise = item.TypeOfExercise, Reps = item.Reps, Weight = item.Weight, PersonalBest = item.PersonalBest, different = different })), 5742, 291, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6033, "\'", 6033, 1, true);
                EndWriteAttribute();
                WriteLiteral(" id=\"defaultOpen\">Delete</button></td>\r\n                        </tr>\r\n");
#nullable restore
#line 149 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </table>\r\n                <br />\r\n");
#nullable restore
#line 153 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </div>
    </div>
    <div id=""OneRepMax"" class=""tabcontent"">
        <div class=""tile is-ancestor"" style=""margin-left: 20%; margin-right: 20%;"">
            <!--First Column-->
            <div class=""tile is-parent"">
                <!--Getting the Type Of Content From the User-->
                <article class=""tile is-child is-12 notification content-box-boxshadow is-link"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f02a68bc6a313e38305a670459349201d909c46d20775", async() => {
                    WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <label");
                    BeginWriteAttribute("for", " for=\"", 6705, "\"", 6711, 0);
                    EndWriteAttribute();
                    WriteLiteral(">One Rep Max for ");
#nullable restore
#line 164 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                                                     Write(Model.ExerciseName);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" is ");
#nullable restore
#line 164 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                                                                            Write(Model.OneRepMax);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                        </div>\r\n                    ");
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
                WriteLiteral("\r\n                </article>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        //Update to New Controller
        const");
            WriteLiteral(" progress = {\r\n            muscle: \'");
#nullable restore
#line 199 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                Write(Model.TypeOfExercise);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            exerciseName:\'");
#nullable restore
#line 200 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                     Write(Model.ExerciseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            Weight: document.getElementById(\'enterWeight\').value,\r\n            Reps: document.getElementById(\'enterReps\').value\r\n        };\r\n        $.post(\"/ExerciseManager/AddExecerise\", progress, function (data) {\r\n                RedirectToPage(\'");
#nullable restore
#line 205 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\ManageExecerise.cshtml"
                           Write(Html.Raw(Url.Action("ManageExecerise", "ExerciseManager", new { ExerciseName = different.ExerciseName, TypeOfExercise = different.TypeOfExercise})));

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n            });\r\n    }\r\n\r\n    function RedirectToPage(url) {\r\n        location.href = url;\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exercise> Html { get; private set; }
    }
}
#pragma warning restore 1591
