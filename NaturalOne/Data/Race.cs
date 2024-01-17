using Microsoft.Extensions.Localization;
using NaturalOne.Data.Traits;
using NaturalOne.Localization;

namespace NaturalOne.Data
{
    public abstract class Race
    {
        private readonly IList<Trait> _traits;

        protected Race()
        {
            _traits = new List<Trait>();
        }

        public IStringLocalizer T { get; set; } = Localizer.Instance;

        public string Name { get; protected set; } = default!;
        public string Description { get; protected set; } = default!;

        public IReadOnlyCollection<Trait> Traits => _traits.AsReadOnly();

        protected void AddTrait(Trait trait)
        {
            _traits.Add(trait);
        }

        protected void AddTrait(string name, string description)
        {
            _traits.Add(new SimpleTrait(name, description));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}