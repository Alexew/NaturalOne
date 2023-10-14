using Microsoft.Extensions.Localization;

namespace NaturalOne.Localization
{
    public static class Localizer
    { 
        public static void SetLocalizer(IStringLocalizer localizer)
        {
            Instance = localizer;
        }

        public static IStringLocalizer Instance { get; private set; } = default!;
    }
}