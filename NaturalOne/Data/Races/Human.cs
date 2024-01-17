using NaturalOne.Data.Traits;
using NaturalOne.Models;

namespace NaturalOne.Data.Races
{
    public class Human : Race
    {
        public Human()
        {
            Name = T["Races.Human.Name"];

            var abilities = new Dictionary<Ability, int>
            {
                { Ability.Strength, 1 },
                { Ability.Dexterity, 1 },
                { Ability.Constitution, 1 },
                { Ability.Intelligence, 1 },
                { Ability.Wisdom, 1 },
                { Ability.Charisma, 1 }
            };
            var abilityTrait = new AbilityScoreIncreaseTrait(abilities)
            {
                Description = T["Traits.AbilityScoreIncrease.Description.Human"]
            };

            AddTrait(abilityTrait);
            AddTrait(new SpeedTrait(30));
        }
    }

    public class VariantHuman : Race
    {
        public VariantHuman()
        {
            Name = T["Races.VariantHuman.Name"];

            var abilityTrait = new AbilityScoreIncreaseTrait()
            {
                Description = T["Traits.AbilityScoreIncrease.Description.VariantHuman"]
            };

            var values = SelectListHelper.ToSelectList<Ability>();
            var template = new TraitEditorTemplate
            {
                Editors = new List<TraitEditor>
                {
                    new TraitEditor("VHASI1", "Select")
                    {
                        SelectItems = values
                    },
                    new TraitEditor("VHASI2", "Select")
                    {
                        SelectItems = values
                    }
                }
            };

            abilityTrait.AddTemplate(template);

            AddTrait(abilityTrait);
            AddTrait(new SpeedTrait(30));
        }
    }
}