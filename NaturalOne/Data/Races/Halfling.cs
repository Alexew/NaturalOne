namespace NaturalOne.Data.Races
{
    public class Halfling : Race
    {
        public Halfling()
        {
            Name = T["Races.Halfling.Name"];

            AddTrait("Lucky");
            AddTrait("Brave");
            AddTrait("Halfling Nimbleness");
        }
    }

    public class LightfootHalfling : Halfling
    {
        public LightfootHalfling()
        {
            Name = T["Races.LightfootHalfling.Name"];

            AddTrait("Naturally Stealthy");
        }
    }

    public class StoutHalfling : Halfling
    {
        public StoutHalfling()
        {
            Name = T["Races.StoutHalfling.Name"];

            AddTrait("Stout Resilience");
        }
    }
}