#pragma checksum "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\HomeExercise.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3c2e392c4444695fcb559db81c17d3e1098b01b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ExerciseManager_HomeExercise), @"mvc.1.0.view", @"/Views/ExerciseManager/HomeExercise.cshtml")]
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
#line 2 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\HomeExercise.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3c2e392c4444695fcb559db81c17d3e1098b01b", @"/Views/ExerciseManager/HomeExercise.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c28a1802f951afc08876d3ac107d8d7258ff84d", @"/Views/_ViewImports.cshtml")]
    public class Views_ExerciseManager_HomeExercise : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Exercise>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\HomeExercise.cshtml"
  
    ViewData["Title"] = "Todays Exercise";

    int counter = 0;

    string visibility = "visibility:hidden;";
    if((String.IsNullOrEmpty(Model.ExerciseName)))
    {
        visibility = "visibility:visible;";
    }

    //Sorting Through

    string websiteDate = Model.trackedDate.ToString();
    bool isEmpty = false;
    if (Model != null)
    {
        isEmpty = true;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c2e392c4444695fcb559db81c17d3e1098b01b4132", async() => {
                WriteLiteral("\r\n \r\n    <div class=\"tab\">\r\n        <button");
                BeginWriteAttribute("style", " style=\"", 564, "\"", 572, 0);
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 573, "\"", 748, 5);
                WriteAttributeValue("", 583, "location.href", 583, 13, true);
                WriteAttributeValue(" ", 596, "=", 597, 2, true);
                WriteAttributeValue(" ", 598, "\'", 599, 2, true);
#nullable restore
#line 28 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\HomeExercise.cshtml"
WriteAttributeValue("", 600, Html.Raw(Url.Action("HomeExercise", "ExerciseManager", new { ExerciseName = Model.ExerciseName, date = Model.trackedDate.AddDays(-1).ToString()})), 600, 147, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 747, "\'", 747, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-success\">Backward</button>\r\n        <button");
                BeginWriteAttribute("style", " style=\"", 808, "\"", 816, 0);
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 817, "\"", 991, 5);
                WriteAttributeValue("", 827, "location.href", 827, 13, true);
                WriteAttributeValue(" ", 840, "=", 841, 2, true);
                WriteAttributeValue(" ", 842, "\'", 843, 2, true);
#nullable restore
#line 29 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\HomeExercise.cshtml"
WriteAttributeValue("", 844, Html.Raw(Url.Action("HomeExercise", "ExerciseManager", new { ExerciseName = Model.ExerciseName, date = Model.trackedDate.AddDays(1).ToString()})), 844, 146, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 990, "\'", 990, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-success\">Forward</button>\r\n    </div>\r\n\r\n");
#nullable restore
#line 32 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\HomeExercise.cshtml"
         foreach (var group in Model.dayList.GroupBy(x => x.ExerciseName))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <table id=\"usersTable\"");
                BeginWriteAttribute("style", " style=\"", 1170, "\"", 1178, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""table"">
                <thead>
                    <tr id=""head"" class=""head"">
                        <th scope=""col"">Exercise Name</th>
                        <th scope=""col"">Muscle Group</th>
                        <th scope=""col"">Reps</th>
                        <th scope=""col"">Weight</th>
                        <th scope=""col"">Personal Best</th>
                        <th scope=""col"">Date</th>
                    </tr>
                </thead>
");
#nullable restore
#line 45 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\HomeExercise.cshtml"
                 foreach (ExerciseTracker item in group)
                {


#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td style=\"width:200px;\" id=\"ExerciseName\">");
#nullable restore
#line 49 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\HomeExercise.cshtml"
                                                      Write(item.ExerciseName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td id=\"Group\">");
#nullable restore
#line 50 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\HomeExercise.cshtml"
                          Write(item.TypeOfExercise);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td id=\"Reps\">");
#nullable restore
#line 51 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\HomeExercise.cshtml"
                         Write(item.Reps);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td id=\"Weight\">");
#nullable restore
#line 52 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\HomeExercise.cshtml"
                           Write(item.Weight);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 53 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\HomeExercise.cshtml"
                 if (item.PersonalBest == true)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td id=\"Weight\">true</td>\r\n");
#nullable restore
#line 56 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\HomeExercise.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td id=\"Weight\">false</td>\r\n");
#nullable restore
#line 60 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\HomeExercise.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <td id=\"Date\">");
#nullable restore
#line 61 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\HomeExercise.cshtml"
                         Write(item.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 63 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\HomeExercise.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </table>         \r\n");
#nullable restore
#line 67 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\ExerciseManager\HomeExercise.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("     \r\n");
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
