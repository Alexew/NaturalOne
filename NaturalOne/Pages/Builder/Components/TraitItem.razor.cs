using Microsoft.AspNetCore.Components;
using NaturalOne.Data;

namespace NaturalOne.Pages.Builder.Components
{
    public partial class TraitItem
    {
        protected override void OnInitialized()
        {
            TraitSet?.Add(this);

            base.OnInitialized();
        }

        [CascadingParameter]
        private TraitSet TraitSet { get; set; } = default!;

        [Parameter]
        public Trait Trait { get; set; } = default!;
    }
}