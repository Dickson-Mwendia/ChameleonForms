﻿using System;
using System.Linq.Expressions;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using ChameleonForms.Component;
using ChameleonForms.Utils;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ChameleonForms.TagHelpers
{
    /// <summary>
    /// Creates a ChameleonForms form field context, use within a ChameleonForm form section or form field context.
    /// </summary>
    public class FieldTagHelper : FieldConfigurationTagHelper
    {
        public override async Task ProcessUsingModelPropertyAsync<TModel, TProperty>(TagHelperContext context, TagHelperOutput output,
            Expression<Func<TModel, TProperty>> modelProperty)
        {
            var helper = ViewContext.GetHtmlHelper<TModel>();

            if (helper.IsInChameleonFormsSection())
            {
                var s = helper.GetChameleonFormsSection();
                if (output.TagMode == TagMode.SelfClosing)
                {
                    output.TagMode = TagMode.StartTagAndEndTag;
                    output.TagName = null;
                    output.Content.SetHtmlContent(s.FieldFor(modelProperty).Configure(this));
                }
                else
                {
                    using (s.BeginFieldFor(modelProperty, Field.Configure().Configure(this)))
                    {
                        var childContent = await output.GetChildContentAsync();
                        childContent.WriteTo(helper.ViewContext.Writer, HtmlEncoder.Default);
                    }
                    output.TagName = null;
                }
            }
            else
            {
                var ff = helper.GetChameleonFormsField();
                output.TagMode = TagMode.StartTagAndEndTag;
                output.TagName = null;
                output.Content.SetHtmlContent(ff.FieldFor(modelProperty).Configure(this));
            }
        }
    }
}
