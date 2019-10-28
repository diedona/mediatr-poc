using DDona.MediatrPOC.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.MediatrPOC.Domain.Repository
{
    public interface IProductRepository
    {
        void Save(Product product);
    }
}
