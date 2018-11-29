#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.SearchResults
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
    
    #line 3 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Frontend.Search.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 7 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Libraries.Model;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Modules.Libraries;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/SearchResults/SearchResults.cshtml")]
    public partial class SearchResults : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Search.Mvc.Models.ISearchResultsModel>
    {
        public SearchResults()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 310), Tuple.Create("\"", 334)
            
            #line 9 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create(" ", 318), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 319), false)
);

WriteLiteral(">\n\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"col-md-8\"");

WriteLiteral(">\n");

            
            #line 13 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 13 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                 if (@Model.Results.TotalCount > 0)
                {
                if(ViewBag.IsFilteredbyPermission)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <h1>");

            
            #line 17 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                   Write(Html.Raw(Model.ResultText));

            
            #line default
            #line hidden
WriteLiteral("</h1>\n");

            
            #line 18 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <h1>");

            
            #line 21 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                   Write(Model.Results.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 21 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                             Write(Html.Raw(Model.ResultText));

            
            #line default
            #line hidden
WriteLiteral("</h1>\n");

            
            #line 22 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                <h1>");

            
            #line 26 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
               Write(Html.Resource("No"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 26 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                    Write(Html.Raw(Model.ResultText));

            
            #line default
            #line hidden
WriteLiteral("</h1>\n");

            
            #line 27 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("        </div>\n        <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(">\n");

            
            #line 30 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 30 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
             if (Model.AllowSorting && @Model.Results.TotalCount > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <label>");

            
            #line 32 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                  Write(Html.Resource("SortBy"));

            
            #line default
            #line hidden
WriteLiteral("\n                    <select");

WriteLiteral(" class=\"userSortDropdown\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1124), Tuple.Create("\"", 1162)
            
            #line 33 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1132), Tuple.Create<System.Object, System.Int32>(Html.Resource("SortDropdown")
            
            #line default
            #line hidden
, 1132), false)
);

WriteLiteral(">\n                        <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1196), Tuple.Create("\"", 1229)
            
            #line 34 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1204), Tuple.Create<System.Object, System.Int32>(OrderByOptions.Relevance
            
            #line default
            #line hidden
, 1204), false)
);

WriteLiteral(" ");

            
            #line 34 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                              Write(Model.OrderBy == OrderByOptions.Relevance ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 34 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                                     Write(Html.Resource("Relevance"));

            
            #line default
            #line hidden
WriteLiteral("</option>\n                        <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1371), Tuple.Create("\"", 1401)
            
            #line 35 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1379), Tuple.Create<System.Object, System.Int32>(OrderByOptions.Newest
            
            #line default
            #line hidden
, 1379), false)
);

WriteLiteral(" ");

            
            #line 35 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                           Write(Model.OrderBy == OrderByOptions.Newest ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 35 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                               Write(Html.Resource("NewestFirst"));

            
            #line default
            #line hidden
WriteLiteral("</option>\n                        <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1542), Tuple.Create("\"", 1572)
            
            #line 36 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1550), Tuple.Create<System.Object, System.Int32>(OrderByOptions.Oldest
            
            #line default
            #line hidden
, 1550), false)
);

WriteLiteral(" ");

            
            #line 36 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                           Write(Model.OrderBy == OrderByOptions.Oldest ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 36 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                               Write(Html.Resource("OldestFirst"));

            
            #line default
            #line hidden
WriteLiteral("</option>\n                    </select>\n                </label>\n");

            
            #line 39 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\n    </div>\n\n");

            
            #line 43 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 43 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
     if (Model.Languages.Length > 1)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div>\n            <span>");

            
            #line 46 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
             Write(Html.Resource("ChangeResultsLanguageLabel"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\n");

            
            #line 47 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 47 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
             for (var i = 0; i < Model.Languages.Length; i++)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2000), Tuple.Create("\"", 2083)
            
            #line 49 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2007), Tuple.Create<System.Object, System.Int32>(String.Format(ViewBag.LanguageSearchUrlTemplate, Model.Languages[i].Name)
            
            #line default
            #line hidden
, 2007), false)
);

WriteLiteral(">");

            
            #line 49 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                  Write(Model.Languages[i].DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a>\n");

            
            #line 50 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                if (i < Model.Languages.Length - 2)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <span>, </span>\n");

            
            #line 53 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }
                else if (i == Model.Languages.Length - 2)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <span> ");

            
            #line 56 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                      Write(Html.Resource("OrLabel"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\n");

            
            #line 57 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\n");

            
            #line 60 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    }   

            
            #line default
            #line hidden
