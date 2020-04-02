#pragma checksum "C:\Users\Jay\source\repos\BBKing.Website\BBKing.Website\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13bd22a04b7d26073259bc2e6cadd53f98ae6c3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BBKing.Website.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace BBKing.Website.Pages
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
#line 1 "C:\Users\Jay\source\repos\BBKing.Website\BBKing.Website\Pages\_ViewImports.cshtml"
using BBKing.Website;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13bd22a04b7d26073259bc2e6cadd53f98ae6c3f", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbb15422e9f799b32dc0c068e76ff8791fb24fea", @"/Pages/_ViewImports.cshtml")]
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Jay\source\repos\BBKing.Website\BBKing.Website\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13bd22a04b7d26073259bc2e6cadd53f98ae6c3f3045", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <title>Basketball King</title>
    <style>
        table{
            border-collapse:collapse;
        }
        td, th{
            border: 1px solid #ccc;
            padding:6px;
        }
        th:empty{
            border:0;
        }
    </style>
    <script>src = ""https://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"" ></script>
    <script>
        $(function () {
            var col, el;
            $(""input[type=radio]"").click(function () {
                el = $(this);
                col = el.data(""col"");
                $(""input[data-col="" + col + ""]"").prop(""checked"", false);
                el.prop(""checked"", true);
            });
        });
    </script>
");
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
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Basketball King</h1>\r\n</div>\r\n<h1>Players</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th></th>\r\n        <th>P1</th>\r\n        <th>P2</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 46 "C:\Users\Jay\source\repos\BBKing.Website\BBKing.Website\Pages\Index.cshtml"
     foreach (var player in Model.Players)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 49 "C:\Users\Jay\source\repos\BBKing.Website\BBKing.Website\Pages\Index.cshtml"
           Write(player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><input type=\"radio\"");
            BeginWriteAttribute("name", " name=", 1201, "", 1219, 1);
#nullable restore
#line 50 "C:\Users\Jay\source\repos\BBKing.Website\BBKing.Website\Pages\Index.cshtml"
WriteAttributeValue("", 1207, player.Name, 1207, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-col=\"1\" /></td>\r\n            <td><input type=\"radio\"");
            BeginWriteAttribute("name", " name=", 1277, "", 1295, 1);
#nullable restore
#line 51 "C:\Users\Jay\source\repos\BBKing.Website\BBKing.Website\Pages\Index.cshtml"
WriteAttributeValue("", 1283, player.Name, 1283, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-col=\"2\" /></td>\r\n        </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Jay\source\repos\BBKing.Website\BBKing.Website\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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