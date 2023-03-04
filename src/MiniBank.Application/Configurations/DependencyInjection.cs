using Microsoft.Extensions.DependencyInjection;

namespace MiniBank.Application.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            return services;
        }
    }
}
