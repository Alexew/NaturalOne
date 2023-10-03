namespace NaturalOne.Data.Races
{
    public class Halfling : Race
    {
        public Halfling()
        {
            Name = "Halfling";

            AddTrait("Lucky");
            AddTrait("Brave");
            AddTrait("Halfling Nimbleness");
        }
    }

    public class LightfootHalfling : Halfling
    {
        public LightfootHalfling()
        {
            Name = "Lightfoot Halfling";

            AddTrait("Naturally Stealthy");
        }
    }

    public class StoutHalfling : Halfling
    {
        public StoutHalfling()
        {
            Name = "Stout Halfling";

            AddTrait("Stout Resilience");
        }
    }
}