WriteLiteral("             \n    <div");

WriteLiteral(" class=\"sf-search-results media-list\"");

WriteLiteral(">\n");

            
            #line 63 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
        
            
            #line default
            #line hidden
            
            #line 63 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
         foreach (var item in Model.Results.Data)
        {
            var hasLink = item.GetValue("Link") != null && !String.IsNullOrEmpty(item.GetValue("Link").ToString());

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"media sf-media\"");

WriteLiteral(">\n\n");

            
            #line 68 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 68 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
             if (((Telerik.Sitefinity.Services.Search.Model.Document)item).ItemType.ToString() == typeof(Telerik.Sitefinity.Libraries.Model.Image).ToString())
            {
    

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"media-left sf-img-thmb\"");

WriteLiteral(">\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2962), Tuple.Create("\"", 2991)
            
            #line 72 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2969), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 2969), false)
);

WriteLiteral(">\n                    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 3018), Tuple.Create("\"", 3046)
            
            #line 73 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3024), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 3024), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 3047), Tuple.Create("\"", 3076)
            
            #line 73 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3053), Tuple.Create<System.Object, System.Int32>(item.GetValue("Title")
            
            #line default
            #line hidden
, 3053), false)
);

WriteLiteral(" width=\"120\"");

WriteLiteral("/>\n                </a>\n            </div>\n");

            
            #line 76 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            }

            else if (((Telerik.Sitefinity.Services.Search.Model.Document)item).ItemType.ToString() == typeof(Telerik.Sitefinity.Libraries.Model.Video).ToString())
            {
                LibrariesManager librariesManager = LibrariesManager.GetManager();
                var videoTmbId = new Guid((string)item.GetValue("Id"));
                Video video = librariesManager.GetVideo(videoTmbId);
                if (video != null)
                {
                    var thumbUrl = video.ThumbnailUrl;
                

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"media-left\"");

WriteLiteral(">\n                    <div");

WriteLiteral(" class=\"sf-video-thmb\"");

WriteLiteral(">\n\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3789), Tuple.Create("\"", 3818)
            
            #line 90 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3796), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 3796), false)
);

WriteLiteral(">\n                            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 3853), Tuple.Create("\"", 3868)
            
            #line 91 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3859), Tuple.Create<System.Object, System.Int32>(thumbUrl
            
            #line default
            #line hidden
, 3859), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 3869), Tuple.Create("\"", 3898)
            
            #line 91 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3875), Tuple.Create<System.Object, System.Int32>(item.GetValue("Title")
            
            #line default
            #line hidden
, 3875), false)
);

WriteLiteral(" width=\"120\"");

WriteLiteral("/>\n                        \n                            <div");

WriteLiteral(" class=\"sf-icon-play\"");

WriteLiteral("></div>\n                        \n                        </a>\n                   " +
" </div>\n                </div>\n");

            
            #line 98 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }

            }

            else
            {

            }

            
            #line default
            #line hidden
WriteLiteral("            \n            \n            <div");

WriteLiteral(" class=\"media-body sf-media-body\"");

WriteLiteral(">\n\n                <h3>\n");

            
            #line 111 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 111 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                     if (hasLink)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4365), Tuple.Create("\"", 4394)
            
            #line 113 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4372), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 4372), false)
);

WriteLiteral(">");

            
            #line 113 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                    Write(item.GetValue("Title"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n");

            
            #line 114 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                    }
                    else
                    {
                        
            
            #line default
            #line hidden
            
            #line 117 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                   Write(item.GetValue("Title"));

            
            #line default
            #line hidden
            
            #line 117 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                               
                    }

            
            #line default
            #line hidden
WriteLiteral("                </h3>\n\n                <p>");

            
            #line 121 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
              Write(Html.Raw(item.GetValue("HighLighterResult")));

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 122 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 122 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                 if (hasLink)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4725), Tuple.Create("\"", 4754)
            
            #line 124 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4732), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 4732), false)
);

