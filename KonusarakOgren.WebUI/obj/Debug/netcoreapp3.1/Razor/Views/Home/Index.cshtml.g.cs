#pragma checksum "C:\Users\zehra\source\repos\KonusarakOgren\KonusarakOgren.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f251ce359add1e735ee58399986f9150fb23248"
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
#line 1 "C:\Users\zehra\source\repos\KonusarakOgren\KonusarakOgren.WebUI\Views\_ViewImports.cshtml"
using KonusarakOgren.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zehra\source\repos\KonusarakOgren\KonusarakOgren.WebUI\Views\_ViewImports.cshtml"
using KonusarakOgren.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f251ce359add1e735ee58399986f9150fb23248", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"574de1aec701fd7ff2f0f897e74985f6d4e1b759", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KonusarakOgren.WebUI.Models.MakaleProperty>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\zehra\source\repos\KonusarakOgren\KonusarakOgren.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\zehra\source\repos\KonusarakOgren\KonusarakOgren.WebUI\Views\Home\Index.cshtml"
   
    List<string> title=Model.Makalatitle;
   


#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css\">\r\n<div class=\"container\">\r\n    <div class=\"row\"  >\r\n        <div>Makale Baslıkları</div>\r\n");
#nullable restore
#line 15 "C:\Users\zehra\source\repos\KonusarakOgren\KonusarakOgren.WebUI\Views\Home\Index.cshtml"
         for (int i = 0; i < Model.Makalatitle.Count(); i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>");
#nullable restore
#line 17 "C:\Users\zehra\source\repos\KonusarakOgren\KonusarakOgren.WebUI\Views\Home\Index.cshtml"
            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(". Makale Başlığı=></div>\r\n            <div class=\"col-sm-12\">");
#nullable restore
#line 18 "C:\Users\zehra\source\repos\KonusarakOgren\KonusarakOgren.WebUI\Views\Home\Index.cshtml"
                              Write(Model.Makalatitle[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <br />\r\n");
#nullable restore
#line 20 "C:\Users\zehra\source\repos\KonusarakOgren\KonusarakOgren.WebUI\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
   
  
</div>

<script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js""></script>
<script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"" ></script>
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.min.js""></script>
<script src=""https://code.jquery.com/jquery-3.5.1.js""></script>
<script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KonusarakOgren.WebUI.Models.MakaleProperty> Html { get; private set; }
    }
}
#pragma warning restore 1591
