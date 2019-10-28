using DDona.MediatrPOC.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.MediatrPOC.Domain.Command.ProductCommands
{
    public class GetProductCommand : Command, IRequest<IList<Product>>
    {
    }
}
