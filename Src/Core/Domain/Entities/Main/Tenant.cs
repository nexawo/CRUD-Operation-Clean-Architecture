using Nexawo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Domain.Entities.Main
{
    public class Tenant : AuditableEntity
    {
        public Tenant()
        {
            Users = new HashSet<User>();
        }
        public string TenantId { get; set; }
        public string Name { get; set; }
        public string DBConnection { get; set; }
        public ICollection<User> Users { get; private set; }
    }
}
