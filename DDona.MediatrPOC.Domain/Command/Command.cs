using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.MediatrPOC.Domain.Command
{
    public abstract class Command
    {
        protected ValidationResult _validation;

        public bool IsValid => _validation.IsValid;
    }
}
