#pragma checksum "D:\My_OO\MyMVC\MyMVC\Pages\Thorough.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29942737ef34305b82894d410107dc661c22fecb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Thorough), @"mvc.1.0.razor-page", @"/Pages/Thorough.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Thorough.cshtml", typeof(AspNetCore.Pages_Thorough), null)]
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
#line 1 "D:\My_OO\MyMVC\MyMVC\Pages\_ViewImports.cshtml"
using MyMVC;

#line default
#line hidden
#line 2 "D:\My_OO\MyMVC\MyMVC\Pages\_ViewImports.cshtml"
using MyMVC.HomeWork;

#line default
#line hidden
#line 3 "D:\My_OO\MyMVC\MyMVC\Pages\_ViewImports.cshtml"
using MyMVC.Pages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29942737ef34305b82894d410107dc661c22fecb", @"/Pages/Thorough.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d70531f2e83c11d11cdb067b17d5ad19b98a598e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Thorough : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\My_OO\MyMVC\MyMVC\Pages\Thorough.cshtml"
  
	 ThoroughModel.House1 house = Model.house;

#line default
#line hidden
            BeginContext(81, 83, true);
            WriteLiteral("<div class=\"text-center\">\r\n\t<h1 class=\"display-4\">Welcome</h1>\r\n\t<p>Thorough</p>\r\n\t");
            EndContext();
            BeginContext(164, 514, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29942737ef34305b82894d410107dc661c22fecb3839", async() => {
                BeginContext(184, 86, true);
                WriteLiteral("\r\n\t\t<div>\r\n\t\t\t<span>Address:</span>\r\n\t\t\t<input type=\"text\" id=\"address\" name=\"address\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 270, "\"", 296, 1);
#line 12 "D:\My_OO\MyMVC\MyMVC\Pages\Thorough.cshtml"
WriteAttributeValue("", 278, ViewData["rooms"], 278, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(297, 74, true);
                WriteLiteral(" />\r\n\t\t\t<span>Rooms:</span>\r\n\t\t\t<input type=\"text\" id=\"rooms\" name=\"rooms\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 371, "\"", 399, 1);
#line 14 "D:\My_OO\MyMVC\MyMVC\Pages\Thorough.cshtml"
WriteAttributeValue("", 379, ViewData["address"], 379, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(400, 58, true);
                WriteLiteral(" />\t\t\t\r\n\t\t\t<button type=\"submit\" id=\"send\">Send</button>\r\n");
                EndContext();
                BeginContext(660, 11, true);
                WriteLiteral("\t\t</div>\r\n\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(678, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ThoroughModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ThoroughModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ThoroughModel>)PageContext?.ViewData;
        public ThoroughModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
