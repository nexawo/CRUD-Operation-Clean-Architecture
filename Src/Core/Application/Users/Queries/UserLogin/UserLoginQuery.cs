using MediatR;
using Nexawo.Application.Users.Queries.GetUsersListByTenant;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Users.Queries.UserLogin
{
    public class UserLoginQuery : IRequest<UserDTO>
    {
        public string Email { get; set;}
        public string Password { get; set; }
    }
}
