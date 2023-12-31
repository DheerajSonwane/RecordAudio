#pragma checksum "C:\Users\hp\Desktop\Projects\RecordAduio1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc4c882d195cecc4598185f1097874c9867b533f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\Projects\RecordAduio1\Views\_ViewImports.cshtml"
using RecordAduio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\Projects\RecordAduio1\Views\_ViewImports.cshtml"
using RecordAduio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc4c882d195cecc4598185f1097874c9867b533f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe5a5770368b6884ef31daebea9bc3eaf2ecc0e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\hp\Desktop\Projects\RecordAduio1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Record Audio";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\hp\Desktop\Projects\RecordAduio1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Audio Recording";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc4c882d195cecc4598185f1097874c9867b533f3628", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 13 "C:\Users\hp\Desktop\Projects\RecordAduio1\Views\Home\Index.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <!-- Include your JavaScript code here -->
    <script>
        let mediaRecorder;
        let audioChunks = [];
        let recording = false;

        document.addEventListener('DOMContentLoaded', function () {
            document.getElementById('startRecording').addEventListener('click', function () {
                audioChunks = [];
                navigator.mediaDevices.getUserMedia({ audio: true })
                    .then(function (stream) {
                        mediaRecorder = new MediaRecorder(stream);

                        mediaRecorder.ondataavailable = function (event) {
                            if (event.data.size > 0) {
                                audioChunks.push(event.data);
                            }
                        };

                        mediaRecorder.onstop = function () {
                            saveRecordedAudio();
                        };

                        mediaRecorder.start();
                        rec");
                WriteLiteral(@"ording = true;
                        document.getElementById('startRecording').disabled = true;
                        document.getElementById('stopRecording').disabled = false;
                    })
                    .catch(function (err) {
                        console.error('Error accessing microphone:', err);
                    });
            });

            document.getElementById('stopRecording').addEventListener('click', function () {
                if (recording) {
                    mediaRecorder.stop();
                    recording = false;
                }
                document.getElementById('startRecording').disabled = false;
                document.getElementById('stopRecording').disabled = true;
            });

            function saveRecordedAudio() {
                if (audioChunks.length === 0) {
                    console.error('No audio data to save.');
                    return;
                }

                const audioBlob = new Blob(au");
                WriteLiteral(@"dioChunks, { type: 'audio/wav' });

                // Create a FormData object to send the audio data to the server
                const formData = new FormData();
                formData.append('audioData', audioBlob);

                // Send the audio data to the server using a fetch POST request
                fetch('/Home/SaveAudio', {
                    method: 'POST',
                    body: formData
                })
                    .then(response => response.json())
                    .then(data => {
                        if (data.success) {
                            const successMessage = document.getElementById('successMessage');
                            successMessage.innerHTML = '<p>' + data.message + '</p>';
                        } else {
                            const errorMessage = document.getElementById('errorMessage');
                            errorMessage.innerHTML = '<p>' + data.message + '</p>';
                            console.error('Err");
                WriteLiteral("or saving audio:\', data.message);\r\n                        }\r\n                    })\r\n                    .catch(error => {\r\n                        console.error(\'Error:\', error);\r\n                    });\r\n            }\r\n        });\r\n    </script>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc4c882d195cecc4598185f1097874c9867b533f8271", async() => {
                WriteLiteral(@"

    <h2>Record Audio</h2>


    <!-- Your HTML content here -->
    <button id=""startRecording"">Start Recording</button>
    <button id=""stopRecording"" disabled>Stop Recording</button>

    <div id=""successMessage"" style=""color: lawngreen;""></div>
    <div id=""errorMessage"" style=""color: red;""></div>

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
            WriteLiteral("\r\n</html>\r\n");
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
