namespace NaturalOne.Data.Races
{
    public class Dwarf : Race
    {
        public Dwarf()
        {
            Name = T["Races.Dwarf.Name"];

            AddTrait("Darkvision");
            AddTrait("Dwarven Resilience");
            AddTrait("Dwarven Combat Training");
            AddTrait("Tool Proficiency");
            AddTrait("Stonecunning");
        }
    }

    public class HillDwarf : Dwarf
    {
        public HillDwarf()
        {
            Name = T["Races.HillDwarf.Name"];

            AddTrait("Dwarven Toughness");
        }
    }

    public class MountainDwarf : Dwarf
    {
        public MountainDwarf()
        {
            Name = T["Races.MountainDwarf.Name"];

            AddTrait("Dwarven Armor Training");
        }
    }
}