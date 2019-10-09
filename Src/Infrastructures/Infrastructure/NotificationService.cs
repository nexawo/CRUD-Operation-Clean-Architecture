using Nexawo.Application.Common.Interfaces;
using Nexawo.Application.Notifications.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nexawo.Infrastructure
{
    class NotificationService : INotificationService
    {
        public Task SendAsync(MessageDTO message)
        {
            return Task.CompletedTask;
        }
    }
}
