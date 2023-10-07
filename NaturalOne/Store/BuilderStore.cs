using Fluxor;
using NaturalOne.Data;

namespace NaturalOne.Store
{
    public record SelectRaceAction(Race Race);
    public record ChangeRaceAction();

    [FeatureState]
    public record BuilderState
    {
        public Race Race { get; init; } = default!;
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
    }
}