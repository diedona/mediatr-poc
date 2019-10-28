using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDona.MediatrPOC.Domain.Command.ProductCommands;
using DDona.MediatrPOC.Domain.Query.ProductQueries;
using DDona.MediatrPOC.Domain.Repository;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDona.MediatrPOC.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IProductRepository _productRepository;

        public ProductController(IMediator mediator, IProductRepository productRepository)
        {
            _mediator = mediator;
            _productRepository = productRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _mediator.Send(new GetAllProductQuery());
            return Ok(response);
        }
    }
}