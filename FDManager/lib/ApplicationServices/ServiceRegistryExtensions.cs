using ApplicationServices.DomainServices;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationServices
{
    public static class ServiceRegistryExtensions
    {
        public static IServiceCollection AddCsvReader(this IServiceCollection services)
        {
            services.AddSingleton<ICsvReader, CsvReader>();

            return services;
        }
    }
}
