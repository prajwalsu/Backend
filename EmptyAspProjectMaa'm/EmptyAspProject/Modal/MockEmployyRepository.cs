using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EmptyAspProject.Modal {
    public class MockEmployyRepository : IEmployeeRepository {
        private List<Employee> _employee = new List<Employee>();
        public MockEmployyRepository() {
            _employee.Add(new Employee() { id = 1, name = "AVI", age = 22, email = "avi111@gmail.com" });
            _employee.Add(new Employee() { id = 2, name = "AKSHATA", age = 22, email = "AKSHATA@gmail.com" });
            _employee.Add(new Employee() { id = 3, name = "NAMANA", age = 22, email = "NAMANA@gmail.com" });
            _employee.Add(new Employee() { id = 4, name = "PRAJWAL", age = 22, email = "PRAJWAL@gmail.com" });

        }

        Employee IEmployeeRepository.GetEmployee(int id) {
            return _employee.FirstOrDefault(e => e.id == id);
        }
    }
}
