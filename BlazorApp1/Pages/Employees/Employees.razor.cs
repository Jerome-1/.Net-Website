using BlazorApp1.Data;
using Microsoft.AspNetCore.Components;
/*
namespace BlazorApp1.Pages
{
    public class Employee : ComponentBase
    {
        public List<Employee>? EmpObj;
        [Inject]
        protected NavigationManager NavigationManager { get; set; } = default!;

        [Inject]
        protected EmployeeService employeeService { get; set; } = default!;
        protected override async Task OnInitializedAsync()
        {
            EmpObj = await Task.Run(() => employeeService.GetAllEmployeesAsync());
        }
        public void GoToEdit(int Id)
            => NavigationManager.NavigateTo($"EditEmployee/{Id}");
        public void GoToDelete(int Id)
            => NavigationManager.NavigateTo($"DeleteEmployee/{Id}");
    }
}
*/