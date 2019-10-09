using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nexawo.Application.Common.Interfaces
{
    public interface IDirectoryService
    {
        public Task<string> GetDirectory(string directoryName,bool isForWebApp = true);
    }
}
