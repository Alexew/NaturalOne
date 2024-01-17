using NaturalOne.Data.Traits;

namespace NaturalOne.Data.Races
{
    public class Tiefling : Race
    {
        public Tiefling()
        {
            Name = T["Races.Tiefling.Name"];

            var abilities = new Dictionary<Ability, int> { { Ability.Intelligence, 1 }, { Ability.Charisma, 2 } };
            var abilityTrait = new AbilityScoreIncreaseTrait(abilities)
            {
                Description = T["Traits.AbilityScoreIncrease.Description.Tiefling"]
            };

            AddTrait(abilityTrait);
            AddTrait(new SpeedTrait(30));
        }
    }
}