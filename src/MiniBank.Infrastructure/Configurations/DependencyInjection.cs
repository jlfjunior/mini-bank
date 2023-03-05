using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MiniBank.Domain.Repositories;
using MiniBank.Infrastructure.Repositories;

namespace MiniBank.Infrastructure.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Context>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString("MiniBank"));
            });

            services.AddDbContext<ReadOnlyContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString("MiniBankReadOnly"));
            });

            services.AddTransient<IAccountRepository, AccountRepository>();

            return services;
        }
    }
}
