using Fluxor;
using NaturalOne.Data;

namespace NaturalOne.Store
{
    public record SelectRaceAction(Race Race);
    public record ChangeRaceAction();
    public record SelectTraitEditorAction(string Key, string Value);

    [FeatureState]
    public record BuilderState
    {
        public Race Race { get; init; } = default!;
        public IDictionary<string, string> Traits { get; init; } = new Dictionary<string, string>();
    }

    public static class RaceReducers
    {
        [ReducerMethod]
        public static BuilderState ReduceSelectRaceAction(BuilderState state, SelectRaceAction action)
        {
            return state with
            {
                Race = action.Race
            };
        }

        [ReducerMethod(typeof(ChangeRaceAction))]
        public static BuilderState ReducerChangeRaceAction(BuilderState state)
        {
            return state with
            {
                Race = default!
            };
        }

        [ReducerMethod]
        public static BuilderState ReducerSelectTraitEditorAction(BuilderState state, SelectTraitEditorAction action)
        {
            state.Traits[action.Key] = action.Value;

            return state;
        }
    }
}