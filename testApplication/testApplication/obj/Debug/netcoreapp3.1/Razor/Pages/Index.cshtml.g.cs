#pragma checksum "C:\Users\user\source\repos\testApplication\testApplication\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b62143c96cfd5c8da2139ec92583fa552fc08ea3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(testApplication.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace testApplication.Pages
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
#line 1 "C:\Users\user\source\repos\testApplication\testApplication\Pages\_ViewImports.cshtml"
using testApplication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b62143c96cfd5c8da2139ec92583fa552fc08ea3", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bee5b2a6a601a037e9b7412f6969a6ccc6a15e7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\user\source\repos\testApplication\testApplication\Pages\Index.cshtml"
  
    ViewData["Title"] = "Example";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n</div>\r\n<!--\r\n<div class=\"card-columns\">\r\n");
#nullable restore
#line 12 "C:\Users\user\source\repos\testApplication\testApplication\Pages\Index.cshtml"
     foreach (var product in Model.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <div class=\"card-img\"");
            BeginWriteAttribute("style", " style=\"", 294, "\"", 342, 4);
            WriteAttributeValue("", 302, "background-image:", 302, 17, true);
            WriteAttributeValue(" ", 319, "url(\'", 320, 6, true);
#nullable restore
#line 15 "C:\Users\user\source\repos\testApplication\testApplication\Pages\Index.cshtml"
WriteAttributeValue("", 325, product.Image, 325, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 339, "\');", 339, 3, true);
            EndWriteAttribute();
            WriteLiteral(">  </div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 17 "C:\Users\user\source\repos\testApplication\testApplication\Pages\Index.cshtml"
                                  Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\user\source\repos\testApplication\testApplication\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n-->\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b62143c96cfd5c8da2139ec92583fa552fc08ea34858", async() => {
                WriteLiteral("\r\n        <label>First Name</label>\r\n        <input type=\"text\" placeholder=\"FirstName\"/>\r\n    ");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
