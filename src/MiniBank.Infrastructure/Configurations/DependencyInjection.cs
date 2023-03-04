using Microsoft.Extensions.DependencyInjection;

namespace MiniBank.Infrastructure.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataLayer(this IServiceCollection services)
        {
            return services;
        }
    }
}
