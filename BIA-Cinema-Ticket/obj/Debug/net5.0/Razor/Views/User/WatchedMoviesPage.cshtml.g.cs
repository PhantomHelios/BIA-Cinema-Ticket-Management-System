#pragma checksum "C:\Users\ikrhn\OneDrive\Desktop\03-01-1\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\WatchedMoviesPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5bc9de2363a07a3b66b2ea5426888a05f2822b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_WatchedMoviesPage), @"mvc.1.0.view", @"/Views/User/WatchedMoviesPage.cshtml")]
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
#line 1 "C:\Users\ikrhn\OneDrive\Desktop\03-01-1\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\_ViewImports.cshtml"
using BIA_Cinema_Ticket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ikrhn\OneDrive\Desktop\03-01-1\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\_ViewImports.cshtml"
using BIA_Cinema_Ticket.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5bc9de2363a07a3b66b2ea5426888a05f2822b0", @"/Views/User/WatchedMoviesPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ae34280c174cbec5a0a3988b56fd2bc0bd852ee", @"/Views/_ViewImports.cshtml")]
    public class Views_User_WatchedMoviesPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:5rem;height:10rem;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\ikrhn\OneDrive\Desktop\03-01-1\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\WatchedMoviesPage.cshtml"
  
    Layout = "_User";
    List<Movie> WatchedMoviesPage = ViewBag.WatchedMoviesPage;
    string[] tableHeaders = new string[]{
        "Image","Name","Category","Duration","Director","Year","Rate","View Status","Trailer"
    };
    ViewData["Title"] = "Watched Movies Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid px-4"">
    <div class=""card mb-4 mt-4"">
        <div class=""card-header"">
            <i class=""fas fa-table me-1""></i>
            <b>List Of Watched Movies</b>
        </div>
        <div class=""card-body"">
            <div class=""table"">
                <table id=""datatablesSimple"">
                    <thead>
                        <tr>
");
#nullable restore
#line 20 "C:\Users\ikrhn\OneDrive\Desktop\03-01-1\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\WatchedMoviesPage.cshtml"
                             foreach (var table_header in tableHeaders)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <th>");
#nullable restore
#line 22 "C:\Users\ikrhn\OneDrive\Desktop\03-01-1\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\WatchedMoviesPage.cshtml"
                               Write(table_header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 23 "C:\Users\ikrhn\OneDrive\Desktop\03-01-1\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\WatchedMoviesPage.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\ikrhn\OneDrive\Desktop\03-01-1\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\WatchedMoviesPage.cshtml"
                         foreach (var movie in WatchedMoviesPage)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n");
#nullable restore
#line 31 "C:\Users\ikrhn\OneDrive\Desktop\03-01-1\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\WatchedMoviesPage.cshtml"
                                      
                                        String img_source = movie.movieName.ToLower().Replace(" ", "_") + "_" + movie.year + ".jpg";
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5bc9de2363a07a3b66b2ea5426888a05f2822b06692", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1442, "~/pic/Movie-pics/", 1442, 17, true);
#nullable restore
#line 34 "C:\Users\ikrhn\OneDrive\Desktop\03-01-1\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\WatchedMoviesPage.cshtml"
AddHtmlAttributeValue("", 1459, img_source, 1459, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 36 "C:\Users\ikrhn\OneDrive\Desktop\03-01-1\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\WatchedMoviesPage.cshtml"
                               Write(movie.movieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 38 "C:\Users\ikrhn\OneDrive\Desktop\03-01-1\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\WatchedMoviesPage.cshtml"
                               Write(movie.categories);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 40 "C:\Users\ikrhn\OneDrive\Desktop\03-01-1\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\WatchedMoviesPage.cshtml"
                               Write(movie.duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 41 "C:\Users\ikrhn\OneDrive\Desktop\03-01-1\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\WatchedMoviesPage.cshtml"
                               Write(movie.director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 42 "C:\Users\ikrhn\OneDrive\Desktop\03-01-1\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\WatchedMoviesPage.cshtml"
                               Write(movie.year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 43 "C:\Users\ikrhn\OneDrive\Desktop\03-01-1\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\WatchedMoviesPage.cshtml"
                               Write(movie.rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 44 "C:\Users\ikrhn\OneDrive\Desktop\03-01-1\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\WatchedMoviesPage.cshtml"
                               Write(movie.viewStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "C:\Users\ikrhn\OneDrive\Desktop\03-01-1\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\WatchedMoviesPage.cshtml"
                               Write(movie.trailerLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2127, "\"", 2182, 2);
            WriteAttributeValue("", 2134, "/User/AddFavoriteMovies?movie_ID=", 2134, 33, true);
#nullable restore
#line 47 "C:\Users\ikrhn\OneDrive\Desktop\03-01-1\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\WatchedMoviesPage.cshtml"
WriteAttributeValue("", 2167, movie.movie_ID, 2167, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" \r\n                                       class=\"btn btn-primary\">Add to favorites</a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 51 "C:\Users\ikrhn\OneDrive\Desktop\03-01-1\BIA-Cinema-Ticket\BIA-Cinema-Ticket\Views\User\WatchedMoviesPage.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
