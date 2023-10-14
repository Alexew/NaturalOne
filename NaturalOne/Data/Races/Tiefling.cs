namespace NaturalOne.Data.Races
{
    public class Tiefling : Race
    {
        public Tiefling()
        {
            Name = T["Races.Tiefling.Name"];

            AddTrait("Darkvision");
            AddTrait("Hellish Resistance");
            AddTrait("Infernal Legacy");
        }
    }
}