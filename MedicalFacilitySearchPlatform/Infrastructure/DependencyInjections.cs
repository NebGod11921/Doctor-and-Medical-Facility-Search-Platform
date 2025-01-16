using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection serivces, string DatabaseConnection)
        {
            serivces.AddDbContext<AppDbContext>(DatabaseConnection);
        }
    }
}
