using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.MediatrPOC.Domain.Notification.Product
{
    public class ProductCreatedNotification : INotification
    {
        public Guid Id { get; set; }
    }
}
