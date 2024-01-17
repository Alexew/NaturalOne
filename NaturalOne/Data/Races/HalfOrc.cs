using NaturalOne.Data.Traits;

namespace NaturalOne.Data.Races
{
    public class HalfOrc : Race
    {
        public HalfOrc()
        {
            Name = T["Races.HalfOrc.Name"];

            var abilities = new Dictionary<Ability, int> { { Ability.Strength, 2 }, { Ability.Constitution, 1 } };
            var abilityTrait = new AbilityScoreIncreaseTrait(abilities)
            {
                Description = T["Traits.AbilityScoreIncrease.Description.HalfOrc"]
            };

            AddTrait(abilityTrait);
            AddTrait(new SpeedTrait(30));
        }
    }
}