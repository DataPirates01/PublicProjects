#pragma checksum "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Question\AskQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf05b2bdbf0397abca81aec6ef4678c478a9c5e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_AskQuestion), @"mvc.1.0.view", @"/Views/Question/AskQuestion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Question/AskQuestion.cshtml", typeof(AspNetCore.Views_Question_AskQuestion))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf05b2bdbf0397abca81aec6ef4678c478a9c5e1", @"/Views/Question/AskQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Question_AskQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CuriousDriveWebClient.AskQuestionViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/tinymce/tinymce.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("askQuestionForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Question\AskQuestion.cshtml"
  
    ViewBag.Title = "Ask Question - Curious Drive";

#line default
#line hidden
            BeginContext(114, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(118, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ee873bc3ea944758e43a5dfe96ad1b2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(174, 5027, true);
            WriteLiteral(@"

<link href=""https://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.2/themes/blitzer/jquery-ui.css"" rel=""Stylesheet"" type=""text/css"" />

<script type=""text/javascript"">

    var counterClasses = 0;
    var counterUsers = 0;
    var classes = [];
    var users = [];

    function removeClass(classId) {

        for (incrementer = 0; incrementer < classes.length; incrementer++) {
            var fields = classes[incrementer].split('#')
            if (fields[1] == classId)
            {
                document.getElementById('rowClasses').removeChild(document.getElementById(""td"" + classId));
                classes.splice(incrementer, 1);

                var txtClassIdText = document.getElementById('txtClassIds').value;
                txtClassIdText = txtClassIdText.replace(classId, '');
                document.getElementById('txtClassIds').value = txtClassIdText;
            }
        }
    }

    function removeUser(userId) {

        for (incrementer = 0; incrementer < users.length; ");
            WriteLiteral(@"incrementer++) {
            var fields = users[incrementer].split('#')
            if (fields[1] == userId) {
                document.getElementById('rowUsers').removeChild(document.getElementById(""td"" + userId));
                users.splice(incrementer, 1);

                var txtUserIdText = document.getElementById('txtUserTags').value;
                txtUserIdText = txtUserIdText.replace(userId, '');
                document.getElementById('txtUserTags').value = txtUserIdText;
            }
        }
    }

    function selectDropdownClasses(selectedObject) {

        var value = selectedObject.options[selectedObject.selectedIndex].innerText;
        var id = selectedObject.value;

        if (value == 'tag classes')
            return;

        var lblExists = false;

        for (incrementer = 0; incrementer < classes.length; incrementer++) {
            if (classes[incrementer] == value + '#' + id)
                lblExists = true;
        }

        if (!lblExists) {
 ");
            WriteLiteral(@"           var classesGroup = $('#rowClasses');
            classesGroup.append('<td id =""td' + id + '"" style=""background-color:cyan"">&nbsp; <label>' + value + '</label> '
                + '<input type=""button"" name=""btn' + counterClasses + '"" id=""btn' + counterClasses + '"" value =""x"" onclick=""removeClass(' + id + ')""></td> <td>&nbsp;</td>');

            classes.push(value + '#' + id);
            counterClasses++;

            var txtClassIds = $('#txtClassIds').val();
            if (txtClassIds != '')
                $('#txtClassIds').val(txtClassIds + ',' + id);
            else
                $('#txtClassIds').val(id);
        }

        this.value = '';
        return false;
    }    

    $(function () {

            $(""#txtUsers"").autocomplete({

                source: 'AutoCompleteUsers/',
                select: function (e, i) {
                    var lblExists = false;

                    for (incrementer = 0; incrementer < users.length; incrementer++) {
          ");
            WriteLiteral(@"              if (users[incrementer] == i.item.label + '#' + i.item.val)
                            lblExists = true;
                    }

                    if (!lblExists)
                    {
                        var usersGroup = $('#rowUsers');
                        usersGroup.append('<td id =""td' + i.item.val + '"" style=""background-color:cyan"">&nbsp; <label>' + i.item.label + '</label> '
                            + '<input type=""button"" value =""x"" onclick=removeUser(""'+ i.item.val +'"")></td> <td>&nbsp;</td>');

                        users.push(i.item.label + '#' + i.item.val);
                        counterUsers++;

                        var txtUserTags = $('#txtUserTags').val();
                        if (txtUserTags != '')
                            $('#txtUserTags').val(txtUserTags + ',' + i.item.val);
                        else
                            $('#txtUserTags').val(i.item.val);
                    }

                    this.value = '';
          ");
            WriteLiteral(@"          return false;
                },
                appendTo: '#divAutocompleteUsers',
                minLength: 0
            });
    });

    // Initialize your tinyMCE Editor with your preferred options
    tinymce.init({
        selector: 'textarea',
        menubar: false,
        branding: false,
        plugins: [
            'advlist autolink lists link image charmap print preview anchor textcolor',
            'searchreplace visualblocks code fullscreen',
            'insertdatetime media table contextmenu paste code wordcount'
        ],
        toolbar: 'insert | undo redo |  formatselect | bold italic backcolor  | alignleft aligncenter alignright alignjustify | bullist numlist outdent indent | removeformat',
        content_css: [
            '//fonts.googleapis.com/css?family=Lato:300,300i,400,400i',
            '//www.tinymce.com/css/codepen.min.css']
    });

</script>

");
            EndContext();
#line 139 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Question\AskQuestion.cshtml"
 using (Html.BeginForm("AskQuestion", "Question", FormMethod.Post, new { @class = "form-horizontal row card", role = "form" }))
{
    

#line default
#line hidden
            BeginContext(5338, 23, false);
#line 141 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Question\AskQuestion.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(5368, 41, false);
#line 142 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Question\AskQuestion.cshtml"
Write(Html.HiddenFor(model => model.questionId));

#line default
#line hidden
            EndContext();
            BeginContext(5416, 47, false);
#line 143 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Question\AskQuestion.cshtml"
Write(Html.HiddenFor(model => model.questionTitleURL));

#line default
#line hidden
            EndContext();
            BeginContext(5467, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(5471, 4319, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3fdd1d9c6124870985465658092b9ab", async() => {
                BeginContext(5547, 541, true);
                WriteLiteral(@"

        <div class=""form-group col-lg-12 col-12"">
            <div class=""col-lg-12 col-12"">
                <br />
            </div>

            <div class=""col-lg-12 col-12"">
                <p class=""bold-largest"">Ask a Question</p>
                <p>
                    You can ask questions to your peers, teachers and user groups. Good questions are voted up and rise to the top in the community.
                </p>
                <hr />
            </div>

            <div class=""col-lg-12"">
                ");
                EndContext();
                BeginContext(6089, 102, false);
#line 161 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Question\AskQuestion.cshtml"
           Write(Html.TextBoxFor(m => m.questionTitle, new { placeholder = "question title", @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(6191, 101, true);
                WriteLiteral("\r\n                <br />\r\n            </div>\r\n\r\n            <div class=\"col-lg-12\">\r\n                ");
                EndContext();
                BeginContext(6293, 80, false);
#line 166 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Question\AskQuestion.cshtml"
           Write(Html.TextAreaFor(m => m.questionHtml, new { @class = "form-control col-sm-16" }));

#line default
#line hidden
                EndContext();
                BeginContext(6373, 48, true);
                WriteLiteral("\r\n                <br />\r\n            </div>\r\n\r\n");
                EndContext();
                BeginContext(6589, 84, true);
                WriteLiteral("\r\n            <div class=\"col-lg-12 col-lg-12 col-sm-12 col-12\">\r\n\r\n                ");
                EndContext();
                BeginContext(6674, 885, false);
#line 176 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Question\AskQuestion.cshtml"
           Write(Html.DropDownListFor(m => m.selectedClass,
                                            Model.classesViewModel.Select(x => new SelectListItem
                                            {
                                                Text = x.className,
                                                Value = Convert.ToString(x.classId)
                                                 }),
                                                "tag classes",
                                                new
                                                     {
                                                         @class = "form-control",
                                                         @id = "dropdownClass",
                                                         @onchange = "selectDropdownClasses(this)"
                                                }));

#line default
#line hidden
                EndContext();
                BeginContext(7559, 1195, true);
                WriteLiteral(@"
            </div>

            <div class=""col-lg-12"">
                <br />
                <div id=""classesGroup""></div>
                <table id=""tblClasses"">
                    <tr id=""rowClasses""></tr>
                </table>
                <input type=""text"" id=""txtClassIds"" name=""txtClassIds"" hidden />
            </div>

            <div class=""col-lg-12 col-lg-12 col-sm-12 col-12"">
                <br />
            </div>

            <div class=""col-lg-4"">
                <input class=""form-control"" placeholder=""tag users"" type=""text"" id=""txtUsers"" name="""" />
                <div id=""divAutocompleteUsers"" class=""col-lg-4"">

                </div>
            </div>            

            <div class=""col-lg-12"">
                <br />
                <div id=""usersGroup""></div>
                <table id=""tblUsers"">
                    <tr id=""rowUsers""></tr>
                </table>
                <input type=""text"" id=""txtUserTags"" name=""txtUserTags"" hidden />");
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-lg-12 col-lg-12 col-sm-12 col-12\">\r\n                <br />\r\n            </div>\r\n\r\n            <div class=\"col-lg-12\">\r\n");
                EndContext();
#line 225 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Question\AskQuestion.cshtml"
                 if (Model == null)
                {

#line default
#line hidden
                BeginContext(8810, 149, true);
                WriteLiteral("                    <button id=\"submitQuestion\" class=\"btn btn-primary\" type=\"submit\" name=\"submitType\" value=\"PostQuestion\">Post Question</button>\r\n");
                EndContext();
#line 228 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Question\AskQuestion.cshtml"
                }
                else if (Model != null && Model.questionId == 0)
                {

#line default
#line hidden
                BeginContext(9063, 149, true);
                WriteLiteral("                    <button id=\"submitQuestion\" class=\"btn btn-primary\" type=\"submit\" name=\"submitType\" value=\"PostQuestion\">Post Question</button>\r\n");
                EndContext();
#line 232 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Question\AskQuestion.cshtml"
                }
                else if (Model.questionId > 0)
                {

#line default
#line hidden
                BeginContext(9298, 300, true);
                WriteLiteral(@"                    <button id=""updateQuestion"" class=""btn btn-primary"" type=""submit"" name=""submitType"" value=""UpdateQuestion"">Update</button>
                    <button id=""cancelUpdateQuestion"" class=""btn btn-primary"" type=""submit"" name=""submitType"" value=""CancelUpdateQuestion"">Cancel</button>
");
                EndContext();
#line 237 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Question\AskQuestion.cshtml"
                }

#line default
#line hidden
                BeginContext(9617, 166, true);
                WriteLiteral("            </div>\r\n            <div class=\"col-lg-12 col-12\">\r\n                <br />\r\n            </div>\r\n        </div>\r\n        <div class=\"col-lg-3\"></div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9790, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 245 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\Question\AskQuestion.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CuriousDriveWebClient.AskQuestionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
