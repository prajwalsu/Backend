using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePractice.Modal
{
    public class MockEmployeRepository : IEmployeRepository
    {
        private List<Employe> _employe = new List<Employe>();

        public MockEmployeRepository() {

            _employe.Add(new Employe() { id = 1, name = "praj", age = 22 });
        }

        Employe IEmployeRepository.GetEmploye(int id) {
            return _employe.FirstOrDefault(e => e.id == id);



        }

    }

}
