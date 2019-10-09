using Microsoft.AspNetCore.Hosting;
using Nexawo.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Nexawo.Infrastructure
{
    public class DirectoryService : IDirectoryService
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public DirectoryService(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public async Task<string> GetDirectory(string directoryName,bool isForWebApp = true)
        {
            string finalPath = string.Empty;
            string projectRootPath = _hostingEnvironment.ContentRootPath;
            if (isForWebApp)
                finalPath = projectRootPath + "\\" + directoryName;
            else
            {
                var path4 = Directory.GetCurrentDirectory();

                string firstCharacter = path4.Substring(0, 1);
                int startIndex = path4.IndexOf(firstCharacter);
                int endIndex = path4.IndexOf("Src");
                string text = path4.Substring(startIndex, endIndex);
                finalPath = Path.Combine(text, directoryName);
            }
            return finalPath;
        }
    }
}
