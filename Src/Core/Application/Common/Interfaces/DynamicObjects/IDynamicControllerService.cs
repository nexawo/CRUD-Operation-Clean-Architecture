using Nexawo.Application.DynamicObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nexawo.Application.Common.Interfaces.DynamicObjects
{
    public interface IDynamicControllerService
    {
        public Task<bool> GenerateFile(string directoryName, DynamicObjectDTO dynamicObjectDTO);
        public Task<bool> AddRefernces(string directoryName, DynamicObjectDTO dynamicObjectDTO);
        public Task<bool> Index(string directoryName, DynamicObjectDTO dynamicObjectDTO);
        public Task<bool> Get(string directoryName, DynamicObjectDTO dynamicObjectDTO);
        public Task<bool> Post(string directoryName, DynamicObjectDTO dynamicObjectDTO);
    }
}
