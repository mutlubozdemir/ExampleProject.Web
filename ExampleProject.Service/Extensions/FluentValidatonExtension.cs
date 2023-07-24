using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ExampleProject.Service.Extensions
{
    public static class FluentValidatonExtension
    {
        public static void AddToModelState(this ValidationResult result,ModelStateDictionary modelState)
        {
            foreach (var error in result.Errors)
            {
                modelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
        }
    }
}
