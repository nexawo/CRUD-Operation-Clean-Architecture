using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nexawo.Application.Employee.Commands.Create_Employee;
using Nexawo.Application.Employees.Commands;
using Nexawo.Application.Employees.Commands.DeleteEmployee;
using Nexawo.Application.Employees.Commands.UpdateEmployee;
using Nexawo.Application.Employees.Queries.GetEmployeeDetail;
using Nexawo.Application.Employees.Queries.GetEmployeeList;

namespace Nexawo.WebApp.Controllers
{
    public class EmployeeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> List()
        {
            var list = await Mediator.Send(new GetEmployeeListQuery());
            
            return View(list.Employees);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(EmployeeDTO serviceDTO)
        {
            var createServiceCommand = new CreateEmployeeCommand();
          //  serviceDTO.EmployeeId = 1;
            createServiceCommand.EmployeeDTO = serviceDTO; 
            int result = await Mediator.Send(createServiceCommand);
            return RedirectToAction("List");
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Edit(int id)
        {
            var employee = await Mediator.Send(new GetEmployeeDetailQuery { EmployeeID = id });
            return View(employee);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Edit(EmployeeDetailVM employeeDetailVM)
        {
            var updateEmployeeCommand = new UpdateEmployeeCommand()
            {
                EmployeeId = employeeDetailVM.EmployeeId,
                FirstName = employeeDetailVM.FirstName,
                LastName = employeeDetailVM.LastName,
                CNIC = employeeDetailVM.CNIC,
                Email = employeeDetailVM.Email,
                Age = employeeDetailVM.Age,
                Address = employeeDetailVM.Address
            };
            //var updateTenantCommand = _mapper.Map<UpdateTenantCommand>(tenantDetailVM);
            var employee = await Mediator.Send(updateEmployeeCommand);
            return RedirectToAction("List");
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Delete(int id)
        {
            var employee = await Mediator.Send(new GetEmployeeDetailQuery { EmployeeID = id });
            return View(employee);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Delete(int id, string confirm = null)
        {
            var deleteEmployeeCommand = new DeleteEmployeeCommand()
            {
                EmployeeId = id
            };
            var result = await Mediator.Send(deleteEmployeeCommand);
            return RedirectToAction("List");
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Detail(int id)
        {
            var employee = await Mediator.Send(new GetEmployeeDetailQuery { EmployeeID = id });
            return View(employee);
        }
    }
}