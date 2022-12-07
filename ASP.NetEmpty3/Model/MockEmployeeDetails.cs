﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetEmpty3.Model
{
    public class MockEmployeeDetails:IEmployeeRepository
    {
        private List<Employee> _employees=new List<Employee>();

        public MockEmployeeDetails() {
            _employees.Add(new Employee() { id = 1, name = "Shreyas", age = 22, email = "shreyas@gmail.com" });
            _employees.Add(new Employee() { id = 2, name = "Akshata", age = 22, email = "akshatanaik@gmail.com" });
            _employees.Add(new Employee() { id = 3, name = "namana", age = 22, email = "namanajain@gmail.com" });
            _employees.Add(new Employee() { id = 4, name = "nayana", age = 22, email = "nayanasr@gmail.com" });

        }

        Employee IEmployeeRepository.GetEmployee(int id) {
            return _employees.FirstOrDefault(e => e.id == id);

        }

        public IEnumerable<Employee> GetEmployeeDetails() {
            return _employees;
        }
    }
}
