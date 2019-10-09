using Nexawo.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.UnitTests.Common
{
    public class CommandTestBase : IDisposable
    {
        protected readonly MainDbContext _context;

        public CommandTestBase()
        {
            _context = MainContextFactory.Create();
        }

        public void Dispose()
        {
            MainContextFactory.Destroy(_context);
        }
    }
}
