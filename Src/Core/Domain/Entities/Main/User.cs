using Nexawo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Domain.Entities.Main
{
    public class User : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Tenant Tenant { get; set; }
        public Service Service { get; set; }
    }
}
