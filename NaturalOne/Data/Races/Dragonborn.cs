namespace NaturalOne.Data.Races
{
    public class Dragonborn : Race
    {
        public Dragonborn()
        {
            Name = "Dragonborn";

            AddTrait("Draconic Ancestry");
            AddTrait("Breath Weapon");
            AddTrait("Damage Resistance");
        }
    }
}