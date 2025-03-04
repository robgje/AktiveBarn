using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using AktiveBarn.Shared.Services;
using AktiveBarn.Web.Client.Services;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the AktiveBarn.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();
builder.Services.AddMudServices();

await builder.Build().RunAsync();
