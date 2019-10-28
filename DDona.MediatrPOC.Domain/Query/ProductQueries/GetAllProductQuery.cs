using DDona.MediatrPOC.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.MediatrPOC.Domain.Query.ProductQueries
{
    public class GetAllProductQuery : Query, IRequest<IList<Product>>
    {
    }
}
