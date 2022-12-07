using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPractice.model;

namespace WebApiPractice.repository
{
    public interface ICarRepository
    {
        Car GetCar(int id);
        IEnumerable<Car> GetAllCar();
        Car Add(Car car);
        Car Update(Car car);
        Car Delete(int Id);
    }
}
