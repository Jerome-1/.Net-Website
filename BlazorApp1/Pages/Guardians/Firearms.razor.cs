using BlazorApp1.Data;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages
{
    public class Weapons : ComponentBase
    {
        public IEnumerable<RecommendedFirearms>? _items;
        public string? Uri = $"/firearm";
        [Inject]
        protected NavigationManager NavigationManager { get; set; } = default!;
        protected override void OnInitialized()
        {
            base.OnInitialized();
            _items = new List<RecommendedFirearms>()
            {
                new RecommendedFirearms {Name = "Austringer",WeaponType = "Hand-Cannon", Id = 1, UsedBy = "Suri An, Vylia Syk"},
                new RecommendedFirearms {Name = "Doctrine of Passing",  WeaponType = "Auto Rifle", Id = 2, UsedBy = "Hennesy Slokborn, Wan Shotto"},
                new RecommendedFirearms {Name = "1000 Yard-Stare",  WeaponType = "Sniper", Id = 3, UsedBy = "Suri Ann, Wan Shotto"},
                new RecommendedFirearms {Name = "WitherHoard",  WeaponType  = "Grenade Launcher", Id = 4, UsedBy = "All Guardians"}

            };
        }
        public void OnRowClicked(int WeaponId)
            => NavigationManager.NavigateTo($"{Uri}/{WeaponId}");
    }
}
