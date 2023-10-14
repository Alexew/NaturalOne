namespace NaturalOne.Data.Races
{
    public class Gnome : Race
    {
        public Gnome()
        {
            Name = T["Races.Gnome.Name"];

            AddTrait("Darkvision");
            AddTrait("Gnome Cunning");
        }
    }

    public class RockGnome : Race
    {
        public RockGnome()
        {
            Name = T["Races.RockGnome.Name"];

            AddTrait("Artificer’s Lore");
            AddTrait("Tinker");
        }
    }
}