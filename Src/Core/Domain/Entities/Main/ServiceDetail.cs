using Nexawo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Domain.Entities.Main
{
    public class ServiceDetail : AuditableEntity
    {
        public int Id { get; set; }
        public string Service { get; set; }
        public string Page { get; set; }
        public string Content { get; set; }
    }
}
