﻿using DotvvmAcademy.Steps.Validation.Interfaces;
using DotVVM.Framework.Compilation.ControlTree.Resolved;

namespace DotvvmAcademy.Steps.Validation.Validators.Lesson2
{
    [StepValidation(ValidationKey = "Lesson2Step10Validator")]
    public class Lesson2Step10Validator : IDotHtmlCodeValidationObject
    {
        public void Validate(ResolvedTreeRoot resolvedTreeRoot)
        {
            ValidatorHelper.ValidateRepeaterTemplate2(resolvedTreeRoot);
        }
    }
}