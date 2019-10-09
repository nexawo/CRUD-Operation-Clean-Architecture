using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Tenants.Commands.DeleteTenant
{
    public class DeleteTenantCommand : IRequest
    {
        public string Id { get; set; }
    }
}
