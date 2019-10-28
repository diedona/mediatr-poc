using DDona.MediatrPOC.Domain.Command.Product;
using DDona.MediatrPOC.Domain.Entity;
using DDona.MediatrPOC.Domain.Notification.Product;
using DDona.MediatrPOC.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDona.MediatrPOC.Domain.Handler.ProductHandler
{
    public class ProductHandler
        : IRequestHandler<CreateProductCommand, Guid>
    {
        private readonly IMediator _mediator;
        private readonly IProductRepository _productRepository;

        public ProductHandler(IMediator mediator, IProductRepository productRepository)
        {
            _mediator = mediator;
            _productRepository = productRepository;
        }

        public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            Product product = new Product(request.Title, request.Description, request.Price);
            _productRepository.Save(product);

            _mediator.Publish(new ProductCreatedNotification() { Id = product.Id }, cancellationToken);
            return Task.FromResult(product.Id);
        }
    }
}
