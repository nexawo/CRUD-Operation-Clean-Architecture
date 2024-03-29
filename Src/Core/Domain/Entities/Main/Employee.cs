﻿using Nexawo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Domain.Entities.Main
{
    public class Employee : AuditableEntity
    {

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CNIC { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        
    }
}
