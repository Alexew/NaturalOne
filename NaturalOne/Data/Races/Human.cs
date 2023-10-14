namespace NaturalOne.Data.Races
{
    public class Human : Race
    {
        public Human()
        {
            Name = T["Races.Human.Name"];
        }
    }

    public class VariantHuman : Human
    {
        public VariantHuman()
        {
            Name = T["Races.VariantHuman.Name"];

            AddTrait("Skills");
            AddTrait("Feat");
        }
    }
}