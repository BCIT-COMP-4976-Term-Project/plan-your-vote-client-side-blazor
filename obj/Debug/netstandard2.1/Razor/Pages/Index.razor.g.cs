#pragma checksum "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "483202b9822a46c6a65d7faf86e6c19649d0c944"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClientSide.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\_Imports.razor"
using BlazorClientSide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\_Imports.razor"
using BlazorClientSide.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "className", "container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "className", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "className", "col-md-12");
            __builder.AddAttribute(8, "role", "main");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "section");
            __builder.AddAttribute(11, "className", "intro");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.AddMarkupContent(13, "<h1>title=\'Plan Your Vote\'</h1>\r\n                    ");
            __builder.AddMarkupContent(14, @"<p class=""section-description"">'Be prepared for the random order ballot. Choose candidates, answer
                    Capital Plan borrowing questions, and pick where and when to vote -
                    all with Plan Your Vote.'</p>
                    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "style", "background-color:" + (
#nullable restore
#line 22 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\Pages\Index.razor"
                                                  highlightYellow

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "[NEED A LINK HERE TO START-PLANNING]");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n");
#nullable restore
#line 24 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\Pages\Index.razor"
                     foreach (var bullet in bulletPlanning)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "                        ");
            __builder.OpenElement(20, "ul");
            __builder.AddContent(21, 
#nullable restore
#line 26 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\Pages\Index.razor"
                             bullet.Key

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, ".  ");
            __builder.AddContent(23, 
#nullable restore
#line 26 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\Pages\Index.razor"
                                           bullet.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 27 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "                    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "style", "background-color:" + (
#nullable restore
#line 32 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\Pages\Index.razor"
                                                  highlightYellow

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "[NEED A LINK HERE TO START-PLANNING]");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n                    <div className=\"divider\"></div>\r\n                    ");
            __builder.AddMarkupContent(30, @"<div className=""center"">
                        <div className=""intro-left"" role=""region"" aria-label=""Voter tool - Feature list:"">
                        </div>
                        <div className=""intro-right"" role=""region"" tabIndex=""-1"" aria-label=""voter tool - general flow"">
                            <img className=""intro-right-img"" src=""https://vancouver.ca/plan-your-vote/img/intro_right_legend.png"" alt=""intro"">
                            <span className=""intro-pointer candidates"">
                            Step 1 Your candidate selections
                            </span>
                            <span className=""intro-pointer capital-plan"">
                            Step 2 Your Capital Plan borrowing answers
                            </span>
                            <span className=""intro-pointer details"">
                            Step 3 Your voting day and location details
                            </span>
                            <span className=""intro-pointer checklist"">
                            Step 4 Your voting checklist
                            </span>
                        </div>
                    </div>
                <div className=""divider""></div>
                ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "className", "intro-center");
            __builder.AddAttribute(33, "role", "region");
            __builder.AddAttribute(34, "aria-label", "Important disclosures.");
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.AddMarkupContent(36, "<p>\r\n                        No personal information is needed. We don’t save or share your\r\n                        plan.\r\n                    </p>\r\n\r\n                    \r\n\r\n                    ");
            __builder.AddMarkupContent(37, "<p className=\"reassurance text-uppercase\" role=\"alert\">\r\n                        <img src=\"https://vancouver.ca/plan-your-vote/img/lock-black.jpg\" alt=\"lock icon\">\r\n                        It\'s private and confidential\r\n                    </p>\r\n");
#nullable restore
#line 88 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\Pages\Index.razor"
                     foreach (var disclaim in disclaimer)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                        ");
            __builder.OpenElement(39, "p");
            __builder.AddContent(40, 
#nullable restore
#line 90 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\Pages\Index.razor"
                            disclaim

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 91 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "                    ");
            __builder.AddMarkupContent(43, @"<p className=""to-election-site"" role=""alert"">
                        For details on voter registration, identification, and more,
                        <br>
                        <a href=""https://vancouver.ca/your-government/2018-election.aspx"" aria-label="" or details on voter registration, identification, and more, visit the full election site on vancouver.ca"">
                        visit full election site &nbsp;
                        <span className=""fas fa-chevron-right""></span>
                        </a>
                    </p>
                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "style", "background-color:" + (
#nullable restore
#line 108 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\Pages\Index.razor"
                                              highlightBlue

#line default
#line hidden
#nullable disable
            ) + ";" + " color:" + (
#nullable restore
#line 108 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\Pages\Index.razor"
                                                                    colorWhite

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(47, "[NEED A LINK HERE TO VISIT ELECTION SITE]");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\Pages\Index.razor"
       
    Dictionary<String, String> bulletPlanning = new Dictionary<String, String>() {
        { "1", "Browse candidates for mayor, councillor, Park Board commissioner, and school trustee, then add your favourites to your plan." },
        { "2", "Answer 3 Capital Plan borrowing questions about whether the City can borrow money to help pay for certain projects." },
        { "3", "`Choose from 9 voting days and over 100 locations to fit your schedule." },
        { "4", "Email your plan and add voting day details to your calendar. Your plan will show your chosen candidates in the order you’ll find them on your ballot." }
    };

    public static readonly string[] disclaimer =  
    {
        "This election tool is only intended to help you plan your vote. By using it, you are not actually casting a "+
        "vote.You still need to go to the voting location on election day to vote in person.",

        "The views expressed in the candidates' profiles are the views of the candidates, and they are not endorsed " +
        "by the City of Vancouver. The profiles are reproduced verbatim as submitted by the candidates and the" + 
        "content has not been altered in any way by the City."
    };


#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\term project\plan-your-vote-client-side-blazor\Pages\Index.razor"
       
    private string highlightYellow = "yellow";
    private string highlightBlue = "blue";
    private string colorWhite = "white";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
