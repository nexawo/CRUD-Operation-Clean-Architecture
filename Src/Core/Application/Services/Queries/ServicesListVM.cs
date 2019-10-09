using Nexawo.Application.Services.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Services.Queries
{
    public class ServicesListVM
    {
        public IList<ServiceDTO> Services { get; set; }
    }
}
