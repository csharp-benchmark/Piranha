#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Template/PageEdit.cshtml")]
    public partial class _Areas_Manager_Views_Template_PageEdit_cshtml : System.Web.Mvc.WebViewPage<Piranha.Models.Manager.TemplateModels.PageEditModel>
    {
        public _Areas_Manager_Views_Template_PageEdit_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
  
    ViewBag.Selected = "Settings" ;
    ViewBag.SelectedTab = "PageType" ;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("Head", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 195), Tuple.Create("\"", 255)
, Tuple.Create(Tuple.Create("", 201), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/js/jquery.template.js")
, 201), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 302), Tuple.Create("\"", 368)
, Tuple.Create(Tuple.Create("", 308), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/js/jquery.regiontemplate.js")
, 308), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 415), Tuple.Create("\"", 469)
, Tuple.Create(Tuple.Create("", 421), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/js/ext/json2.js")
, 421), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        /**\r\n         * This var is needed by the regiontemplate script.\r\n    " +
"     */\r\n        var templateid = \'");

            
            #line 14 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                     Write(Model.Template.Id);

            
            #line default
            #line hidden
WriteLiteral(@"';

        $(document).ready(function () {
        	$('#Template_Name').focus();

        	$('#isblock input').change(function () {
        		if ($(this).is(':checked')) {
        			$('#subpages').hide();
        			$('#blocktypes').show();
				} else {
        			$('#subpages').show();
        			$('#blocktypes').hide();
				}
        	});
        });
    </script>
");

            
            #line 30 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 30 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
     if (Model.Template.IsLocked) {

            
            #line default
            #line hidden
WriteLiteral("    <style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\n        .region-editor .icon {\r\n            display: none;\r\n        }\r\n       " +
" .region-editor tr.dark {\r\n            display: none;\r\n        }\r\n    </style>\r\n" +
"");

            
            #line 39 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
    }

            
            #line default
            #line hidden
});

DefineSection("Toolbar", () => {

WriteLiteral("\r\n");

            
            #line 42 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.Partial("Partial/Tabs"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"toolbar\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n        <ul>\r\n");

            
            #line 46 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
            
            
            #line default
            #line hidden
            
            #line 46 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
             if (!Model.Template.IsLocked) {

            
            #line default
            #line hidden
WriteLiteral("            <li><a");

WriteLiteral(" class=\"save submit\"");

WriteLiteral(">");

            
            #line 47 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                  Write(Piranha.Resources.Global.ToolbarSave);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

WriteLiteral("            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1535), Tuple.Create("\"", 1599)
            
            #line 48 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
, Tuple.Create(Tuple.Create("", 1542), Tuple.Create<System.Object, System.Int32>(Url.Action("deletepage", new { id = Model.Template.Id })
            
            #line default
            #line hidden
, 1542), false)
);

WriteLiteral(" class=\"delete\"");

WriteLiteral(" title=\"\"");

WriteLiteral(">");

            
            #line 48 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                                                                                       Write(Piranha.Resources.Global.ToolbarDelete);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 49 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1708), Tuple.Create("\"", 1738)
            
            #line 50 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
, Tuple.Create(Tuple.Create("", 1715), Tuple.Create<System.Object, System.Int32>(Url.Action("pagelist")
            
            #line default
            #line hidden
, 1715), false)
);

WriteLiteral(" class=\"back\"");

WriteLiteral(">");

            
            #line 50 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                                          Write(Piranha.Resources.Global.ToolbarBack);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1819), Tuple.Create("\"", 1877)
            
            #line 51 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
, Tuple.Create(Tuple.Create("", 1826), Tuple.Create<System.Object, System.Int32>(Url.Action("page", new { id = Model.Template.Id })
            
            #line default
            #line hidden
, 1826), false)
);

WriteLiteral(" class=\"refresh\"");

WriteLiteral(">");

            
            #line 51 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                                                                         Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n        <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>\r\n");

});

WriteLiteral("\r\n");

            
            #line 58 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
   Html.BeginForm("page", "template") ; 
            
            #line default
            #line hidden
WriteLiteral("\r\n<div>\r\n");

