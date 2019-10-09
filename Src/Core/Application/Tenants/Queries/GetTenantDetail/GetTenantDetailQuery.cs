using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Tenants.Queries.GetTenantDetail
{
    public class GetTenantDetailQuery :IRequest<TenantDetailVM>
    {
        public string Id { get; set; }
    }
}
