#pragma checksum "C:\Users\freempire\source\repos\NovoCore\ProviderModule\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27fd4778bd803922080b3913c25dcc7aae4369c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Views_Dashboard_Index))]
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
#line 1 "C:\Users\freempire\source\repos\NovoCore\ProviderModule\Views\_ViewImports.cshtml"
using ProviderModule;

#line default
#line hidden
#line 2 "C:\Users\freempire\source\repos\NovoCore\ProviderModule\Views\_ViewImports.cshtml"
using ProviderModule.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27fd4778bd803922080b3913c25dcc7aae4369c3", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0938e0af69c6bcf04f87e9dc4547ad43f763496f", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NovoCore.ViewModel.Dashboard>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\freempire\source\repos\NovoCore\ProviderModule\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(82, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(89, 19, false);
#line 10 "C:\Users\freempire\source\repos\NovoCore\ProviderModule\Views\Dashboard\Index.cshtml"
Write(Model.Provider.Name);

#line default
#line hidden
            EndContext();
            BeginContext(108, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(117, 22, false);
#line 11 "C:\Users\freempire\source\repos\NovoCore\ProviderModule\Views\Dashboard\Index.cshtml"
Write(Model.Enrollee.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(139, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(142, 25, false);
#line 11 "C:\Users\freempire\source\repos\NovoCore\ProviderModule\Views\Dashboard\Index.cshtml"
                    Write(Model.Enrollee.Othernames);

#line default
#line hidden
            EndContext();
            BeginContext(167, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(176, 33, false);
#line 12 "C:\Users\freempire\source\repos\NovoCore\ProviderModule\Views\Dashboard\Index.cshtml"
Write(Model.Enrollee.EnrolleePassportId);

#line default
#line hidden
            EndContext();
            BeginContext(209, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(218, 27, false);
#line 13 "C:\Users\freempire\source\repos\NovoCore\ProviderModule\Views\Dashboard\Index.cshtml"
Write(Model.Enrollee.Policynumber);

#line default
#line hidden
            EndContext();
            BeginContext(245, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(254, 18, false);
#line 14 "C:\Users\freempire\source\repos\NovoCore\ProviderModule\Views\Dashboard\Index.cshtml"
Write(Model.Enrollee.Sex);

#line default
#line hidden
            EndContext();
            BeginContext(272, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(281, 21, false);
#line 15 "C:\Users\freempire\source\repos\NovoCore\ProviderModule\Views\Dashboard\Index.cshtml"
Write(Model.Staff.CompanyId);

#line default
#line hidden
            EndContext();
            BeginContext(302, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(311, 25, false);
#line 16 "C:\Users\freempire\source\repos\NovoCore\ProviderModule\Views\Dashboard\Index.cshtml"
Write(Model.Staff.StaffFullname);

#line default
#line hidden
            EndContext();
            BeginContext(336, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(345, 18, false);
#line 17 "C:\Users\freempire\source\repos\NovoCore\ProviderModule\Views\Dashboard\Index.cshtml"
Write(Model.Company.Name);

#line default
#line hidden
            EndContext();
            BeginContext(363, 27, true);
            WriteLiteral("<br />\r\nVerification Code: ");
            EndContext();
            BeginContext(391, 25, false);
#line 18 "C:\Users\freempire\source\repos\NovoCore\ProviderModule\Views\Dashboard\Index.cshtml"
              Write(ViewBag.randomLessThan100);

#line default
#line hidden
            EndContext();
            BeginContext(416, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(421, 22, false);
#line 20 "C:\Users\freempire\source\repos\NovoCore\ProviderModule\Views\Dashboard\Index.cshtml"
Write(ViewBag.submittedcount);

#line default
#line hidden
            EndContext();
            BeginContext(443, 27, true);
            WriteLiteral("\r\n\r\n\r\n<p style=\"color:red\">");
            EndContext();
            BeginContext(471, 25, false);
#line 23 "C:\Users\freempire\source\repos\NovoCore\ProviderModule\Views\Dashboard\Index.cshtml"
                Write(ViewBag.FacilitiesAllowed);

#line default
#line hidden
            EndContext();
            BeginContext(496, 30, true);
            WriteLiteral("</p>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NovoCore.ViewModel.Dashboard> Html { get; private set; }
    }
}
#pragma warning restore 1591
