using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nexawo.Application.Common.Interfaces;
using Nexawo.Application.Services.Commands;
using Nexawo.Application.Users.Queries.GetUsersListByTenant;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.Users.Queries.GetUsersList
{
    public class GetUsersListQueryHandler : IRequestHandler<GetUsersListQuery, UsersListVM>
    {
        private readonly IMainDbContext _context;
        private readonly IMapper _mapper;
        public GetUsersListQueryHandler(IMainDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<UsersListVM> Handle(GetUsersListQuery request, CancellationToken cancellationToken)
        {
            var usersList = await _context.Users
              .ProjectTo<UserDTO>(_mapper.ConfigurationProvider)
              .ToListAsync();

            var usersListVM = new UsersListVM
            {
                Users = usersList,

            };
            return usersListVM;
        }

    }
}
