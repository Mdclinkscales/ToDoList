#pragma checksum "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24e83c930a36f5df1b146083915d6a94fe06e5b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
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
#line 1 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\_ViewImports.cshtml"
using Office;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
using Office.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24e83c930a36f5df1b146083915d6a94fe06e5b9", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3fdf28ae0e3323ea83a67368aa4014112f9d50f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Todo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/rsvp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-3""></div>
    <div class=""col-6"">
        <h2>Active Todo List</h2>
        <table class=""table-striped table-bordered text-center"">
            <thead class=""text-center"">
                <th>  Activity  </th>
                <th>  Due Date  </th>
                <th>  Difficulty  </th>
                <th>  Task Creator  </th>
                <th>  No. of Supporters  </th>
                <th></th>
            </thead>
            <tbody>
");
#nullable restore
#line 20 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                 foreach (var activity in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 741, "\"", 770, 2);
            WriteAttributeValue("", 748, "/Todo/", 748, 6, true);
#nullable restore
#line 23 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
WriteAttributeValue("", 754, activity.TodoId, 754, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                                                        Write(activity.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n");
#nullable restore
#line 24 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                         if(activity.DueDate<DateTime.Now){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"bg-danger\">");
#nullable restore
#line 25 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                                             Write(activity.DueDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 26 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                        }
                        else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 28 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                           Write(activity.DueDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 29 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                         if(activity.Difficulty>4){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"bg-danger\">");
#nullable restore
#line 31 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                                             Write(activity.Difficulty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 32 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                         if(activity.Difficulty>2&activity.Difficulty<5){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"bg-warning\">");
#nullable restore
#line 34 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                                              Write(activity.Difficulty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 35 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                        }
                        else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"bg-success\">");
#nullable restore
#line 37 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                                              Write(activity.Difficulty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 38 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n                        <td>");
#nullable restore
#line 40 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                       Write(activity.Giver.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 40 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                                                 Write(activity.Giver.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                       Write(activity.Supporters.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 42 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                         if(ViewBag.User!=null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24e83c930a36f5df1b146083915d6a94fe06e5b910312", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("value", " value=\"", 1982, "\"", 2010, 1);
#nullable restore
#line 45 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
WriteAttributeValue("", 1990, ViewBag.User.UserId, 1990, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <input type=\"hidden\" name=\"TodoId\"");
                BeginWriteAttribute("value", " value=\"", 2084, "\"", 2108, 1);
#nullable restore
#line 46 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
WriteAttributeValue("", 2092, activity.TodoId, 2092, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 47 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                                     if(ViewBag.User.UserId==1){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"submit\" value=\"Complete\" class=\"btn btn-danger\">\r\n");
#nullable restore
#line 49 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                                    }
                                    else{
                                        if(activity.Supporters.Any(a=>a.UserId==ViewBag.User.UserId))
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <input type=\"submit\" value=\"Remove Support\" class=\"btn btn-primary\">\r\n");
#nullable restore
#line 54 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                                        }
                                        else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <input type=\"submit\" value=\"Support\" class=\"btn btn-primary\">\r\n");
#nullable restore
#line 57 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 61 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 63 "C:\Users\mdcli\Documents\Coding_Dojo\C#\orm\office\Views\Home\Home.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"/Todoform\">Add a Task!</a>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"col-3\"></div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Todo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
