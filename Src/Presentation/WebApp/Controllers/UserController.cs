using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nexawo.Application.Users.Commands;
using Nexawo.Application.Users.Queries.GetUsersList;
using Nexawo.Application.Users.Queries.GetUsersListByTenant;
using Nexawo.Application.Users.Queries.UserLogin;
using Nexawo.WebApp.Controllers;

namespace WebApp.Controllers
{
    public class UserController : BaseController
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserDTO userDTO)
        {

            var user = await Mediator.Send(new UserLoginQuery { Email = userDTO.Email, Password = userDTO.Password });
            if (user == null)
                return View();
            else
            {
                HttpContext.Session.SetString("Service", "Service1");
                return RedirectToAction("Index", "Home");
            }
            
        }
        public async Task<IActionResult> List()
        {
            var usersList = await Mediator.Send(new GetUsersListQuery());
            return View(usersList.Users);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(UserDTO userDTO)
        {
            var createUserCommand = new CreateUserCommand();
            createUserCommand.UserDTO = userDTO;
            int result = await Mediator.Send(createUserCommand);
            return RedirectToAction("List");
        }
    }
}