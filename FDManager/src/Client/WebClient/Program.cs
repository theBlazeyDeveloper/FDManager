using Presentation;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebClient;
using WebClient.Interops;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7001") });

builder.Services.AddSingleton<MapJsInterop>();

builder.Services.AddCsvReader();

await builder
    .Build()
    .RunAsync();
