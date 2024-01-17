using Microsoft.Extensions.Localization;
using NaturalOne.Localization;

namespace NaturalOne
{
    public static class LocalizationExtensions
    {
        public static IStringLocalizer T { get; set; } = Localizer.Instance;

        public static string GetLocalizedEnum<TEnum>(this TEnum enumValue)
            where TEnum : struct
        {
            var type = typeof(TEnum);
            var enumName = type.Name;

            var enumValueStr = enumValue.ToString();
            var resourceName = "Enums." + enumName + '.' + enumValueStr;

            return T[resourceName];
        }
    }
}