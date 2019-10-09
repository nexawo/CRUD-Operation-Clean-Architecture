using System.Threading.Tasks;
using Nexawo.Application.test;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Nexawo.WebApp.Controllers
{
	public class testController : Controller
	{

		[HttpGet]
		public IActionResult Index()
		{
 
			string viewName = string.Empty; 
			viewName = HttpContext.Session.GetString("Service")+"test";
			return View(viewName);
		}

		[HttpGet]
		public IActionResult Service1test()
		{
			 return View();
		}

		[HttpPost]
		public IActionResult Service1test(Service1testViewModel service1testViewModel)
		{
			return View();
		}

		//[HttpGet]
		//public IActionResult Service1test()
		//{
		//	 return View();
		//}

		//[HttpPost]
		//public IActionResult Service1test(Service1testViewModel service1testViewModel)
		//{
		//	return View();
		//}

		//[HttpGet]
		//public IActionResult Service1test()
		//{
		//	 return View();
		//}

		//[HttpPost]
		//public IActionResult Service1test(Service1testViewModel service1testViewModel)
		//{
		//	return View();
		//}
	}
}
