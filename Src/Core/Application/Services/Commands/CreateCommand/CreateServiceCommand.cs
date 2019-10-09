using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Services.Commands.CreateCommand
{
    public class CreateServiceCommand :IRequest<int>
    {
        public ServiceDTO ServiceDTO { get;set; }
    }
}
