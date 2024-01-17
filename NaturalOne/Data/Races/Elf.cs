using NaturalOne.Data.Traits;

namespace NaturalOne.Data.Races
{
    public class Elf : Race
    {
        public Elf()
        {
            Name = T["Races.Elf.Name"];

            var abilityTrait = new AbilityScoreIncreaseTrait(Ability.Dexterity, 2)
            {
                Description = T["Traits.AbilityScoreIncrease.Description.Elf"]
            };

            AddTrait(abilityTrait);
            AddTrait(new SpeedTrait(30));
        }
    }

    public class HighElf : Elf
    {
        public HighElf()
        {
            Name = T["Races.HighElf.Name"];

            var abilityTrait = new AbilityScoreIncreaseTrait(Ability.Intelligence, 1)
            {
                Description = T["Traits.AbilityScoreIncrease.Description.HighElf"]
            };

            AddTrait(abilityTrait);
        }
    }

    public class WoodElf : Elf
    {
        public WoodElf()
        {
            Name = T["Races.WoodElf.Name"];

            var abilityTrait = new AbilityScoreIncreaseTrait(Ability.Wisdom, 1)
            {
                Description = T["Traits.AbilityScoreIncrease.Description.WoodElf"]
            };

            AddTrait(abilityTrait);
            AddTrait(new SpeedTrait(35, T["Traits.Speed.Name.WoodElf"], T["Traits.Speed.Description.WoodElf"]));
        }
    }
}