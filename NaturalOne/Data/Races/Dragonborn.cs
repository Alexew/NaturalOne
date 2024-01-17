using NaturalOne.Data.Traits;

namespace NaturalOne.Data.Races
{
    public class Dragonborn : Race
    {
        public Dragonborn()
        {
            Name = T["Races.Dragonborn.Name"];

            var abilities = new Dictionary<Ability, int> { { Ability.Strength, 2 }, { Ability.Charisma, 1 } };
            var abilityTrait = new AbilityScoreIncreaseTrait(abilities)
            {
                Description = T["Traits.AbilityScoreIncrease.Description.Dragonborn"]
            };

            AddTrait(abilityTrait);
            AddTrait(new SpeedTrait(30));
        }
    }
}