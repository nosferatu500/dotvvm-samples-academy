﻿using System.Linq;
using DotvvmAcademy.Lessons;
using DotvvmAcademy.Steps.Validation.Interfaces;
using DotvvmAcademy.Steps.Validation.ValidatorProvision;
using DotVVM.Framework.Compilation.ControlTree.Resolved;
using DotVVM.Framework.Controls;

namespace DotvvmAcademy.Steps.Validation.Validators.Lesson1
{
    [StepValidation(ValidationKey = "Lesson1Step7Validator")]
    public class Lesson1Step7Validator : IDotHtmlCodeValidationObject
    {
        public void Validate(ResolvedTreeRoot resolvedTreeRoot)
        {
            ValidatorHelper.ValidateTextBoxBindings(resolvedTreeRoot);

            resolvedTreeRoot.GetDescendantControls<Button>().Single()
                .ValidateCommandBindingExpression(ButtonBase.ClickProperty, "Calculate()");

            var buttonTextBinding = resolvedTreeRoot.GetDescendantControls<Button>()
                .Select(c => c.GetValue(ButtonBase.TextProperty))
                .SingleOrDefault();
            if (buttonTextBinding == null)
            {
                throw new CodeValidationException(Lesson1ValidationErrorMessages.ButtonDoesNotHaveText);
            }
        }
    }
}