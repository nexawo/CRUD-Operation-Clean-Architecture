using Nexawo.Application.Common.Interfaces;
using Nexawo.Application.Common.Interfaces.DynamicObjects;
using Nexawo.Application.DynamicObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Nexawo.Infrastructure.DynamicObjects
{
    public class DynamicViewService : IDynamicViewService
    {
        private readonly IDirectoryService _directoryService;
        public DynamicViewService(IDirectoryService directoryService)
        {
            _directoryService = directoryService;
        }

        public async Task<bool> GenerateFile(string directoryName, DynamicObjectDTO dynamicObjectDTO)
        {
            try
            {
                string directory =await _directoryService.GetDirectory(directoryName + "\\" + dynamicObjectDTO.Page,true);
                var file = Path.Combine(directory, dynamicObjectDTO.Service + dynamicObjectDTO.Page + ".cshtml");
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
        public async Task<bool> AddContent(string directoryName, DynamicObjectDTO dynamicObjectDTO)
        {
            string directory = await _directoryService.GetDirectory(directoryName + "\\" + dynamicObjectDTO.Page,true);
            var file = Path.Combine(directory, dynamicObjectDTO.Service + dynamicObjectDTO.Page + ".cshtml");
            using (TextWriter text = new StreamWriter(file))
            {
                text.WriteLine("@model Nexawo.Application." + dynamicObjectDTO.Page + "." + dynamicObjectDTO.Service + dynamicObjectDTO.Page + "ViewModel");
                text.WriteLine("@{ \n ViewData[\"Title\"] = \"" + dynamicObjectDTO.Page + "\";\n}");
                text.WriteLine();
                text.WriteLine("<div class=" + "row" + ">");
                text.WriteLine(EmptyColumns(4));
                text.WriteLine("\t\t<div class=" + "col-md-4" + ">");
                text.WriteLine("\t\t\t<form asp-action=" + dynamicObjectDTO.Service + dynamicObjectDTO.Page + ">");
                text.WriteLine("\t\t\t\t<div asp-validation-summary=" + "ModelOnly" + " class=" + "text-danger" + "></div>");
            }
            foreach (var row in dynamicObjectDTO.FieldsDetailDTO)
            {
                using (StreamWriter text = new StreamWriter(file, true))
                {
                    text.WriteLine(FormGroup());
                    text.WriteLine(LabelFor(row.FieldName));
                    text.WriteLine(TextBoxFor(row.FieldName));
                    text.WriteLine(ErrorFor(row.FieldName));
                    text.WriteLine(CLoseDiv("\t\t\t\t"));
                }
            }
            using (StreamWriter text = new StreamWriter(file, true))
            {
                text.WriteLine(FormGroup());
                text.WriteLine(SubmitButtonFor("Save"));
                text.WriteLine(CLoseDiv("\t\t\t\t"));
            }
            using (StreamWriter text = new StreamWriter(file, true))
            {
                text.WriteLine(@""
                                + "\n\t\t</form>"
                                + "\n\t</div>"
                                + "\n</div>"
                               );
            }

            return true;
        }

        public string CLoseDiv(string sequence)
        {
            return string.Format(sequence + "</div>");
        }

        public string EmptyColumns(int columns)
        {
            return string.Format("<div class=\"{0}\"></div>", "col-md-" + columns + "");
        }

        public string ErrorFor(string fieldName)
        {
            return "\t\t\t\t\t<span asp-validation-for=" + fieldName + " class=" + "text-danger" + "></span>";
        }

        public string FormGroup()
        {
            return "\t\t\t\t<div class=" + "form-group" + ">";
        }        

        public string LabelFor(string fieldName)
        {
            return "\t\t\t\t\t<label asp-for=" + fieldName + " class=" + "control-label" + "></label>";
        }

        public string SubmitButtonFor(string fieldName)
        {
            return string.Format("\t\t\t\t\t<input type=submit value=\"{0}\" class=\"{1}\" />", fieldName, "btn btn-primary");
        }

        public string TextBoxFor(string fieldName)
        {
            return "\t\t\t\t\t<input asp-for=" + fieldName + " class=" + "form-control" + " />";
        }
    }
}
