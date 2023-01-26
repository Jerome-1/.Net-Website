using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages.Guardians
{
    public class Draw : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }
        public WeaponDetails? Drew { get; set; }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            Drew = weapons.Where(i => i.Id == Id).FirstOrDefault();
        }

        public class WeaponDetails
        {
            public string? Name { get; set; }
            public string? WeaponType { get; set; }
            public int Id { get; set; }
            public string? UsedBy { get; set; }
            public string? Portrait { get; set; }
        }

        List<WeaponDetails> weapons = new List<WeaponDetails>()
        {
            new WeaponDetails {Name = "Austringer",WeaponType = "Hand-Cannon", Id = 1, UsedBy = "Suri An, Vylia Syk", Portrait = "austringer.jpg"},
            new WeaponDetails {Name = "Doctrine of Passing",  WeaponType = "Auto Rifle", Id = 2, UsedBy = "Hennesy Slokborn, Wan Shotto", Portrait = "Doctrine.jpg"},
            new WeaponDetails {Name = "1000 Yard-Stare",  WeaponType = "Sniper", Id = 3, UsedBy = "Suri Ann, Wan Shotto", Portrait = "1000.jpg"},
            new WeaponDetails {Name = "WitherHoard",  WeaponType  = "Grenade Launcher", Id = 4, UsedBy = "All Guardians", Portrait = "wither.jpg"}
        };
    }
}
