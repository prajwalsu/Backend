using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPractice2.model;
using WebApiPractice2.repository;

namespace WebApiPractice2.services
{
    public class SqlKabaddiRepository : IKabaddiRepository
    {
        public readonly KabaddiDbContext context;
        public SqlKabaddiRepository(KabaddiDbContext context) {
            this.context = context;
        }

        public Kabaddi Add(Kabaddi kabaddi) {
            context.Add(kabaddi);
            context.SaveChanges();
            return kabaddi;
        }

        public Kabaddi Delete(int id) {
            Kabaddi kabaddi = context.kabaddi.Find(id);
            if (kabaddi != null) {
                context.kabaddi.Remove(kabaddi);
                context.SaveChanges();
            }
            return kabaddi;
        }

        public IEnumerable<Kabaddi> GetAllKabaddi() {
            return context.kabaddi;
        }

        public Kabaddi GetKabaddi(int id) {
            return context.kabaddi.Find(id);
        }

        public Kabaddi Update(Kabaddi KabaddiDbContext) {
            var kabaddi = context.kabaddi.Attach(KabaddiDbContext);
            //attach method returns the entity entry of employee type. so the ef needs to know that the entry we attached is modified to do that.
            kabaddi.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return KabaddiDbContext;

        }
    }
}