WriteLiteral("    ");

            
            #line 60 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 61 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.IsNew));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 62 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.IsSiteTemplate));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 63 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.Type));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 64 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.Created));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 65 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.Updated));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 66 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.CreatedBy));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 67 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.UpdatedBy));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 68 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 68 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
     if (!Piranha.Application.Current.IsMvc) {
    
            
            #line default
            #line hidden
            
            #line 69 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.View));

            
            #line default
            #line hidden
            
            #line 69 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                         
    
            
            #line default
            #line hidden
            
            #line 70 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.ShowView));

            
            #line default
            #line hidden
            
            #line 70 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                             
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n<div");

WriteLiteral(" class=\"grid_9\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"box expandable\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 75 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                          Write(Piranha.Resources.Global.Information);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                <li>");

            
            #line 78 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 80 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.Template.Name));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                    ");

            
            #line 81 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Template.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li>");

            
            #line 83 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 85 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.TextAreaFor(m => m.Template.Description, 
                            new { @placeholder = Piranha.Resources.Global.Optional }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </li>\r\n            </ul>\r\n            <ul");

WriteLiteral(" class=\"form optional\"");

WriteLiteral(">               \r\n                <li>");

            
            #line 90 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.Preview));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 92 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.TextAreaFor(m => m.Template.Preview, new { @rows = 8} ));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </li>                \r\n            </ul>\r\n        </div>\r" +
"\n    </div>\r\n    <div");

WriteLiteral(" class=\"box content-editor\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 98 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                          Write(Piranha.Resources.Global.Regions);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <table");

WriteLiteral(" class=\"list region-editor\"");

WriteLiteral(">\r\n                <tbody>\r\n                    <tr>\r\n                        <th" +
">");

            
            #line 103 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                       Write(Piranha.Resources.Global.Name);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        <th>");

            
            #line 104 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                       Write(Piranha.Resources.Global.InternalId);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        <th>");

            
            #line 105 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                       Write(Piranha.Resources.Global.Type);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n");

WriteLiteral("                    ");

            
            #line 108 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.EditorFor(m => m.Regions));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <tr");

WriteLiteral(" class=\"dark\"");

WriteLiteral(">\r\n                        <td");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"newregionName\"");

WriteLiteral(" /></div>\r\n                        </td>\r\n                        <td");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"newregionInternalId\"");

WriteLiteral(" /></div>\r\n                        </td>\r\n                        <td");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 120 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                           Write(Html.DropDownList("newregionType",
                                    new SelectList(Model.RegionTypes, "Type", "Name")));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        </td>\r\n                        <td");

WriteLiteral(" class=\"buttons four\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" id=\"btnAddRegion\"");

WriteLiteral(" class=\"btn marg-big\"");

WriteLiteral(">");

            
            #line 124 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                                                      Write(Piranha.Resources.Global.Add);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                        </td>\r\n                    </tr>\r\n            " +
"    </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 132 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                          Write(Piranha.Resources.Global.Advanced);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                <li>");

            
            #line 135 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.Controller, 
                        Piranha.Application.Current.IsMvc ? Piranha.Resources.Page.Route : Piranha.Resources.Page.Template));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 138 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.Template.Controller, 
                            new { @placeholder = "Page" }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <label>&nbsp;</label>\r\n                    <p>");

            
            #line 141 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                  Write(Html.CheckBoxFor(m => m.Template.ShowController));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 142 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                    Write(Piranha.Application.Current.IsMvc ? Piranha.Resources.Template.PageRouteOverride : Piranha.Resources.Template.PageTemplateOverride);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </li>\r\n");

            
            #line 144 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 144 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                 if (Piranha.Application.Current.IsMvc) {

            
            #line default
            #line hidden
WriteLiteral("                <li>");

            
            #line 145 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.View));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 147 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.Template.View, new { @placeholder = "Index" }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <label>&nbsp;</label>\r\n                    <p>");

            
            #line 149 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                  Write(Html.CheckBoxFor(m => m.Template.ShowView));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 149 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                                              Write(Piranha.Resources.Template.PageViewOverride);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </li>\r\n");

            
            #line 151 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <li>");

            
            #line 152 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.Redirect));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 154 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.Template.Redirect, 
                            new { @placeholder = Piranha.Resources.Global.Optional }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <label>&nbsp;</label>\r\n                    <p>");

            
            #line 157 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                  Write(Html.CheckBoxFor(m => m.Template.ShowRedirect));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 157 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                                                  Write(Piranha.Resources.Template.PageRedirectOverride);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </li>\r\n\t\t\t\t<li");

