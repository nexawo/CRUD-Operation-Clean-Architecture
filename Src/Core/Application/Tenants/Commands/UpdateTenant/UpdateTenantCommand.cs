using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Tenants.Commands.UpdateTenant
{
    public class UpdateTenantCommand : IRequest
    {
        public string TenantId { get; set; }
        public string Name { get; set; }
        public string DBConnection { get; set; }
    }
}
