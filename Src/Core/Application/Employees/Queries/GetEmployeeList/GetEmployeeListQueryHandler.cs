using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Nexawo.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.Employees.Queries.GetEmployeeList
{
    public class GetEmployeeListQueryHandler : IRequestHandler<GetEmployeeListQuery, EmployeeListVM>
    {
        private readonly IMainDbContext _context;
        private readonly IMapper _mapper;

        public GetEmployeeListQueryHandler(IMainDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<EmployeeListVM> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            var employee = await _context.Employees
                .ProjectTo<EmployeeListDTO>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            var vm = new EmployeeListVM
            {
                Employees = employee
            };

            return vm;
        }
    }
}
