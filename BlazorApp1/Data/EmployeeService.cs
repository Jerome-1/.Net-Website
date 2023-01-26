using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class EmployeeService
    {
        #region Property
        private readonly AppDbContext _appDbContext;
        #endregion

        #region Constructor
        public EmployeeService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        #endregion

        #region Get List of Employees
        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _appDbContext.Employees.ToListAsync();
        }
        #endregion

        #region Insert Employee
        public async Task<bool> InsertEmployeeAsync(Employee employee)
        {
            await _appDbContext.Employees.AddAsync(employee);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Employee by Id
        public async Task<Employee> GetEmployeeAsync(int Id)
        {
            Employee employee = await _appDbContext.Employees.FirstOrDefaultAsync(c =>c.Id.Equals(Id));
            return employee;
        }
        #endregion

        #region Update Employee
        public async Task<bool> UpdateEmployeeAsync(Employee employee)
        {
            _appDbContext.Employees.Update(employee);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        #endregion


        #region Delete Employee
        public async Task <bool> DeleteEmployeeAsync(Employee employee)
        {
            _appDbContext.Remove(employee);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
