using DDona.MediatrPOC.Domain.Entity;
using DDona.MediatrPOC.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.MediatrPOC.Infra.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IList<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product("Product 1", "Description 1", 2.5m),
                new Product("Product 2", "Description 2", 5m)
            };
        }

        public void Save(Product product)
        {
            _products.Add(product);
        }
    }
}
