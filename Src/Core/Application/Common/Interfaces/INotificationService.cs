using Nexawo.Application.Notifications.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nexawo.Application.Common.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(MessageDTO message);
    }
}
