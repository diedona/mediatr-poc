using DDona.MediatrPOC.Domain.Validation;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.MediatrPOC.Domain.Command
{
    public abstract class Command
    {
        protected ValidationResult _validation;

        public abstract bool IsValid();

        public string GetValidationErrors() => _validation.ToString();
    }
}