WriteLiteral(" id=\"isblock\"");

WriteLiteral(">");

            
            #line 159 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                            Write(Html.LabelFor(m => m.Template.IsBlock));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t<p>\r\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 161 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.CheckBoxFor(m => m.Template.IsBlock));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 161 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                                              Write(Piranha.Resources.Template.IsBlockDescription);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t</p>\r\n\t\t\t\t</li>\r\n\t\t\t\t<li");

WriteLiteral(" id=\"blocktypes\"");

WriteLiteral(" ");

            
            #line 164 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                Write(!Model.Template.IsBlock ? "style=display:none" : "");

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t");

            
            #line 165 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.BlockTypes));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t<div");

WriteLiteral(" class=\"block\"");

WriteLiteral(">\r\n");

            
            #line 167 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
						
            
            #line default
            #line hidden
            
            #line 167 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                         foreach (var t in Model.Templates) {

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t\t<div");

WriteLiteral(" class=\"half left\"");

WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<p");

WriteLiteral(" class=\"checkbox\"");

WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t<input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"Template_BlockTypes\"");

WriteLiteral(" name=\"Template.BlockTypes\"");

WriteAttribute("value", Tuple.Create(" value=\"", 7584), Tuple.Create("\"", 7597)
            
            #line 170 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                      , Tuple.Create(Tuple.Create("", 7592), Tuple.Create<System.Object, System.Int32>(t.Id
            
            #line default
            #line hidden
, 7592), false)
);

WriteLiteral(" ");

            
            #line 170 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                                                                                                         Write(Model.Template.BlockTypes.Contains(t.Id) ? "checked=checked" : "");

            
            #line default
            #line hidden
WriteLiteral("> ");

            
            #line 170 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                                                                                                                                                                              Write(t.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t\t</div>\r\n");

            
            #line 173 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
						}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t</li>\r\n\t\t\t\t<li");

WriteLiteral(" id=\"subpages\"");

WriteLiteral(" ");

            
            #line 176 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                              Write(Model.Template.IsBlock ? "style=display:none" : "");

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t");

            
            #line 177 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.Subpages));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t<p>\r\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 179 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.CheckBoxFor(m => m.Template.Subpages));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 179 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                                               Write(Piranha.Resources.Template.SubpagesDescription);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t</p>\r\n\t\t\t\t</li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n<d" +
"iv");

WriteLiteral(" class=\"grid_3\"");

WriteLiteral(">\r\n");

            
            #line 187 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 187 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
     if (!Model.Template.IsNew && !String.IsNullOrEmpty(Model.Template.Preview.ToHtmlString())) {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"box pagetemplate\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 189 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                          Write(Piranha.Resources.Page.HtmlPreview);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"edit\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 192 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
           Write(Model.Template.Preview);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");

            
            #line 196 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 198 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                          Write(Piranha.Resources.Global.Properties);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"region_data\"");

WriteLiteral("></div>\r\n            <ul");

WriteLiteral(" id=\"properties\"");

WriteLiteral(" class=\"list buttons\"");

WriteLiteral(">\r\n");

            
            #line 202 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 202 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                 foreach (var property in Model.Template.Properties) {

            
            #line default
            #line hidden
WriteLiteral("                <li><span>");

            
            #line 203 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                     Write(property);

            
            #line default
            #line hidden
WriteLiteral("</span><button");

WriteLiteral(" class=\"btn delete right remove-region\"");

WriteLiteral("></button></li>\r\n");

            
            #line 204 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </ul>\r\n            <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" id=\"po_name\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 8968), Tuple.Create("\"", 9029)
            
            #line 207 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
, Tuple.Create(Tuple.Create("", 8982), Tuple.Create<System.Object, System.Int32>(Piranha.Resources.Template.PropertyPlaceholder
            
            #line default
            #line hidden
, 8982), false)
);

WriteLiteral(" /></div>\r\n            <button");

WriteLiteral(" id=\"po_add\"");

WriteLiteral(" class=\"btn right\"");

WriteLiteral(">");

            
            #line 208 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                             Write(Piranha.Resources.Global.Add);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n            <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n         </div>\r\n    </div>\r\n</div>\r\n");

            
            #line 213 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
   Html.EndForm() ; 
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
