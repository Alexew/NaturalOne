namespace NaturalOne.Data.Races
{
    public class Dwarf : Race
    {
        public Dwarf()
        {
            Name = "Dwarf";

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
            Name = "Hill Dwarf";

            AddTrait("Dwarven Toughness");
        }
    }

    public class MountainDwarf : Dwarf
    {
        public MountainDwarf()
        {
            Name = "Mountain Dwarf";

            AddTrait("Dwarven Armor Training");
        }
    }
}