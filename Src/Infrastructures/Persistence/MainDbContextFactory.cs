using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Persistence
{
    public class MainDbContextFactory : DesignTimeDbContextFactoryBase<MainDbContext>
    {
        protected override MainDbContext CreateNewInstance(DbContextOptions<MainDbContext> options)
        {
            return new MainDbContext(options);
        }
    }
}
