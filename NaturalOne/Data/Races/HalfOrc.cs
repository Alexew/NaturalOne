namespace NaturalOne.Data.Races
{
    public class HalfOrc : Race
    {
        public HalfOrc()
        {
            Name = T["Races.HalfOrc.Name"];

            AddTrait("Darkvision");
            AddTrait("Menacing");
            AddTrait("Relentless Endurance");
            AddTrait("Savage Attacks");
        }
    }
}