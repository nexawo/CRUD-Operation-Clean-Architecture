using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Nexawo.Application.Services.Commands;
using Nexawo.Application.Services.Commands.CreateCommand;
using Nexawo.Application.Services.Queries.GetServicesList;
using Nexawo.WebApp.Controllers;

namespace WebApp.Controllers
{
    public class ServiceController : BaseController
    {
        public async Task<IActionResult> List()
        {
            var response = await Mediator.Send(new GetServicesListQuery());
            return View(response.Services);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return  View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(ServiceDTO serviceDTO)
        {
            var createServiceCommand = new CreateServiceCommand();
            createServiceCommand.ServiceDTO = serviceDTO;
            int result = await Mediator.Send(createServiceCommand);
            return RedirectToAction("List");
        }
    }
}