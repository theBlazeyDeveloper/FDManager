using BingMaps.Interfaces;
using BingMaps.Options;
using BingMaps.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceRegistryExtensions
    {
        public static IServiceCollection AddBingMaps(this IServiceCollection services, Action<BingMapOptions> opts)
        {
            services.Configure(opts);

            services.AddScoped<IBingMapWebServices, BingMapWebServices>();

            return services;
        }
    }
}