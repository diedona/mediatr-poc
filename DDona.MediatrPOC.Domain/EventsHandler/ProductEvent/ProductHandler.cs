using DDona.MediatrPOC.Domain.Notification.ProductNotification;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDona.MediatrPOC.Domain.EventsHandler.ProductEvent
{
    public class ProductHandler : 
        INotificationHandler<ProductCreatedNotification>,
        INotificationHandler<ProductGetNotification>
    {
        public Task Handle(ProductCreatedNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"Inserimos um produto de Id {notification.Id}");
            });
        }

        public Task Handle(ProductGetNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"Buscamos {notification.Quantity} produto(s)");
            });
        }
    }
}
