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

namespace Piranha.Areas.Manager.Views.Category
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Category/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<Piranha.Models.Manager.CategoryModels.ListModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Manager\Views\Category\Index.cshtml"
  
    ViewBag.Title = @Piranha.Resources.Category.ListTitle ;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("Head", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(document).ready(function () {\r\n            // Set the selected templ" +
"ate id\r\n            $(\".delete\").click(function () {\r\n                return con" +
"firm(\"");

            
            #line 10 "..\..\Areas\Manager\Views\Category\Index.cshtml"
                           Write(Piranha.Resources.Category.MessageDeleteConfirm);

            
            #line default
            #line hidden
WriteLiteral(@""") ;
            });

            // Setup template list
            var options = {
                listClass:  'list-js',
                searchId: 'search',
                valueNames: ['name', 'updated', 'created']
            };
            var templateList = new List('list', options);
        });
    </script>
");

});

DefineSection("Toolbar", () => {

WriteLiteral(" \r\n");

            
            #line 24 "..\..\Areas\Manager\Views\Category\Index.cshtml"
Write(Html.Partial("Partial/Tabs"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"toolbar\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n        <ul>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 855), Tuple.Create("\"", 893)
            
            #line 28 "..\..\Areas\Manager\Views\Category\Index.cshtml"
, Tuple.Create(Tuple.Create("", 862), Tuple.Create<System.Object, System.Int32>(Url.Action("edit", "category")
            
            #line default
            #line hidden
, 862), false)
);

WriteLiteral(" class=\"add\"");

WriteLiteral(">");

            
            #line 28 "..\..\Areas\Manager\Views\Category\Index.cshtml"
                                                                 Write(Piranha.Resources.Global.ToolbarAdd);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteLiteral(" href=\"\"");

WriteLiteral(" class=\"refresh\"");

WriteLiteral(">");

            
            #line 29 "..\..\Areas\Manager\Views\Category\Index.cshtml"
                                      Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n        <button");

WriteLiteral(" class=\"search\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1092), Tuple.Create("\"", 1139)
            
            #line 31 "..\..\Areas\Manager\Views\Category\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1100), Tuple.Create<System.Object, System.Int32>(Piranha.Resources.Global.ToolbarSearch
            
            #line default
            #line hidden
, 1100), false)
);

WriteLiteral("></button>");

            
            #line 31 "..\..\Areas\Manager\Views\Category\Index.cshtml"
                                                                                   Write(Html.TextBox("search"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>\r\n");

});

WriteLiteral("<div");

WriteLiteral(" class=\"grid_12\"");

WriteLiteral(">\r\n    <table");

WriteLiteral(" id=\"list\"");

WriteLiteral(" class=\"list\"");

WriteLiteral(">\r\n        <thead>\r\n            <tr>\r\n                <th><span");

WriteLiteral(" class=\"sort asc\"");

WriteLiteral(" data-sort=\"name\"");

WriteLiteral(">");

            
            #line 40 "..\..\Areas\Manager\Views\Category\Index.cshtml"
                                                       Write(Piranha.Resources.Global.Name);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th");

WriteLiteral(" class=\"date\"");

WriteLiteral("><span");

WriteLiteral(" class=\"sort\"");

WriteLiteral(" data-sort=\"updated\"");

WriteLiteral(">");

            
            #line 41 "..\..\Areas\Manager\Views\Category\Index.cshtml"
                                                                   Write(Piranha.Resources.Global.Updated);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th");

WriteLiteral(" class=\"date\"");

WriteLiteral("><span");

WriteLiteral(" class=\"sort\"");

WriteLiteral(" data-sort=\"created\"");

WriteLiteral(">");

            
            #line 42 "..\..\Areas\Manager\Views\Category\Index.cshtml"
                                                                   Write(Piranha.Resources.Global.Created);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th");

WriteLiteral(" class=\"one\"");

WriteLiteral("></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody");

WriteLiteral(" class=\"list-js\"");

WriteLiteral(">\r\n");

            
            #line 47 "..\..\Areas\Manager\Views\Category\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 47 "..\..\Areas\Manager\Views\Category\Index.cshtml"
             foreach (var pc in Model.Categories) {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td");

WriteAttribute("class", Tuple.Create(" class=\"", 1868), Tuple.Create("\"", 1922)
, Tuple.Create(Tuple.Create("", 1876), Tuple.Create("name", 1876), true)
            
            #line 49 "..\..\Areas\Manager\Views\Category\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1880), Tuple.Create<System.Object, System.Int32>(pc.Level > 1 ? " level" + pc.Level : ""
            
            #line default
            #line hidden
, 1880), false)
);

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1926), Tuple.Create("\"", 1983)
            
            #line 49 "..\..\Areas\Manager\Views\Category\Index.cshtml"
    , Tuple.Create(Tuple.Create("", 1933), Tuple.Create<System.Object, System.Int32>(Url.Action("edit", "category", new { id = pc.Id})
            
            #line default
            #line hidden
, 1933), false)
);

WriteLiteral(">");

            
            #line 49 "..\..\Areas\Manager\Views\Category\Index.cshtml"
                                                                                                                                   Write(pc.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                <td");

WriteLiteral(" class=\"updated\"");

WriteLiteral(">");

            
            #line 50 "..\..\Areas\Manager\Views\Category\Index.cshtml"
                               Write(pc.Updated.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"created\"");

WriteLiteral(">");

            
            #line 51 "..\..\Areas\Manager\Views\Category\Index.cshtml"
                               Write(pc.Created.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"buttons\"");

WriteLiteral(">\r\n");

            
            #line 53 "..\..\Areas\Manager\Views\Category\Index.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 53 "..\..\Areas\Manager\Views\Category\Index.cshtml"
                     if (pc.Categories.Count == 0) {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteLiteral(" class=\"icon delete\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2292), Tuple.Create("\"", 2352)
            
            #line 54 "..\..\Areas\Manager\Views\Category\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2299), Tuple.Create<System.Object, System.Int32>(Url.Action("delete", "category", new { id = pc.Id })
            
            #line default
            #line hidden
, 2299), false)
);

WriteLiteral("></a>\r\n");

            
            #line 55 "..\..\Areas\Manager\Views\Category\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n            </tr>\r\n");

            
            #line 58 "..\..\Areas\Manager\Views\Category\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td");

WriteLiteral(" colspan=\"5\"");

WriteLiteral("></td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
