﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChameleonForms.Templates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 1 "..\..\Templates\HtmlHelpers.cshtml"
    using System.Net.Http;
    
    #line default
    #line hidden
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.4.1.0")]
    public static class HtmlHelpers
    {

public static System.Web.WebPages.HelperResult BeginForm(string action, HttpMethod method, string enctype) {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 6 "..\..\Templates\HtmlHelpers.cshtml"
                                                                     

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "    <form action=\"");



#line 7 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, action);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "\" method=\"");



#line 7 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, method.Method.ToLower());

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "\"");



#line 7 "..\..\Templates\HtmlHelpers.cshtml"
                   WebViewPage.WriteTo(@__razor_helper_writer, Html.Attribute("enctype", enctype));

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, ">\r\n");



#line 8 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult EndForm() {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 10 "..\..\Templates\HtmlHelpers.cshtml"
                   

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "    </form>\r\n");



#line 12 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult BeginSection(string title) {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 14 "..\..\Templates\HtmlHelpers.cshtml"
                                    

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "    <fieldset>\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "        <legend>");



#line 16 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, title);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "</legend>\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "        <dl>\r\n");



#line 18 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult BeginNestedSection(string title) {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 20 "..\..\Templates\HtmlHelpers.cshtml"
                                          

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "            <dt>");



#line 21 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, title);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "</dt>\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "            <dd>\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "                <dl>\r\n");



#line 24 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult EndSection() {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 26 "..\..\Templates\HtmlHelpers.cshtml"
                      

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "        </dl>\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "    </fieldset>\r\n");



#line 29 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult EndNestedSection() {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 31 "..\..\Templates\HtmlHelpers.cshtml"
                            

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "                <dl>\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "            </dd>\r\n");



#line 34 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult BeginFieldInternal(IHtmlString labelHtml, IHtmlString elementHtml, IHtmlString validationHtml) {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 36 "..\..\Templates\HtmlHelpers.cshtml"
                                                                                                        

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "            <dt>");



#line 37 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, labelHtml);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "</dt>\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "            <dd>\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "                ");



#line 39 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, elementHtml);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, " ");



#line 39 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, validationHtml);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "\r\n");



#line 40 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult Field(IHtmlString labelHtml, IHtmlString elementHtml, IHtmlString validationHtml) {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 42 "..\..\Templates\HtmlHelpers.cshtml"
                                                                                           

#line default
#line hidden


#line 43 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, BeginFieldInternal(labelHtml, elementHtml, validationHtml));

#line default
#line hidden


#line 43 "..\..\Templates\HtmlHelpers.cshtml"
                                                           

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "            </dd>\r\n");



#line 45 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult BeginField(IHtmlString labelHtml, IHtmlString elementHtml, IHtmlString validationHtml) {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 47 "..\..\Templates\HtmlHelpers.cshtml"
                                                                                                

#line default
#line hidden


#line 48 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, BeginFieldInternal(labelHtml, elementHtml, validationHtml));

#line default
#line hidden


#line 48 "..\..\Templates\HtmlHelpers.cshtml"
                                                           

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "                <dl>\r\n");



#line 50 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult EndField() {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 52 "..\..\Templates\HtmlHelpers.cshtml"
                    

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "                </dl>\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "            </dd>\r\n");



#line 55 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


    }
}
#pragma warning restore 1591
