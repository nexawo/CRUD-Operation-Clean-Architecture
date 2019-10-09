using Nexawo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Domain.Entities.Main
{
    public class Service :AuditableEntity
    {
        public Service()
        {
            Users = new HashSet<User>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<User> Users { get; private set; }
    }
}
