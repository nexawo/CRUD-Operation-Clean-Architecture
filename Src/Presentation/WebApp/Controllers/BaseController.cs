using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Nexawo.WebApp.Controllers
{
    //[ApiController]
    //[Route("api/[controller]/[action]")]
    [Controller]
    public abstract class BaseController : Controller //ControllerBase //Controller//
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ?? (_mediator = HttpContext.RequestServices.GetService<IMediator>());
    }
}