using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPractice.model;

namespace WebApiPractice.services
{
    public class CarDbContext: DbContext
    {
        public CarDbContext(DbContextOptions<CarDbContext> options) : base(options) {

        }
        //only one type is present in our project as of now
        public DbSet<Car> car { get; set; }

    }
}
