using Fluxor;
using NaturalOne.Data;

namespace NaturalOne.Store
{
    public record SelectRaceAction(Race Race);

    [FeatureState]
    public record BuilderStore
    {
        public Race Race { get; init; } = default!;
    }

    public static class RaceReducers
    {
        [ReducerMethod]
        public static BuilderStore ReduceSelectRaceAction(BuilderStore state, SelectRaceAction action)
        {
            return state with
            {
                Race = action.Race
            };
        }
    }
}