namespace NaturalOne.Data.Races
{
    public class Elf : Race
    {
        public Elf()
        {
            Name = T["Races.Elf.Name"];

            AddTrait("Darkvision");
            AddTrait("Keen Senses");
            AddTrait("Fey Ancestry");
            AddTrait("Trance");
        }
    }

    public class HighElf : Elf
    {
        public HighElf()
        {
            Name = T["Races.HighElf.Name"];

            AddTrait("Elf Weapon Training");
            AddTrait("Cantrip");
            AddTrait("Extra Language");
        }
    }

    public class WoodElf : Elf
    {
        public WoodElf()
        {
            Name = T["Races.WoodElf.Name"];

            AddTrait("Elf Weapon Training");
            AddTrait("Fleet of Foot");
            AddTrait("Mask of the Wild");
        }
    }
}