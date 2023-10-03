namespace NaturalOne.Data.Races
{
    public class Human : Race
    {
        public Human()
        {
            Name = "Human";
        }
    }

    public class VariantHuman : Human
    {
        public VariantHuman()
        {
            Name = "Variant Human";

            AddTrait("Skills");
            AddTrait("Feat");
        }
    }
}