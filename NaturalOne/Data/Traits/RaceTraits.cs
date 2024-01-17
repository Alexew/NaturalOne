namespace NaturalOne.Data.Traits
{
    public sealed class AbilityScoreIncreaseTrait : Trait
    {
        private readonly IDictionary<Ability, int> _abilities = new Dictionary<Ability, int>
        {
            { Ability.Strength, 0 },
            { Ability.Dexterity, 0 },
            { Ability.Constitution, 0 },
            { Ability.Intelligence, 0 },
            { Ability.Wisdom, 0 },
            { Ability.Charisma, 0 }
        };

        public AbilityScoreIncreaseTrait(IDictionary<Ability, int> abilities) : base("AbilityScoreIncrease")
        {
            Name = T["Traits.AbilityScoreIncrease.Name"];

            foreach (var ability in abilities)
            {
                _abilities[ability.Key] += ability.Value;
            }
        }

        public AbilityScoreIncreaseTrait(Ability ability, int score)
            : this(new Dictionary<Ability, int> { { ability, score } }) { }

        public AbilityScoreIncreaseTrait()
            : this (new Dictionary<Ability, int>()) { }

        public IReadOnlyDictionary<Ability, int> Abilities => _abilities.AsReadOnly();
    }

    public sealed class SpeedTrait : Trait
    {
        public SpeedTrait(int speed, string? name = null, string? description = null) : base("Speed")
        {
            Name = name ?? T["Traits.Speed.Name"];
            Description = string.Format(description ?? T["Traits.Speed.Description"], speed);
            Speed = speed;
        }

        public int Speed { get; }
    }

    public sealed class SimpleTrait : Trait
    {
        public SimpleTrait(string name, string description) : base("Simple")
        {
            Name = name;
            Description = description;
        }
    }
}