using DDona.MediatrPOC.Domain.Command.ProductCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.MediatrPOC.Domain.Validation
{
    public class CreateProductCommandValidation : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidation()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title required!")
                .Length(2, 50).WithMessage("Title between 2 and 50 chars!");
        }
    }
}
