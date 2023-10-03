namespace NaturalOne.Data.Races
{
    public class HalfElf : Race
    {
        public HalfElf()
        {
            Name = "Half-Elf";

            AddTrait("Darkvision");
            AddTrait("Fey Ancestry");
            AddTrait("Skill Versatility");
        }
    }
}