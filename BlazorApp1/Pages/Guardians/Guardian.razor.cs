using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages
{
    public class GuardianInfo : ComponentBase
    {
        public const string Solo = $"Guardian";
        protected NavigationManager NavigationManager { get; set; } = default!;
        [Parameter]
        public int Id { get; set; }
        public GuardianDetails? Details { get; set; }

        protected override void OnInitialized()
        {
            Details = guardianDetails?.Where(i => i.Id == Id).FirstOrDefault();
        }
        public class GuardianDetails
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public int? Age { get; set; }
            public string? Description { get; set; }
            public string? Portrait { get; set; } = null;
            public string? Class { get; set; }
        }

        List<GuardianDetails>? guardianDetails = new List<GuardianDetails>
        {
                new GuardianDetails { Id = 1, Name = "Suri An", Age = 400, Description = "I am a Lightbearer(Hunter) from the time of the Collapse.", Portrait = "Hunter.jpg", Class ="Hunter" },
                new GuardianDetails { Id = 2, Name = "Vylia Syk", Age = 22, Description = "I am a Guardian from the post Collapse era.", Portrait = "Hunter.jpg", Class = "Hunter" },
                new GuardianDetails { Id = 3, Name = "Hennesy Slokborn", Age = 382, Description = "I am a Lightbearer(Warlock => Titan) from the time of the Collaspe.", Portrait = "Guardian.jpg", Class = "Titan" },
                new GuardianDetails { Id = 4, Name = "Riven Kako", Age = 500, Description = "I am the last.", Portrait = "Warlock.jpg", Class = "Warlock"},
                new GuardianDetails { Id = 5, Name = "Wan Shotto", Age = 200, Description = "I was the first. Now I'm forgotten.", Portrait = "Guardian.jpg", Class = "Titan"},
                new GuardianDetails { Id = 6, Name = "Jiko-Chu", Age = 18, Description = "New on the scene.", Portrait = "Hunter.jpg", Class = "Hunter"}
        };
    }
}
