namespace NaturalOne.Data.Races
{
    public class Dragonborn : Race
    {
        public Dragonborn()
        {
            Name = T["Races.Dragonborn.Name"];

            AddTrait("Draconic Ancestry");
            AddTrait("Breath Weapon");
            AddTrait("Damage Resistance");
        }
    }
}