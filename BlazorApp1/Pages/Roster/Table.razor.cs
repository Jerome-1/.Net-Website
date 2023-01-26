using BlazorApp1.Data;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages
{
    public class TableData : ComponentBase
    {
        public IEnumerable<TableItems>? _items;
        public List<GuardianDetails>? _guardianDetails;
        private const string Uri = $"/guardian";
        public string EmptyText = string.Empty;

        [Inject]
        protected NavigationManager NavigationManager { get; set; } = default!;

        [Inject]
        protected GuardianDetailsService guardianService { get; set; } = default!;

        protected override async Task OnInitializedAsync()
        {
            base.OnInitialized();
            EmptyText = "Information Loading";
            _guardianDetails = await Task.Run(() => guardianService.GetRosterAsync());

            if (_guardianDetails.Count == 0)
                EmptyText = "No information to present";
            _items = new List<TableItems>()
            {
                new TableItems { Id = 1, Name = "Suri An", Age = 400, Description = "I am a Lightbearer(Hunter) from the time of the Collapse." },
                new TableItems { Id = 2, Name = "Vylia Syk", Age = 22, Description = "I am a Guardian from the post Collapse era." },
                new TableItems { Id = 3, Name = "Hennesy Slokborn", Age = 382, Description = "I am a Lightbearer(Warlock => Titan) from the time of the Collaspe." },
                new TableItems { Id = 4, Name = "Riven Kako", Age = 500, Description = "I am the last."},
                new TableItems { Id = 5, Name = "Wan Shotto", Age = 200, Description = "I was the first. Now I'm forgotten."},
                new TableItems { Id = 6, Name = "Jiko-Chu", Age = 18, Description = "New on the scene."}
            };
        }

        public void OnRowClicked(int GuardianId)
            => NavigationManager.NavigateTo($"{Uri}/{GuardianId}");
    }
}
