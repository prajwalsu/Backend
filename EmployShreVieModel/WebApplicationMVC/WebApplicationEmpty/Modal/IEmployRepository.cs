using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEmpty.Modal
{
    public interface IEmployRepository //used for dependency injection
    {
        Employee GetEmployee(int id);//method
    }
}
