using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using IModelBinder = Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinder;
using IModelBinderProvider = Microsoft.AspNetCore.Mvc.ModelBinding.IModelBinderProvider;
using ModelBindingContext = Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingContext;

namespace ProjetoLP3_4bim.Models
{
    public class CustomBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context.Metadata.ModelType == typeof(decimal))
            {
                return new DecimalModelBinder();
            }

            return null;
        }
    }

    public class DecimalModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var valueProviderResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

            if (valueProviderResult == null)
            {
                return Task.CompletedTask;
            }

            var value = valueProviderResult.FirstValue;

            if (string.IsNullOrEmpty(value))
            {
                return Task.CompletedTask;
            }

            // Remove unnecessary commas and spaces //  string.Empty
            value = value.Replace(".",",").Trim();

            decimal myValue = 0;
            if (!decimal.TryParse(value, out myValue))
            {
                // Error
                bindingContext.ModelState.TryAddModelError(
                                        bindingContext.ModelName,
                                        "Could not parse MyValue.");
                return Task.CompletedTask;
            }

            bindingContext.Result = ModelBindingResult.Success(myValue);
            return Task.CompletedTask;
        }
    }
}
