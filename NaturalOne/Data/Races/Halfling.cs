using NaturalOne.Data.Traits;

namespace NaturalOne.Data.Races
{
    public class Halfling : Race
    {
        public Halfling()
        {
            Name = T["Races.Halfling.Name"];

            var abilityTrait = new AbilityScoreIncreaseTrait(Ability.Dexterity, 2)
            {
                Description = T["Traits.AbilityScoreIncrease.Description.Halfling"]
            };

            AddTrait(abilityTrait);
            AddTrait(new SpeedTrait(25));
        }
    }

    public class LightfootHalfling : Halfling
    {
        public LightfootHalfling()
        {
            Name = T["Races.LightfootHalfling.Name"];

            var abilityTrait = new AbilityScoreIncreaseTrait(Ability.Charisma, 1)
            {
                Description = T["Traits.AbilityScoreIncrease.Description.LightfootHalfling"]
            };

            AddTrait(abilityTrait);
        }
    }

    public class StoutHalfling : Halfling
    {
        public StoutHalfling()
        {
            Name = T["Races.StoutHalfling.Name"];

            var abilityTrait = new AbilityScoreIncreaseTrait(Ability.Constitution, 1)
            {
                Description = T["Traits.AbilityScoreIncrease.Description.StoutHalfling"]
            };

            AddTrait(abilityTrait);
        }
    }
}