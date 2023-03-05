using Microsoft.Extensions.DependencyInjection;
using MiniBank.Domain.Repositories;
using MiniBank.Infrastructure.Repositories;

namespace MiniBank.Infrastructure.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataLayer(this IServiceCollection services)
        {
            services.AddDbContext<Context>();
            services.AddDbContext<ReadOnlyContext>();

            services.AddTransient<IAccountRepository, AccountRepository>();

            return services;
        }
    }
}
