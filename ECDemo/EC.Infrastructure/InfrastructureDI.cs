using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.Infrastructure
{
    public static class InfrastructureDI
    {
        public static IServiceCollection ServiceTransfer(this IServiceCollection services,string connectionString)
        {
            services.AddScoped(typeof(IApplicationDbContextFactory), (dbContext) =>
            {
                return new ApplicationDbContextFactory(connectionString);
            });
         return services;
        }
    }
}
