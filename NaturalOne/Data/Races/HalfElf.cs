namespace NaturalOne.Data.Races
{
    public class HalfElf : Race
    {
        public HalfElf()
        {
            Name = T["Races.HalfElf.Name"];

            AddTrait("Darkvision");
            AddTrait("Fey Ancestry");
            AddTrait("Skill Versatility");
        }
    }
}