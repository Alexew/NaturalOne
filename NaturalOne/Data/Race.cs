using Microsoft.Extensions.Localization;
using NaturalOne.Localization;

namespace NaturalOne.Data
{
    public abstract class Race
    {
        private readonly IList<string> _traits;

        protected Race()
        {
            _traits = new List<string>();
        }
        public IStringLocalizer T { get; set; } = Localizer.Instance;

        public string Name { get; protected set; } = default!;
        public string Description { get; protected set; } = default!;

        public IReadOnlyCollection<string> Traits => _traits.AsReadOnly();

        protected void AddTrait(string trait)
        {
            _traits.Add(trait);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}