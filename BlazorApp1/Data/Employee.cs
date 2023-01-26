using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Employer { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
    }
}
