using Nexawo.Application.DynamicObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nexawo.Application.Common.Interfaces.DynamicObjects
{
    public interface IDynamicModelService
    {
        public Task<bool> GenerateFile(string directoryName, DynamicObjectDTO dynamicObjectDTO);
        public Task<bool> AddContent(string directoryName, DynamicObjectDTO dynamicObjectDTO);        

    }
}
