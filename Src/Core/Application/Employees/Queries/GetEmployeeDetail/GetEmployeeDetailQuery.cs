using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Employees.Queries.GetEmployeeDetail
{
    public class GetEmployeeDetailQuery : IRequest<EmployeeDetailVM>
    {
        public int EmployeeID { get; set; }
    }
}
