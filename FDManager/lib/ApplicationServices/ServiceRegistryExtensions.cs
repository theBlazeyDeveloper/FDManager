using Presentation.DomainServices;
using Microsoft.Extensions.DependencyInjection;

namespace Presentation
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
