using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddController.Modal
{
    public class MockEmployeeRepo : IEmployRepository 
    {
        public List<Employee> _employee;

        public MockEmployeeRepo() {
            new Employee() { id = 1 ,name = "AVI" ,age = 22 , email = "avi@gmail.com" };
            new Employee() { id = 2, name = "Akshtha" , age = 22, email ="Akshatha @gmail.com" };
            new Employee() { id = 3, name ="Namana" , age = 22, email = "Nama@gmail.com" };
            new Employee() { id = 4, name ="Prajwal" , age = 22 , email = "prajwal@gmail.com" };
        }

        Employee IEmployRepository.GetEmployee(int id) {

            return _employee.First(e => e.id == id);
        }
    }
}
