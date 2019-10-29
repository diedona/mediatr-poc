using DDona.MediatrPOC.Domain.Command.ProductCommands;
using DDona.MediatrPOC.Domain.Entity;
using DDona.MediatrPOC.Domain.Notification.ProductNotification;
using DDona.MediatrPOC.Domain.Query.ProductQueries;
using DDona.MediatrPOC.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDona.MediatrPOC.Mediator.Handler.ProductHandler
{
    public class ProductHandler :
        IRequestHandler<CreateProductCommand, Guid>,
        IRequestHandler<GetAllProductQuery, IList<Product>>
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

        public Task<IList<Product>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var products = _productRepository.Get();
            _mediator.Publish(new ProductGetNotification(products.Count), cancellationToken);
            return Task.FromResult(products);
        }
    }
}
