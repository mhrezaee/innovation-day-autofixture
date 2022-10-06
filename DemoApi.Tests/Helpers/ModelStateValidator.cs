using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Tests.Helpers;

public static class ModelStateValidator
{
    public static void Validate(this ControllerBase controller, object model)
    {
        var validationContext = new ValidationContext(model, null, null);
        var validationResults = new List<ValidationResult>();
        Validator.TryValidateObject(model, validationContext, validationResults, true);
        foreach (var validationResult in validationResults.Where(validationResult => validationResult.ErrorMessage != null))
        {
                controller.ModelState.AddModelError(validationResult.MemberNames.First(),
                    validationResult.ErrorMessage!);
        }
    }
}