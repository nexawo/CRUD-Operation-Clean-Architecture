using Microsoft.AspNetCore.Hosting;
using Nexawo.Application.Common.Interfaces;
using Nexawo.Application.Common.Interfaces.DynamicObjects;
using Nexawo.Application.DynamicObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nexawo.Infrastructure.DynamicObjects
{
    public class DynamicModelService : IDynamicModelService
    {
        private readonly IDirectoryService _directoryService;
        public DynamicModelService(IDirectoryService directoryService)
        {
            _directoryService = directoryService;
        }
        public async Task<bool> AddContent(string directoryName, DynamicObjectDTO dynamicObjectDTO)
        {
            string directory = await _directoryService.GetDirectory(directoryName ,false);
            try
            { 
                var file = Path.Combine(directory, dynamicObjectDTO.Service + dynamicObjectDTO.Page + "ViewModel.cs");
                using (TextWriter text = new StreamWriter(file))
                {
                    text.WriteLine(@""
                                    + "\nusing System;"
                                    + "\nusing System.Collections.Generic;"
                                    + "\nusing System.Linq;"
                                    + "\nusing System.Threading.Tasks;"
                                    + "\nusing System.ComponentModel.DataAnnotations;"
                                    + "\nnamespace Nexawo.Application." + dynamicObjectDTO.Page + "" + "\n{" +
                                "\n\tpublic class " + dynamicObjectDTO.Service + dynamicObjectDTO.Page + "ViewModel" +
                                "\n\t{"
                                  );
                    text.WriteLine("\t\t[Key]\n\t\t[ScaffoldColumn(true)]");
                    text.WriteLine("\t\tpublic int Id {get;set;}");
                }
                foreach (var row in dynamicObjectDTO.FieldsDetailDTO)
                {
                    using (StreamWriter text = new StreamWriter(file, true))
                    {
                        if (row.FieldType.Equals("string"))
                        {
                            text.WriteLine("\t\t[MaxLength(" + row.MaxLength + "),MinLength(" + row.MinLength + ")]");
                        }
                        else
                        {
                            text.WriteLine("\t\t[Range(" + row.MinLength + "," + row.MaxLength + ")]");
                        }
                        if (row.IsRequired)
                            text.WriteLine("\t\t[Required]");

                        text.WriteLine("\t\tpublic " + row.FieldType + " " + row.FieldName + " {get;set;}");
                        text.WriteLine();
                    }
                }
                using (StreamWriter text = new StreamWriter(file, true))
                {
                    text.WriteLine("\t}");
                    text.WriteLine("}");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }
            return true;
        }

        public async Task<bool> GenerateFile(string directoryName, DynamicObjectDTO dynamicObjectDTO)
        {
            try
            {                
                string directory = await _directoryService.GetDirectory(directoryName,false);
                var file = Path.Combine(directory, dynamicObjectDTO.Service + dynamicObjectDTO.Page + "ViewModel.cs");
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);
                if (!System.IO.File.Exists(file))
                    System.IO.File.Create(file).Dispose();
                
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
