using DDona.MediatrPOC.Domain.Notification.ProductNotification;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDona.MediatrPOC.Mediator.Events.ProductEvent
{
    public class DatabaseProductHandler : INotificationHandler<ProductCreatedNotification>
    {
        public Task Handle(ProductCreatedNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"- from Database - we should consider REALLY inserting the {notification.Id}...");
            });
        }
    }
}
