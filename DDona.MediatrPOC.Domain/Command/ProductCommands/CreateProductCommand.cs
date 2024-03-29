﻿using DDona.MediatrPOC.Domain.Validation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.MediatrPOC.Domain.Command.ProductCommands
{
    public class CreateProductCommand : Command, IRequest<CommandResult>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public override bool IsValid()
        {
            _validation = new CreateProductCommandValidation().Validate(this);
            return _validation.IsValid;
        }
    }
}
