using NaturalOne.Data.Traits;
using NaturalOne.Models;

namespace NaturalOne.Data.Races
{
    public class HalfElf : Race
    {
        public HalfElf()
        {
            Name = T["Races.HalfElf.Name"];

            var abilityTrait = new AbilityScoreIncreaseTrait(Ability.Charisma, 2)
            {
                Description = T["Traits.AbilityScoreIncrease.Description.HalfElf"]
            };

            var values = SelectListHelper.ToSelectList<Ability>(Ability.Charisma);
            var template = new TraitEditorTemplate
            {
                Editors = new List<TraitEditor>
                {
                    new TraitEditor("HEASI1", "Select")
                    {
                        SelectItems = values
                    },
                    new TraitEditor("HEASI2", "Select")
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