using Microsoft.AspNetCore.Components;

namespace NaturalOne.Pages.Builder.Components
{
    public partial class TraitSet
    {
        private readonly IList<TraitItem> _items;

        public TraitSet()
        {
            _items = new List<TraitItem>();
        }

        internal void Add(TraitItem item)
        {
            _items.Add(item);
        }

        [Parameter]
        public RenderFragment ChildContent { get; set; } = default!;
    }
}