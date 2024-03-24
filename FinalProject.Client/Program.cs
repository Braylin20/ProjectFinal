using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<NotificationService>();
builder.Services.AddBlazorBootstrap();
await builder.Build().RunAsync();
