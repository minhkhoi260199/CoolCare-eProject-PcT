#pragma checksum "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7db6661118e71a813b06d411602e789e221d2f84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_Index), @"mvc.1.0.view", @"/Views/Request/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7db6661118e71a813b06d411602e789e221d2f84", @"/Views/Request/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    public class Views_Request_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "medical", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "request", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""p-t-20"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <!-- DATA TABLE -->
                <h1 class=""title-5 m-b-35"" style=""margin-bottom:10px;"">Choose policy to make request</h1>
                <div class=""table-responsive table-responsive-data2"">
                    <table class=""table table-borderless table-data3"">
                        <thead>
                            <tr>
                                <th>No</th>
                                <th>Policy Name</th>
                                <th>Amount</th>
                                <th>Emi</th>
                                <th>Duration</th>
                                <th>Mecical</th>
                                <th>Insurance Company</th>
                                <th>Hospital</th>
                                <th>Status</th>
                                <th>Action</th>
                            </tr>
          ");
            WriteLiteral("              </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 30 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                               var i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                             foreach (var policy in ViewBag.emppolicies)
                            {
                                i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 35 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 36 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                   Write(policy.Policy.PolicyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 37 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                   Write(policy.Policy.Amount.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" vnd</td>\r\n                                    <td>");
#nullable restore
#line 38 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                   Write(policy.Policy.Emi.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" vnd</td>\r\n                                    <td>");
#nullable restore
#line 39 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                   Write(policy.Policy.PolicyDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 40 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                   Write(policy.Policy.Medical.MedicalName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7db6661118e71a813b06d411602e789e221d2f849317", async() => {
                WriteLiteral("\r\n                                            ");
#nullable restore
#line 43 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                       Write(policy.Policy.Medical.Company.CompanyName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            WriteLiteral("#smallmodal");
#nullable restore
#line 42 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
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
#line 42 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                                                                               WriteLiteral(policy.Policy.Medical.Company.Id);

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
            WriteLiteral("\r\n\r\n                                        <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2240, "\"", 2259, 2);
            WriteAttributeValue("", 2245, "smallmodal", 2245, 10, true);
#nullable restore
#line 46 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
WriteAttributeValue("", 2255, i, 2255, 4, false);

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
#line 50 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                                                                                Write(policy.Policy.Medical.Company.CompanyName);

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
#line 57 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                                                        Write(policy.Policy.Medical.Company.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                                                            <b>Phone: </b> ");
#nullable restore
#line 58 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                                                      Write(policy.Policy.Medical.Company.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                                                            <b>Url: </b> <a");
            BeginWriteAttribute("href", " href=\"", 3562, "\"", 3610, 1);
#nullable restore
#line 59 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
WriteAttributeValue("", 3569, policy.Policy.Medical.Company.CompanyUrl, 3569, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 59 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                                                                                                        Write(policy.Policy.Medical.Company.CompanyUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a><br>
                                                        </p>
                                                    </div>
                                                    <div class=""modal-footer"">
                                                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7db6661118e71a813b06d411602e789e221d2f8416617", async() => {
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
#line 64 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                                                                                                                               WriteLiteral(policy.Policy.Medical.Company.Id);

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
            WriteLiteral(@"
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </td>
                                    <td>");
#nullable restore
#line 70 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                   Write(policy.Policy.Medical.Hospital.HospitalName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n");
#nullable restore
#line 72 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                         if(policy.StatusId != null){
                                            switch(policy.StatusId){
                                                case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"color:orange\">");
#nullable restore
#line 74 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                                                              Write(policy.Status.StatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 75 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                                break;
                                                case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"color:green\">");
#nullable restore
#line 76 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                                                             Write(policy.Status.StatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 77 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                                break;
                                                case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"color:red\">");
#nullable restore
#line 78 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                                                           Write(policy.Status.StatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 79 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                                break;
                                                case 4:

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"color:red\">");
#nullable restore
#line 80 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                                                           Write(policy.Status.StatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 81 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                                break;
                                            }
                                        } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span style=\"color:red\">Errol</span>\r\n");
#nullable restore
#line 85 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n                                        <div class=\"table-data-feature\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7db6661118e71a813b06d411602e789e221d2f8423939", async() => {
                WriteLiteral(@"
                                                <button class=""item"" data-toggle=""tooltip"" data-placement=""top"" title=""Bill request"">
                                                    <i class=""zmdi zmdi-mail-send""> </i>
                                                </button>
                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
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
            WriteLiteral("\r\n                                        </div>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 97 "/home/coollahn/Documents/Aptech/SEM3-eProject/SEM3-eProject-PcT/HealthInsuranceMgmt/HealthInsuranceMgmt/Views/Request/Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"spacer\"></tr>\r\n                            </tbody>\r\n                    </table>\r\n                </div>\r\n                <hr>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
