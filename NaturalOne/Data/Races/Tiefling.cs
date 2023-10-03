namespace NaturalOne.Data.Races
{
    public class Tiefling : Race
    {
        public Tiefling()
        {
            Name = "Tiefling";

            AddTrait("Darkvision");
            AddTrait("Hellish Resistance");
            AddTrait("Infernal Legacy");
        }
    }
}