#pragma checksum "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\Home\FitnessTracker.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3dd78da91bf520da8d30881ecbfa60b70c32ffa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FitnessTracker), @"mvc.1.0.view", @"/Views/Home/FitnessTracker.cshtml")]
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
#line 2 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\Home\FitnessTracker.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3dd78da91bf520da8d30881ecbfa60b70c32ffa", @"/Views/Home/FitnessTracker.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c28a1802f951afc08876d3ac107d8d7258ff84d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FitnessTracker : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExerciseTracker>
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\Home\FitnessTracker.cshtml"
  
    ViewData["Title"] = "Select Muscle Group";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3dd78da91bf520da8d30881ecbfa60b70c32ffa3758", async() => {
                WriteLiteral("\r\n    <div>\r\n        <button");
                BeginWriteAttribute("onclick", " onclick=\"", 205, "\"", 289, 5);
                WriteAttributeValue("", 215, "location.href", 215, 13, true);
                WriteAttributeValue(" ", 228, "=", 229, 2, true);
                WriteAttributeValue(" ", 230, "\'", 231, 2, true);
#nullable restore
#line 11 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\Home\FitnessTracker.cshtml"
WriteAttributeValue("", 232, Html.Raw(Url.Action("PersonalBest", "ExerciseManager")), 232, 56, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 288, "\'", 288, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-success"">Personal Best</button>
    </div>
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
        <article class=""tile notification is-white white-box users-box"">
            <table id=""usersTable"" class=""table"">
                <thead>
                    <tr id=""head"" class=""head"">
                        <th scope=""col"">Muscle Group</th>
                        <th scope=""col"">Select</th>
                    </tr>
                </thead>

                <tbody class=""userTable"">

");
#nullable restore
#line 40 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\Home\FitnessTracker.cshtml"
                     foreach (string value in Enum.GetNames(typeof(ExerciseTracker.MuscleGroups)))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td id=\"ExerciseType\">");
#nullable restore
#line 43 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\Home\FitnessTracker.cshtml"
                                             Write(value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td id=\"selection\">\r\n                                <button");
                BeginWriteAttribute("onclick", " onclick=\"", 1601, "\"", 1716, 5);
                WriteAttributeValue("", 1611, "location.href", 1611, 13, true);
                WriteAttributeValue(" ", 1624, "=", 1625, 2, true);
                WriteAttributeValue(" ", 1626, "\'", 1627, 2, true);
#nullable restore
#line 45 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\Home\FitnessTracker.cshtml"
WriteAttributeValue("", 1628, Html.Raw(Url.Action("SelectExercise", "ExerciseManager", new {ExerciseType = @value})), 1628, 87, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1715, "\'", 1715, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-success\">Select Page</button>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 48 "C:\Users\Ollie\Desktop\Work\TrackFitness\TrackHealthAndFitness\TrackHealthAndFitness\Views\Home\FitnessTracker.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n        </article>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExerciseTracker> Html { get; private set; }
    }
}
#pragma warning restore 1591
