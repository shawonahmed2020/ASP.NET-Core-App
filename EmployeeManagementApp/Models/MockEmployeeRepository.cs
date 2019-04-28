using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Models
{
    public  class MockEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList=new List<Employee>()
            {
                new Employee(){Id = 1,Name = "Shawon",Email = "shawon@gamil.com", Department = Dept.CSE},
                new Employee(){Id = 2,Name = "Shawon Ahmed",Email = "shawon@gamil.com", Department = Dept.EEE},
                new Employee(){Id = 3, Name = "Asif Talukder" ,Email = "asif@gmail.com", Department = Dept.IT}
              
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        //public Employee Add(Employee employee)
        //{
        //   employee.Id = _employeeList.Max(e => e.Id)+1;
        //   _employeeList.Add(employee);
        //    return (employee);
        //}
        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id==id);
        }
    }
}
