using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Tenants.Commands.CreateTenant
{
    public class CreateTenantCommand : IRequest<int>
    {
        public string TenantId { get; set; }
        public string Name { get; set; }
        public string DBConnection { get; set; }

    }
}
