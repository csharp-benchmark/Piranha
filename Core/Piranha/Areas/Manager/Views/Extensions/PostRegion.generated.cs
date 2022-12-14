#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Piranha.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Extensions/PostRegion.cshtml")]
    public partial class PostRegion : System.Web.Mvc.WebViewPage<Piranha.Extend.Regions.PostRegion>
    {
        public PostRegion()
        {
        }
        public override void Execute()
        {
WriteLiteral("<ul");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n    <li>\r\n");

WriteLiteral("        ");

            
            #line 4 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
   Write(Html.LabelFor(m => m.PostTemplateId));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 6 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
       Write(Html.DropDownListFor(m => m.PostTemplateId, Model.TemplateTypes));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("        ");

            
            #line 7 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
   Write(Html.ValidationMessageFor(m => m.PostTemplateId));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </li>\r\n    <li>\r\n");

WriteLiteral("        ");

            
            #line 10 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
   Write(Html.LabelFor(m => m.OrderBy));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 12 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
       Write(Html.DropDownListFor(m => m.OrderBy, Model.OrderByTypes));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("        ");

            
            #line 13 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
   Write(Html.ValidationMessageFor(m => m.OrderBy));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </li>\r\n    <li>\r\n");

WriteLiteral("        ");

            
            #line 16 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
   Write(Html.LabelFor(m => m.Take));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 18 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
       Write(Html.TextBoxFor(m => m.Take));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("        ");

            
            #line 19 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
   Write(Html.ValidationMessageFor(m => m.Take));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </li>\r\n    <li>\r\n");

WriteLiteral("        ");

            
            #line 22 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
   Write(Html.LabelFor(m => m.Cache));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 24 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
       Write(Html.TextBoxFor(m => m.Cache));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("        ");

            
            #line 25 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
   Write(Html.ValidationMessageFor(m => m.Cache));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </li>\r\n    <li>\r\n        <label>");

            
            #line 28 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
          Write(Piranha.Resources.Extensions.PostRegionInclude);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n        <p>");

            
            #line 29 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
      Write(Html.CheckBoxFor(m => m.IncludeCategories));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 29 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
                                                  Write(Piranha.Resources.Extensions.PostRegionIncludeCategories);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <p>");

            
            #line 30 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
      Write(Html.CheckBoxFor(m => m.IncludeTemplate));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 30 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
                                                Write(Piranha.Resources.Extensions.PostRegionIncludeTemplate);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <p>");

            
            #line 31 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
      Write(Html.CheckBoxFor(m => m.IncludeCreatedBy));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 31 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
                                                 Write(Piranha.Resources.Extensions.PostRegionIncludeCreatedBy);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <p>");

            
            #line 32 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
      Write(Html.CheckBoxFor(m => m.IncludeUpdatedBy));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 32 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
                                                 Write(Piranha.Resources.Extensions.PostRegionIncludeUpdatedBy);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n    </li>\r\n</ul>\r\n<div");

WriteLiteral(" class=\"title\"");

WriteLiteral(" style=\"border-top: 1px solid #ddd\"");

WriteLiteral("><h2>");

            
            #line 35 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
                                                     Write(Piranha.Resources.Extensions.PostRegionMatchingTitle);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n<table");

WriteLiteral(" class=\"list attachments\"");

WriteLiteral(">\r\n    <tr>\r\n        <td><span><strong>");

            
            #line 38 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
                     Write(Piranha.Resources.Global.Title);

            
            #line default
            #line hidden
WriteLiteral("</strong></span></td>\r\n        <td><strong>");

            
            #line 39 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
               Write(Piranha.Resources.Post.Template);

            
            #line default
            #line hidden
WriteLiteral("</strong></td>\r\n        <td");

WriteLiteral(" class=\"date\"");

WriteLiteral("><strong>");

            
            #line 40 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
                            Write(Piranha.Resources.Global.Published);

            
            #line default
            #line hidden
WriteLiteral("</strong></td>\r\n        <td");

WriteLiteral(" class=\"date\"");

WriteLiteral(" style=\"white-space:nowrap\"");

WriteLiteral("><strong>");

            
            #line 41 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
                                                       Write(Piranha.Resources.Global.LastPublished);

            
            #line default
            #line hidden
WriteLiteral("</strong></td>\r\n    </tr>\r\n");

            
            #line 43 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
    
            
            #line default
            #line hidden
            
            #line 43 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
     foreach (var post in Model.Posts) {

            
            #line default
            #line hidden
WriteLiteral("    <tr>\r\n        <td><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2050), Tuple.Create("\"", 2106)
            
            #line 45 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
, Tuple.Create(Tuple.Create("", 2057), Tuple.Create<System.Object, System.Int32>(Url.Action("edit", "post", new { id = post.Id })
            
            #line default
            #line hidden
, 2057), false)
);

WriteLiteral(">");

            
            #line 45 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
                                                                   Write(post.Title);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n        <td>");

            
            #line 46 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
       Write(post.Template.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n        <td");

WriteLiteral(" class=\"date\"");

WriteLiteral(">");

            
            #line 47 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
                    Write(post.Published.Value.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n        <td");

WriteLiteral(" class=\"date\"");

WriteLiteral(">");

            
            #line 48 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
                    Write(post.LastPublished.Value.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n    </tr>\r\n");

            
            #line 50 "..\..\Areas\Manager\Views\Extensions\PostRegion.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</table>");

        }
    }
}
#pragma warning restore 1591
