using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.MediatrPOC.Domain.Notification.ProductNotification
{
    public class ProductGetNotification : INotification
    {
        public int Quantity { get; set; }

        public ProductGetNotification(int count)
        {
            this.Quantity = count;
        }
    }
}
