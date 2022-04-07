using SuBilgiAPI.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;
namespace SuBilgiAPI.Models.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {


        private readonly SuBilgiDBContext _suBilgiDBContext;

        public EmployeeRepository(SuBilgiDBContext suBilgiDBContext)
        {
            this._suBilgiDBContext = suBilgiDBContext;
        }

    

        public Employee GetEmployee(int employeeID)
        {
            return _suBilgiDBContext.Employees.FirstOrDefault(x => x.Id == employeeID);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {

            return _suBilgiDBContext.Employees.ToList();

        }
    }
}
