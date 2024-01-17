using NaturalOne.Data.Traits;

namespace NaturalOne.Data.Races
{
    public class Gnome : Race
    {
        public Gnome()
        {
            Name = T["Races.Gnome.Name"];

            var abilityTrait = new AbilityScoreIncreaseTrait(Ability.Intelligence, 2)
            {
                Description = T["Traits.AbilityScoreIncrease.Description.Gnome"]
            };

            AddTrait(abilityTrait);
            AddTrait(new SpeedTrait(25));
        }
    }

    public class RockGnome : Gnome
    {
        public RockGnome()
        {
            Name = T["Races.RockGnome.Name"];

            var abilityTrait = new AbilityScoreIncreaseTrait(Ability.Constitution, 1)
            {
                Description = T["Traits.AbilityScoreIncrease.Description.RockGnome"]
            };

            AddTrait(abilityTrait);
        }
    }
}