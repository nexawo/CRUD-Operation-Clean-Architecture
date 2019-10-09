using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nexawo.Application.Tenants.Commands.CreateTenant;
using Nexawo.Application.Tenants.Commands.DeleteTenant;
using Nexawo.Application.Tenants.Commands.UpdateTenant;
using Nexawo.Application.Tenants.Queries.GetTenantDetail;
using Nexawo.Application.Tenants.Queries.GetTenantsList;
using Nexawo.Application.Users.Queries.GetUsersListByTenant;

namespace Nexawo.WebApp.Controllers
{
    public class TenantController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> List()
        {            
            var list = await Mediator.Send(new GetTenantsListQuery());
           
            return View(list.Tenants);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Add(CreateTenantCommand command)
        {
            command.TenantId = Guid.NewGuid().ToString();
            await Mediator.Send(command);
            return RedirectToAction("List");
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Edit(string id)
        {
            var tenant = await Mediator.Send(new GetTenantDetailQuery { Id = id });
            return View(tenant);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Edit(TenantDetailVM tenantDetailVM)
        { 
            var updateTenantCommand = new UpdateTenantCommand() 
            {
                TenantId = tenantDetailVM.TenantId,
                Name = tenantDetailVM.Name,
                DBConnection = tenantDetailVM.DBConnection
            };
            //var updateTenantCommand = _mapper.Map<UpdateTenantCommand>(tenantDetailVM);
            var tenant = await Mediator.Send(updateTenantCommand);
            return RedirectToAction("List");
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Detail(string id)
        {
            var tenant = await Mediator.Send(new GetTenantDetailQuery { Id = id });
            var tenantUsers = await Mediator.Send(new GetUsersListByTenantQuery { TenantId = id });
            ViewBag.TenantUsers = tenantUsers.Users;
            return View(tenant);
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Delete(string id)
        {
            var tenant = await Mediator.Send(new GetTenantDetailQuery { Id = id });
            return View(tenant);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Delete(string id,string confirm = null)
        {
            var deleteTenantCommand = new DeleteTenantCommand()
            {
                Id = id
            };
            var result = await Mediator.Send(deleteTenantCommand);
            return RedirectToAction("List");
        }
    }
}