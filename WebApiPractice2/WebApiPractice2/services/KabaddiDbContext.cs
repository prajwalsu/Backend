using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPractice2.model;

namespace WebApiPractice2.services
{
    public class KabaddiDbContext : DbContext
    {
        public KabaddiDbContext(DbContextOptions<KabaddiDbContext> options) : base(options) {

        }
        //only one type is present in our project as of now
        public DbSet<Kabaddi> kabaddi { get; set; }
    }
}
