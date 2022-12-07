using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2WebAPI.repo
{
    interface IEmployeeRepo
    {
        Employee GetEmployee(int id);

        public IEnumerable<Employee> GetEmployeeDetails();
    }
}
