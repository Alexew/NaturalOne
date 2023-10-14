using Fluxor;
using NaturalOne.Services;
using System.Globalization;

namespace NaturalOne.Store
{
    public record LoadCultureAction();
    public record SelectCultureAction(CultureInfo Culture);
    public record SetCultureAction(CultureInfo Culture);

    [FeatureState]
    public record CultureState
    {
        public CultureInfo Culture { get; set; } = default!;
    }

    public static class CultureReducers
    {
        [ReducerMethod]
        public static CultureState ReduceSetCultureAction(CultureState state, SetCultureAction action)
        {
            return state with
            {
                Culture = action.Culture
            };
        }
    }

    public class CultureEffects
    {
        private readonly IUserSettingsService _userSettingsService;

        public CultureEffects(IUserSettingsService userSettingsService)
        {
            _userSettingsService = userSettingsService;
        }

        [EffectMethod(typeof(LoadCultureAction))]
        public async Task HandleLoadCulture(IDispatcher dispatcher)
        {
            var settings = await _userSettingsService.Get();

            dispatcher.Dispatch(new SetCultureAction(new CultureInfo(settings.CultureName)));
        }

        [EffectMethod]
        public async Task HandleSelectCulture(SelectCultureAction action, IDispatcher dispatcher)
        {
            var settings = await _userSettingsService.Get();

            settings.CultureName = action.Culture.Name;

            await _userSettingsService.Set(settings);

            dispatcher.Dispatch(new SetCultureAction(action.Culture));
        }
    }
}