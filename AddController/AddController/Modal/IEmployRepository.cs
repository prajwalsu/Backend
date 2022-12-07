using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddController.Modal
{
    public interface IEmployRepository
    {
        Employee GetEmployee(int id);
    }
}
