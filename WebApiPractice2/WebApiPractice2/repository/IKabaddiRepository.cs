using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPractice2.model;

namespace WebApiPractice2.repository
{
    public interface IKabaddiRepository
    {
        Kabaddi GetKabaddi(int id);
        IEnumerable<Kabaddi> GetAllKabaddi();
        Kabaddi Add(Kabaddi kabaddi);
        Kabaddi Update(Kabaddi kabaddi);
        Kabaddi Delete(int id);
    }
}
