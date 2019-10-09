using Nexawo.Domain.Entities.Main;
using Nexawo.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.System.Commands.SeedSampleData
{
    public class SampleDataSeeder
    {
        private readonly IMainDbContext _context;
        //private readonly IUserManager _userManager;

        private readonly Dictionary<int, Tenant> Employees = new Dictionary<int, Tenant>();
        

        public SampleDataSeeder(IMainDbContext context)//, IUserManager userManager)
        {
            _context = context;
            //_userManager = userManager;
        }


        private static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();
        }

        public async Task SeedAllAsync(CancellationToken cancellationToken)
        {
            if (_context.Tenants.Any())
            {
                return;
            }
            /*
            await Sed(cancellationToken);

            await SeedRegionsAsync(cancellationToken);

            await SeedTerritoriesAsync(cancellationToken);

            await SeedEmployeesAsync(cancellationToken);

            await SeedCategoriesAsync(cancellationToken);

            await SeedShippersAsync(cancellationToken);

            await SeedSuppliersAsync(cancellationToken);

            await SeedProductsAsync(cancellationToken);

            await SeedOrdersAsync(cancellationToken);

            await SeedUsersAsync(cancellationToken);
            */
        }
    }

    
}
