using Microsoft.AspNetCore.Components;
using NaturalOne.Data;

namespace NaturalOne.Pages.Builder.Components
{
    public partial class RaceItem
    {
        private bool _isOpen;

        public RaceItem()
        {
            Subraces = Array.Empty<Race>();
        }

        public bool HasSubraces => Subraces.Any();
        public bool IsOpen
        {
            get => HasSubraces && _isOpen;
            set => _isOpen = value;
        }

        private async Task OnSelectRaceHandler(Race race)
        {
            if (RaceSet is not null)
            {
                await RaceSet.OnItemClicked(race);
            }
        }

        protected override void OnInitialized()
        {
            RaceSet?.Add(this);

            base.OnInitialized();
        }

        [CascadingParameter]
        private RaceSet RaceSet { get; set; } = default!;

        [Parameter]
        public Race Race { get; set; } = default!;

        [Parameter]
        public Race[] Subraces { get; set; }
    }
}