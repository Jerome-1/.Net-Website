using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data
{
    public class GuardianDetails
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Description { get; set; }
        public string? Portrait { get; set; } = null;
        public string? Class { get; set; }
    }
}
