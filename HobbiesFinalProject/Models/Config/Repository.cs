using HobbiesFinalProject.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HobbiesFinalProject.Models.Config
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected HobbiesContext context { get; set; }
        private DbSet<T> dbset { get; set; }

        public Repository(HobbiesContext ctx)
        {
            context = ctx;
            dbset = context.Set<T>();
        }
        public virtual IEnumerable<T> List()
        {
            IQueryable<T> query = dbset;
            return query.ToList();
        }

        public virtual T Get(int id) => dbset.Find(id);
    }
}
