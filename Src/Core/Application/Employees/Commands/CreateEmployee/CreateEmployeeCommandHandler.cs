using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Nexawo.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.Employee.Commands.Create_Employee
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, int>
    {
        private readonly IMainDbContext _context;
        private readonly IMapper _mapper;
        
        

        public CreateEmployeeCommandHandler(IMainDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<int> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = _mapper.Map<Nexawo.Domain.Entities.Main.Employee>(request.EmployeeDTO);
            _context.Employees.Add(employee);
           int result = await _context.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
