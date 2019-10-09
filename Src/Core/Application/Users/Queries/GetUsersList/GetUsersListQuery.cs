using MediatR;
using Nexawo.Application.Users.Queries.GetUsersListByTenant;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Users.Queries.GetUsersList
{
    public class GetUsersListQuery : IRequest<UsersListVM>
    {
        public UsersListVM UsersListVM { get; set; }
    }
}
