#pragma checksum "C:\Users\Ali\Desktop\ASP.NET Core 5.0 Project\ASP.NET Core 5.0 Project\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b71e0ce6e87b0910b09455f1a300b37f1ad63d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\Ali\Desktop\ASP.NET Core 5.0 Project\ASP.NET Core 5.0 Project\Views\_ViewImports.cshtml"
using ASP.NET_Core_5._0_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ali\Desktop\ASP.NET Core 5.0 Project\ASP.NET Core 5.0 Project\Views\_ViewImports.cshtml"
using ASP.NET_Core_5._0_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ali\Desktop\ASP.NET Core 5.0 Project\ASP.NET Core 5.0 Project\Views\Category\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b71e0ce6e87b0910b09455f1a300b37f1ad63d7", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be53db986ae17e8352e3b8e9c059d3a0ef26eb55", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css//bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Ali\Desktop\ASP.NET Core 5.0 Project\ASP.NET Core 5.0 Project\Views\Category\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2b71e0ce6e87b0910b09455f1a300b37f1ad63d74397", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>id</th>\r\n        <th>Cat name</th>\r\n        <th>Cat status</th>\r\n        <th>Cat det</th>\r\n        <th>Cat del</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\Ali\Desktop\ASP.NET Core 5.0 Project\ASP.NET Core 5.0 Project\Views\Category\Index.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <Tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Ali\Desktop\ASP.NET Core 5.0 Project\ASP.NET Core 5.0 Project\Views\Category\Index.cshtml"
           Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Ali\Desktop\ASP.NET Core 5.0 Project\ASP.NET Core 5.0 Project\Views\Category\Index.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Ali\Desktop\ASP.NET Core 5.0 Project\ASP.NET Core 5.0 Project\Views\Category\Index.cshtml"
           Write(item.CategoryStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-warning\">Cat details</a></td>\r\n            <td><button>Delete</button></td>\r\n        </Tr>\r\n");
#nullable restore
#line 26 "C:\Users\Ali\Desktop\ASP.NET Core 5.0 Project\ASP.NET Core 5.0 Project\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
