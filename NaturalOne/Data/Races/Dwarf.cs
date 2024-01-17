using NaturalOne.Data.Traits;

namespace NaturalOne.Data.Races
{
    public class Dwarf : Race
    {
        public Dwarf()
        {
            Name = T["Races.Dwarf.Name"];

            var abilityTrait = new AbilityScoreIncreaseTrait(Ability.Constitution, 2)
            {
                Description = T["Traits.AbilityScoreIncrease.Description.Dwarf"]
            };

            AddTrait(abilityTrait);
            AddTrait(new SpeedTrait(25, description: T["Traits.Speed.Description.Dwarf"]));
        }
    }

    public class HillDwarf : Dwarf
    {
        public HillDwarf()
        {
            Name = T["Races.HillDwarf.Name"];

            var abilityTrait = new AbilityScoreIncreaseTrait(Ability.Wisdom, 1)
            {
                Description = T["Traits.AbilityScoreIncrease.Description.HillDwarf"]
            };

            AddTrait(abilityTrait);
        }
    }

    public class MountainDwarf : Dwarf
    {
        public MountainDwarf()
        {
            Name = T["Races.MountainDwarf.Name"];

            var abilityTrait = new AbilityScoreIncreaseTrait(Ability.Strength, 2)
            {
                Description = T["Traits.AbilityScoreIncrease.Description.MountainDwarf"]
            };

            AddTrait(abilityTrait);
        }
    }
}