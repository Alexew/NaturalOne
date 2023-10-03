namespace NaturalOne.Data.Races
{
    public class HalfOrc : Race
    {
        public HalfOrc()
        {
            Name = "Half-Orc";

            AddTrait("Darkvision");
            AddTrait("Menacing");
            AddTrait("Relentless Endurance");
            AddTrait("Savage Attacks");
        }
    }
}