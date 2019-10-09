using System.Threading.Tasks;
using Nexawo.Application.Referral;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MediatR;
using Nexawo.Application.Referral.Commands.CreateReferral;
using Nexawo.Application.Referral.Commands;

namespace Nexawo.WebApp.Controllers
{
	public class ReferralController : BaseController
	{
        IMapper _mapper;        
        public ReferralController(IMapper mapper)
        {
            _mapper = mapper;
        }
		[HttpGet]
		public IActionResult Index()
		{
			string viewName = string.Empty; 
			viewName = HttpContext.Session.GetString("Service")+"Referral";
			return View(viewName);
		}
		[HttpGet]
		public IActionResult Service1Referral()
		{
			 return View();
		}

		[HttpPost]
		public async Task<IActionResult> Service1Referral(Service1ReferralViewModel service1ReferralViewModel)
		{
            
                var referral = _mapper.Map<ReferralDTO>(service1ReferralViewModel);
                CreateReferralCommand createReferralCommand = new CreateReferralCommand();
                createReferralCommand.ReferralDTO = referral;
                int result = await Mediator.Send(createReferralCommand);
            
            

            return View();
		}        

    }
}
