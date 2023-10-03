namespace NaturalOne.Data.Races
{
    public class Gnome : Race
    {
        public Gnome()
        {
            Name = "Gnome";

            AddTrait("Darkvision");
            AddTrait("Gnome Cunning");
        }
    }

    public class RockGnome : Race
    {
        public RockGnome()
        {
            Name = "Rock Gnome";

            AddTrait("Artificer’s Lore");
            AddTrait("Tinker");
        }
    }
}