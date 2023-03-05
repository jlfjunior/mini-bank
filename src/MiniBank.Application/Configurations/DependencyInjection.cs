using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MiniBank.Application.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {

            services.ConfigureMediatR();

            return services;
        }

        private static void ConfigureMediatR(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }

}
