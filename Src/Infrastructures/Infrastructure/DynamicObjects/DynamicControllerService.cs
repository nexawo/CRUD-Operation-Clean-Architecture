using Nexawo.Application.Common.Interfaces.DynamicObjects;
using Nexawo.Application.Common.Interfaces;
using Nexawo.Application.DynamicObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexawo.Infrastructure.DynamicObjects
{
    public class DynamicControllerService : IDynamicControllerService
    {
        private readonly IDirectoryService _directoryService;
        public DynamicControllerService(IDirectoryService directoryService)
        {
            _directoryService = directoryService;
        }
        public async Task<bool> GenerateFile(string directoryName, DynamicObjectDTO dynamicObjectDTO)
        {
            try
            {
                string directory = await _directoryService.GetDirectory(directoryName,true);
                var file = Path.Combine(directory, dynamicObjectDTO.Page + "Controller.cs");
                if (!System.IO.File.Exists(file))
                    System.IO.File.Create(file).Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        public async Task<bool> AddRefernces(string directoryName, DynamicObjectDTO dynamicObjectDTO)
        {
            try
            {
                string directory = await _directoryService.GetDirectory(directoryName,true);
                var file = Path.Combine(directory, dynamicObjectDTO.Page + "Controller.cs");
                string references = @""
                                 + "using System.Threading.Tasks;\n"
                                 + "using Nexawo.Application."+dynamicObjectDTO.Page+";\n"
                                 + "using Microsoft.AspNetCore.Http;\n"
                                 + "using Microsoft.AspNetCore.Mvc;\n"
                                 + "namespace Nexawo.WebApp.Controllers\n{"
                                 + "\n\tpublic class " + dynamicObjectDTO.Page + "Controller : Controller\n\t{"
                                 + "\n\t}\n}"
                                 + ""
                                 ;
                var txtLines = System.IO.File.ReadAllLines(file).ToList();
                int actionIndexToBeAdded = txtLines.Count();// - 3;
                if (!txtLines.Contains("namespace Nexawo.WebApp.Controllers"))
                {
                    txtLines.Insert(actionIndexToBeAdded, references);
                    System.IO.File.WriteAllLines(file, txtLines);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }
            return true;
        }
        public async Task<bool> Index(string directoryName, DynamicObjectDTO dynamicObjectDTO)
        {
            try
            {
                string directory = await _directoryService.GetDirectory(directoryName,true);
                string responsibleView = "\n\t\t" + @"[HttpGet]" +
                "\n\t\tpublic IActionResult Index()" +
                "\n\t\t{\n " +
                "\n\t\t\tstring viewName = string.Empty; " +
                "\n\t\t\tviewName = HttpContext.Session.GetString(\"Service\")+" + "\"" + dynamicObjectDTO.Page + "\";" +
                //"\n\t\t\tTempData.Keep(\"Group\");" +
                "\n\t\t\treturn View(" + "viewName" + ");\n\t\t}";
                var file = Path.Combine(directory, dynamicObjectDTO.Page + "Controller.cs");
                var txtLines = System.IO.File.ReadAllLines(file).ToList();
                int actionIndexToBeAdded = txtLines.Count() - 2;
                if (!txtLines.Contains("\t\tpublic IActionResult Index()"))
                {
                    txtLines.Insert(actionIndexToBeAdded, responsibleView);
                    System.IO.File.WriteAllLines(file, txtLines);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }
            return true;
        }
        public async Task<bool> Get(string directoryName, DynamicObjectDTO dynamicObjectDTO)
        {
            try
            {
                string directory = await _directoryService.GetDirectory(directoryName,true);
                string getAction = "\n\t\t[HttpGet]\n\t\tpublic IActionResult " + dynamicObjectDTO.Service + dynamicObjectDTO.Page + "()\n\t\t{\n\t\t\t return View();\n\t\t}";
                var file = Path.Combine(directory, dynamicObjectDTO.Page + "Controller.cs");
                var txtLines = System.IO.File.ReadAllLines(file).ToList();
                int actionIndexToBeAdded = txtLines.Count() - 2;
                if (!txtLines.Contains(getAction))
                {
                    txtLines.Insert(actionIndexToBeAdded, getAction);
                    System.IO.File.WriteAllLines(file, txtLines);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }
            return true;
        }
        public async Task<bool> Post(string directoryName, DynamicObjectDTO dynamicObjectDTO)
        {
            try
            {
                string directory = await _directoryService.GetDirectory(directoryName,true);
                string postAction = "\n\t\t[HttpPost]\n\t\tpublic IActionResult " + dynamicObjectDTO.Service + dynamicObjectDTO.Page + "("+ dynamicObjectDTO.Service + dynamicObjectDTO.Page + "ViewModel " + dynamicObjectDTO.Service.ToLower() + dynamicObjectDTO.Page + "ViewModel" + ")\n\t\t{\n\t\t\treturn View();\n\t\t}";
                var file = Path.Combine(directory, dynamicObjectDTO.Page + "Controller.cs");
                var txtLines = System.IO.File.ReadAllLines(file).ToList();
                int actionIndexToBeAdded = txtLines.Count() - 2;
                if (!txtLines.Contains(postAction))
                {
                    txtLines.Insert(actionIndexToBeAdded, postAction);
                    System.IO.File.WriteAllLines(file, txtLines);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }
            return true;
        }
    }
}
