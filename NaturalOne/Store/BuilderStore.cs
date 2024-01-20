using Fluxor;
using NaturalOne.Data;

namespace NaturalOne.Store
{
    public record SelectRaceAction(Race Race);
    public record ChangeRaceAction();
    public record SelectTraitEditorAction(string Key, string Value);
    public record SubAbilityScoreAction(Ability Ability);
    public record AddAbilityScoreAction(Ability Ability);

    [FeatureState]
    public record BuilderState
    {
        public Race Race { get; init; } = default!;
        public IDictionary<string, string> Traits { get; init; } = new Dictionary<string, string>();

        public int PointsRemaining { get; init; } = 27;
        public IDictionary<Ability, int> AbilityScore { get; init; } = new Dictionary<Ability, int>
        {
            { Ability.Strength, 8 },
            { Ability.Dexterity, 8 },
            { Ability.Constitution, 8 },
            { Ability.Intelligence, 8 },
            { Ability.Wisdom, 8 },
            { Ability.Charisma, 8 }
        };
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

        [ReducerMethod]
        public static BuilderState ReducerSubAbilityScoreAction(BuilderState state, SubAbilityScoreAction action)
        {
            state.AbilityScore[action.Ability]--;

            return state with
            {
                PointsRemaining = CalcPointsRemaining(state)
            };
        }

        [ReducerMethod]
        public static BuilderState ReducerAddAbilityScoreAction(BuilderState state, AddAbilityScoreAction action)
        {
            state.AbilityScore[action.Ability]++;

            return state with
            {
                PointsRemaining = CalcPointsRemaining(state)
            };
        }

        private static int CalcPointsRemaining(BuilderState state)
        {
            var pointsRemaining = 27;

            foreach (var ability in state.AbilityScore)
            {
                pointsRemaining += 8 - ability.Value;

                if (ability.Value > 13)
                {
                    pointsRemaining += 13 - ability.Value;
                }
            }

            return pointsRemaining;
        }
    }
}