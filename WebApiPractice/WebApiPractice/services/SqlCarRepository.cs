using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPractice.model;
using WebApiPractice.repository;

namespace WebApiPractice.services
{
    
        public class SqlCarRepository : ICarRepository
        {

            public readonly CarDbContext context;
            public SqlCarRepository(CarDbContext context) {
                this.context = context;
            }

            public Car Add(Car car) {
                context.Add(car);
                context.SaveChanges();
                return car;
            }

            public Car Delete(int Id) {
                Car car = context.car.Find(Id);
                if (car != null) {
                    context.car.Remove(car);
                    context.SaveChanges();
                }
                return car;
            }

            public IEnumerable<Car> GetAllCar() {
                return context.car;
            }

            public Car GetCar(int Id) {
                return context.car.Find(Id);
            }

            public Car Update(Car CarDbContext) {
                var car = context.car.Attach(CarDbContext);
                //attach method returns the entity entry of employee type. so the ef needs to know that the entry we attached is modified to do that.
                car.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return CarDbContext;

            }
        }
    
}
