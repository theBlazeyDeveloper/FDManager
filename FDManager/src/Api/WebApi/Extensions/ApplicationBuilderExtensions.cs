using Data.FireStationAggregate;
using Shared.Interfaces;

namespace WebApi.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder CheckDBConnection(this IApplicationBuilder app)         
        {
            var mongoDb = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<IRepository<FireStation>>();

            if(mongoDb.IsConnected)            
                Console.BackgroundColor = ConsoleColor.Green;            
            else            
                Console.BackgroundColor = ConsoleColor.Red;
            
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"Connection to MongoDB { (mongoDb.IsConnected ? "Good" : "Bad") }");

            return app;
        }
    }
}
