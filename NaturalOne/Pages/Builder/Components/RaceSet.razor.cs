using Microsoft.AspNetCore.Components;
using NaturalOne.Data;

namespace NaturalOne.Pages.Builder.Components
{
    public partial class RaceSet
    {
        private readonly IList<RaceItem> _items;

        public RaceSet()
        {
            _items = new List<RaceItem>();
        }

        internal void Add(RaceItem item)
        {
            _items.Add(item);
        }

        internal async Task OnItemClicked(Race item)
        {
            await ValueChanged.InvokeAsync(item);
        }

        [Parameter]
        public RenderFragment ChildContent { get; set; } = default!;

        [Parameter]
        public EventCallback<Race> ValueChanged { get; set; }
    }
}