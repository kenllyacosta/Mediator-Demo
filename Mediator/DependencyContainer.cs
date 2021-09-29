using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Mediator
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddMediator(this IServiceCollection services, Assembly handlersAssembly)
        {
            services.AddSingleton<IMediator>(provider => new Mediator(handlersAssembly));
            return services;
        }
    }
}
