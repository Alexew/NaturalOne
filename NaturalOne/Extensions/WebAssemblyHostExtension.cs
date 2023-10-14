using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Localization;
using NaturalOne.Localization;
using NaturalOne.Services;
using System.Globalization;

namespace NaturalOne
{
    public static class WebAssemblyHostExtension
    {
        public async static Task SetDefaultCulture(this WebAssemblyHost host)
        {
            var userSettingsService = host.Services.GetService<IUserSettingsService>();
            var culture = new CultureInfo("en-US");

            if (userSettingsService is not null)
            {
                var userSettings = await userSettingsService.Get();

                if (userSettings?.CultureName is not null)
                {
                    culture = new CultureInfo(userSettings.CultureName);
                }
            }

            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
        }

        public static void SetLocalizer(this WebAssemblyHost host)
        {
            var factory = host.Services.GetService<IStringLocalizerFactory>();

            if (factory is not null)
            {
                var localizer = factory.Create(typeof(Resource));

                Localizer.SetLocalizer(localizer);
            }
        }
    }
}