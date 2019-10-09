using Application.Employees.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Employees.Queries.GetEmployeeList
{
    public class EmployeeListVM
    {
        public IList<EmployeeListDTO> Employees { get; set; }
    }
}
