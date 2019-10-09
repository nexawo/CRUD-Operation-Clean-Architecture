using Nexawo.Application.DynamicObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nexawo.Application.Common.Interfaces.DynamicObjects
{
    public interface IDynamicViewService
    {
        Task<bool> GenerateFile(string directoryName, DynamicObjectDTO dynamicObjectDTO);
        Task<bool> AddContent(string directoryName, DynamicObjectDTO dynamicObjectDTO);
        string FormGroup();
        string LabelFor(string fieldName);
        string TextBoxFor(string fieldName);
        string ErrorFor(string fieldName);
        string SubmitButtonFor(string fieldName);
        string EmptyColumns(int columns);
        string CLoseDiv(string sequence);
    }
}
