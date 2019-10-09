using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Nexawo.Application.Common.Interfaces;
using Nexawo.Application.Users.Queries.GetUsersListByTenant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.Users.Queries.UserLogin
{
    public class UserLoginQueryHandler : IRequestHandler<UserLoginQuery, UserDTO>
    {
        private readonly IMainDbContext _context;
        private readonly IMapper _mapper;
        public UserLoginQueryHandler(IMainDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<UserDTO> Handle(UserLoginQuery request, CancellationToken cancellationToken)
        {
            var user = await _context.Users
                                          .Where(row => row.Email == request.Email && row.Password == request.Password)
                                          .ProjectTo<UserDTO>(_mapper.ConfigurationProvider)
                                          .FirstOrDefaultAsync();
            return user;
        }
    }
}
