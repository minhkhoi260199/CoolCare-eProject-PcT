<<<<<<< HEAD
#pragma checksum "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Policy/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1565adeabfde79ebebdb236b32728cff75c93f29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Policy_Index), @"mvc.1.0.view", @"/Views/Policy/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1565adeabfde79ebebdb236b32728cff75c93f29", @"/Views/Policy/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    public class Views_Policy_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-lg btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "auth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Policy/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 7 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Policy/Index.cshtml"
 foreach (var policy in ViewBag.policies)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-6\">\r\n\r\n        <div class=\"card\">\r\n\r\n            <div class=\"card-header\">\r\n\r\n                <strong class=\"card-title\">");
#nullable restore
#line 15 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Policy/Index.cshtml"
                                      Write(policy.PolicyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <div class=\"alert alert-success\" role=\"alert\">\r\n\r\n                    <h4 class=\"alert-heading\">Policies</h4>\r\n                    <p>\r\n                        ");
#nullable restore
#line 22 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Policy/Index.cshtml"
                   Write(policy.PolicyDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <hr>\r\n                    <p class=\"mb-0\">\r\n                        <a>Amount: </a> ");
#nullable restore
#line 26 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Policy/Index.cshtml"
                                   Write(policy.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                        <a>Emi: </a> ");
#nullable restore
#line 27 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Policy/Index.cshtml"
                                Write(policy.Emi);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                        <a>Duration(months): </a> ");
#nullable restore
#line 28 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Policy/Index.cshtml"
                                             Write(policy.PolicyDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                    </p>\r\n                </div>\r\n            </div>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1565adeabfde79ebebdb236b32728cff75c93f296915", async() => {
                WriteLiteral("Register");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n         </div>\r\n    </div>\r\n");
#nullable restore
#line 37 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Policy/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
=======
#pragma checksum "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e05ff01dc2f80bc4c93a07fbe917b5db2bc235f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Policy_Index), @"mvc.1.0.view", @"/Views/Policy/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e05ff01dc2f80bc4c93a07fbe917b5db2bc235f7", @"/Views/Policy/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    public class Views_Policy_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "medical", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-lg btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "policiesonemployees", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""table-responsive table-responsive-data2"">
    <table class=""table table-data2"">
        <thead>
            <tr>
                <th>No</th>
                <th>Policy Name</th>
                <th>Hospital</th>
                <th>Amount</th>
                <th>Emi</th>
                <th>Duration</th>
                <th>Mecical</th>
                <th>Insurance Company</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
               var i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
             foreach (var policy in ViewBag.policies)
            {
                i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 27 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
                   Write(policy.PolicyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
                   Write(policy.Medical.Hospital.HospitalName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
                   Write(policy.Amount.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" vnd</td>\r\n                    <td>");
#nullable restore
#line 31 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
                   Write(policy.Emi.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" vnd</td>\r\n                    <td>");
#nullable restore
#line 32 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
                   Write(policy.PolicyDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
                   Write(policy.Medical.MedicalName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e05ff01dc2f80bc4c93a07fbe917b5db2bc235f79032", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 36 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
                       Write(policy.Medical.Company.CompanyName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            WriteLiteral("#smallmodal");
#nullable restore
#line 35 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
                                                                   Write(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-target", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
                                                                               WriteLiteral(policy.Medical.Company.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 1407, "\"", 1426, 2);
            WriteAttributeValue("", 1412, "smallmodal", 1412, 10, true);
#nullable restore
#line 39 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
WriteAttributeValue("", 1422, i, 1422, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""smallmodalLabel"" aria-hidden=""true"">
                            <div class=""modal-dialog modal-sm"" role=""document"">
                                <div class=""modal-content"">
                                    <div class=""modal-header"">
                                        <h5 class=""modal-title"" id=""smallmodalLabel"">");
#nullable restore
#line 43 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
                                                                                Write(policy.Medical.Company.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                            <span aria-hidden=""true"">&times;</span>
                                        </button>
                                    </div>
                                    <div class=""modal-body"">
                                        <p>
                                            <b>Address: </b> ");
#nullable restore
#line 50 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
                                                        Write(policy.Medical.Company.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                                            <b>Phone: </b> ");
#nullable restore
#line 51 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
                                                      Write(policy.Medical.Company.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                                            <b>Url: </b> <a");
            BeginWriteAttribute("href", " href=\"", 2500, "\"", 2541, 1);
#nullable restore
#line 52 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
WriteAttributeValue("", 2507, policy.Medical.Company.CompanyUrl, 2507, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 52 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
                                                                                                 Write(policy.Medical.Company.CompanyUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a><br>
                                        </p>
                                    </div>
                                    <div class=""modal-footer"">
                                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e05ff01dc2f80bc4c93a07fbe917b5db2bc235f715813", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
                                                                                                                               WriteLiteral(policy.Medical.Company.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e05ff01dc2f80bc4c93a07fbe917b5db2bc235f718721", async() => {
                WriteLiteral("Register");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
                                                                                                                                            WriteLiteral(policy.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 67 "E:\Aptech_HK3\SEM3-eProject-clone\SEM3-eProject-PcT\HealthInsuranceMgmt\HealthInsuranceMgmt\Views\Policy\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"spacer\"></tr>\r\n            </tbody>\r\n    </table>\r\n</div>\r\n");
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
>>>>>>> Trang
