using AutoMapper;
using MediatR;
using Nexawo.Application.Common.Exceptions;
using Nexawo.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.Employees.Queries.GetEmployeeDetail
{
    public class GetEmployeeDetailQueryHandler : IRequestHandler<GetEmployeeDetailQuery, EmployeeDetailVM>
    {
        private readonly IMainDbContext _context;
        private readonly IMapper _mapper;

        public GetEmployeeDetailQueryHandler(IMainDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<EmployeeDetailVM> Handle(GetEmployeeDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Employees
                .FindAsync(request.EmployeeID);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Nexawo.Domain.Entities.Main.Employee), request.EmployeeID);
            }

            return _mapper.Map<EmployeeDetailVM>(entity);
        }

    }
}
