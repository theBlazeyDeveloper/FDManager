using Infrastructure.Services;
using Shared.Interfaces;
using Shared.Options;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceRegistryExtensions
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, Action<MongoDbOptions> options)
        {
            services.Configure(options);

            services.AddScoped(typeof(IRepository<>), typeof(MongoDbRepository<>));

            return services;
        }
    }
}
