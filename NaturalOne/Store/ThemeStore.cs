using Fluxor;
using NaturalOne.Services;

namespace NaturalOne.Store
{
    public record LoadThemeAction();
    public record ToggleThemeAction();
    public record SetThemeAction(bool IsDarkMode);

    [FeatureState]
    public record ThemeState
    {
        public bool IsDarkMode { get; set; }
    }

    public static class ThemeReducers
    {
        [ReducerMethod]
        public static ThemeState ReduceSetThemeAction(ThemeState state, SetThemeAction action)
        {
            return state with
            {
                IsDarkMode = action.IsDarkMode
            };
        }
    }

    public class ThemeEffects
    {
        private readonly IUserSettingsService _userSettingsService;

        public ThemeEffects(IUserSettingsService userSettingsService)
        {
            _userSettingsService = userSettingsService;
        }

        [EffectMethod(typeof(LoadThemeAction))]
        public async Task HandleLoadTheme(IDispatcher dispatcher)
        {
            var settings = await _userSettingsService.Get();

            dispatcher.Dispatch(new SetThemeAction(settings.IsDarkMode));
        }

        [EffectMethod(typeof(ToggleThemeAction))]
        public async Task HandleToggleTheme(IDispatcher dispatcher)
        {
            var settings = await _userSettingsService.Get();

            settings.IsDarkMode = !settings.IsDarkMode;

            await _userSettingsService.Set(settings);

            dispatcher.Dispatch(new SetThemeAction(settings.IsDarkMode));
        }
    }
}