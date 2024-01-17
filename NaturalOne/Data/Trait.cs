using Microsoft.Extensions.Localization;
using NaturalOne.Localization;
using NaturalOne.Models;

namespace NaturalOne.Data
{
    public abstract class Trait
    {
        private readonly IList<TraitEditorTemplate> _templates;

        protected Trait(string systemName)
        {
            _templates = new List<TraitEditorTemplate>();

            SystemName = systemName;
        }

        public IStringLocalizer T { get; set; } = Localizer.Instance;

        public string SystemName { get; }
        public string Name { get; init; } = default!;
        public string Description { get; init; } = default!;

        public IReadOnlyCollection<TraitEditorTemplate> Templates => _templates.AsReadOnly();

        public void AddTemplate(TraitEditorTemplate template)
        {
            _templates.Add(template);
        }
    }
}