﻿using System.Reflection;
using DotvvmAcademy.Steps.Validation.Interfaces;
using DotvvmAcademy.Steps.Validation.ValidatorProvision;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace DotvvmAcademy.Steps.Validation.Validators.Lesson4
{
    [StepValidation(ValidatorKey = "Lesson4Step2Validator")]
    public class Lesson4Step2Validator : ICSharpCodeValidationObject
    {
        public void Validate(CSharpCompilation compilation, CSharpSyntaxTree tree, SemanticModel model,
            Assembly assembly)
        {
            Lesson4CommonValidator.ValidateStep2Properties(tree, model, assembly);
        }
    }
}