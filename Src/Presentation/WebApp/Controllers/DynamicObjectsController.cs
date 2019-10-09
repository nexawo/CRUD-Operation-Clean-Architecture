using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nexawo.Application.DynamicObjects;
using Nexawo.Application.DynamicObjects.Commands.CreateController;
using Nexawo.Application.DynamicObjects.Commands.CreateModel;
using Nexawo.Application.DynamicObjects.Commands.CreateView;
using Nexawo.Application.DynamicObjects.Queries.GetFieldsList;

namespace Nexawo.WebApp.Controllers
{
    public class DynamicObjectsController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> Create([FromBody]DynamicObjectDTO dynamicObjectDTO)
        {            
            var command = new CreateModelCommand();
            command.DynamicObjectDTO = dynamicObjectDTO;
            bool result = await Mediator.Send(command);
            if (result)
            {
                var controllerCommand = new CreateControllerCommand();
                controllerCommand.DynamicObjectDTO = dynamicObjectDTO;
                result = await Mediator.Send(controllerCommand);
                if (result)
                {
                    var viewCommand = new CreateViewCommand();
                    viewCommand.DynamicObjectDTO = dynamicObjectDTO;
                    result = await Mediator.Send(viewCommand);
                }
            }
            return Json(dynamicObjectDTO);
        }
        
        [HttpPost]
        public async Task<JsonResult> GetServiceDetailByPage(string service, string page)
        {
            
            var result = await Mediator.Send(new GetFieldsListQuery {Page = page,Service = service });
           // var result = new List<FieldsDetailViewModel>();
           // using (var dbContext = new HMSContextNexawo())
           // {
           //     var response = dbContext.ServiceDetails.Where(row => row.Service == service && row.Page == page).FirstOrDefault();
           //     if (response != null)
           //     {
           //         result = JsonConvert.DeserializeObject<List<FieldsDetailViewModel>>(response.Content);
           //     }
           //
           //
           // }
            return Json(result.Fields);
        }
    }
}