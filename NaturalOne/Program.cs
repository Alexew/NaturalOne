using Blazored.LocalStorage;
using Fluxor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using NaturalOne.Services;

namespace NaturalOne
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddLocalization();

            builder.Services.AddMudServices();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddFluxor(fo => fo.ScanAssemblies(typeof(Program).Assembly));

            builder.Services.AddScoped<IUserSettingsService, UserSettingsService>();

            var host = builder.Build();

            host.SetLocalizer();

            await host.SetDefaultCulture();
            await host.RunAsync();
        }
    }
}