WriteLiteral(">");

            
            #line 124 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                Write(item.GetValue("Link"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n");

            
            #line 125 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\n            </div>\n");

            
            #line 128 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\n    </div>\n\n");

            
            #line 132 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 132 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
     if (Model.DisplayMode == ListDisplayMode.Paging && Model.TotalPagesCount != null && Model.TotalPagesCount > 1)
    {
        if(ViewBag.IsFilteredbyPermission) 
        {

            
            #line default
            #line hidden
WriteLiteral("             <ul");

WriteLiteral(" class=\"pagination\"");

WriteLiteral(">\n");

            
            #line 137 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 137 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                 if (Model.CurrentPage > 1)
				{

            
            #line default
            #line hidden
WriteLiteral("                    <li>\n\t\t\t\t\t    <a");

WriteAttribute("href", Tuple.Create(" href=\'", 5161), Tuple.Create("\'", 5238)
            
            #line 140 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 5168), Tuple.Create<System.Object, System.Int32>(string.Format(ViewBag.RedirectPageUrlTemplate, Model.CurrentPage - 1)
            
            #line default
            #line hidden
, 5168), false)
);

WriteLiteral(">");

            
            #line 140 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                    Write(Html.Resource("Prev"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n                    </li>\n");

            
            #line 142 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
				}

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 143 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                 if (Model.CurrentPage < @Model.TotalPagesCount)
				{

            
            #line default
            #line hidden
WriteLiteral("                    <li>\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\'", 5421), Tuple.Create("\'", 5498)
            
            #line 146 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 5428), Tuple.Create<System.Object, System.Int32>(string.Format(ViewBag.RedirectPageUrlTemplate, Model.CurrentPage + 1)
            
            #line default
            #line hidden
, 5428), false)
);

WriteLiteral(">");

            
            #line 146 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                    Write(Html.Resource("Next"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n                    </li>\n");

            
            #line 148 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
				}

            
            #line default
            #line hidden
WriteLiteral("            </ul>\n");

            
            #line 150 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
        }
        else 
        {
            if (Model.CurrentPage == Model.TotalPagesCount)
            {

            
            #line default
            #line hidden
WriteLiteral("                <em");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 155 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                   Write((Model.ItemsPerPage * Model.TotalPagesCount) - Model.Results.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" of ");

            
            #line 155 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                Write(Model.Results.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" results</em>\n");

            
            #line 156 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <em");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 159 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                  Write(Model.ItemsPerPage);

            
            #line default
            #line hidden
WriteLiteral(" of ");

            
            #line 159 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                         Write(Model.Results.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" results</em>\n");

            
            #line 160 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            }
            

            
            #line default
            #line hidden
WriteLiteral("            <div>\n");

WriteLiteral("                ");

            
            #line 163 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
           Write(Html.Action("Index", "ContentPager", new
                {
                    currentPage = Model.CurrentPage,
                    totalPagesCount = Model.TotalPagesCount,
                    redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
                }));

            
            #line default
            #line hidden
WriteLiteral("\n            </div>\n");

            
            #line 170 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResOrderBy\"");

WriteAttribute("value", Tuple.Create(" value=\'", 6407), Tuple.Create("\'", 6446)
            
            #line 173 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6415), Tuple.Create<System.Object, System.Int32>(Request.QueryString["orderBy"]
            
            #line default
            #line hidden
, 6415), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResLanguage\"");

WriteAttribute("value", Tuple.Create(" value=\'", 6508), Tuple.Create("\'", 6548)
            
            #line 174 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6516), Tuple.Create<System.Object, System.Int32>(Request.QueryString["language"]
            
            #line default
            #line hidden
, 6516), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResIndexCatalogue\"");

WriteAttribute("value", Tuple.Create(" value=\'", 6616), Tuple.Create("\'", 6662)
            
            #line 175 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6624), Tuple.Create<System.Object, System.Int32>(Request.QueryString["indexCatalogue"]
            
            #line default
            #line hidden
, 6624), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResQuery\"");

WriteAttribute("value", Tuple.Create(" value=\'", 6721), Tuple.Create("\'", 6764)
            
            #line 176 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6729), Tuple.Create<System.Object, System.Int32>(Request.QueryString["searchQuery"]
            
            #line default
            #line hidden
, 6729), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResWordsMode\"");

WriteAttribute("value", Tuple.Create(" value=\'", 6827), Tuple.Create("\'", 6868)
            
            #line 177 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6835), Tuple.Create<System.Object, System.Int32>(Request.QueryString["wordsMode"]
            
            #line default
            #line hidden
, 6835), false)
);

WriteLiteral(" />\n        \n</div>\n\n");

            
            #line 181 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top"));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 182 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/SearchResults/Search-results.js"), "bottom"));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
