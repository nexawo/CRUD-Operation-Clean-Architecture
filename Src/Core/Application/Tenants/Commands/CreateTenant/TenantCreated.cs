using MediatR;
using Nexawo.Application.Common.Interfaces;
using Nexawo.Application.Notifications.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.Tenants.Commands.CreateTenant
{
    public class TenantCreated : INotification
    {
        public string TenantId { get; set; }

        public class TenantCreatedHandler : INotificationHandler<TenantCreated>
        {
            private readonly INotificationService _notification;

            public TenantCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(TenantCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new MessageDTO());
            }
        }
    }
}
