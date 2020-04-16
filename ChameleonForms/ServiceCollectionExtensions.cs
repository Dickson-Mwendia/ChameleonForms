﻿using ChameleonForms.Attributes;
using ChameleonForms.Metadata;
using ChameleonForms.ModelBinders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ChameleonForms
{
    // todo: Add int/datetime client side validation support. Context: https://github.com/jbogard/aspnetwebstack/blob/730c683da2458430d36e3e360aba68932ba69fa4/src/System.Web.Mvc/ClientDataTypeModelValidatorProvider.cs, https://github.com/aspnet/Mvc/pull/2950, https://github.com/aspnet/Mvc/pull/2812, https://github.com/aspnet/Mvc/issues/4005, https://github.com/jquery-validation/jquery-validation/issues/626
    // todo: Add type="email" etc. stuff
    // todo: Add support for non jquery unobtrusive validation
    // idea: Add support for other validation techniques e.g. Vuejs?
    // Add FormTemplate.Default setting up - perhaps this can be via DI now?
    // Add this extension equivalent for twitter bootstrap
    // Add bootstrap4
    // Add source files for unobtrusive validation - add to CDN instead?

    public static class ServiceCollectionExtensions
    {
        public static void AddChameleonForms(this IServiceCollection services, bool humanizedLabels = true)
        {
            if (services == null)
            {
                throw new ArgumentNullException("services");
            }

            services.Configure<MvcOptions>(x =>
            {
                if (humanizedLabels)
                    x.ModelMetadataDetailsProviders.Add(new HumanizedLabelsDisplayMetadataProvider());
                x.ModelMetadataDetailsProviders.Add(new ModelMetadataAwareDisplayMetadataProvider());

                x.ModelBinderProviders.Insert(0, new DateTimeModelBinderProvider());
                x.ModelBinderProviders.Insert(0, new FlagsEnumModelBinderProvider());
                x.ModelBinderProviders.Insert(0, new EnumListModelBinderProvider());
            });

            services.AddSingleton<IValidationAttributeAdapterProvider, RequiredFlagsEnumAttributeAdapterProvider>();
        }
    }
}
