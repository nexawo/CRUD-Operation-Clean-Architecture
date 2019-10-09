using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Tenants.Queries.GetTenantsList
{
    public class TenantsListVM
    {
        public IList<TenantDTO> Tenants { get; set; }
    }
}
