using DDona.MediatrPOC.Domain.Notification.Product;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDona.MediatrPOC.Domain.Handler.Product
{
    public class ProductHandler
        : INotificationHandler<ProductCreatedNotification>
    {
        public Task Handle(ProductCreatedNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"Inserimos um produto de Id {notification.Id}");
            });
        }
    }
}
