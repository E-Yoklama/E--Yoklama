using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace DataAccess.Concrete
{
    public class DersDal : IDersDal
    {
        public List<Ders> GetAll(Expression<Func<Ders, bool>> filter = null)
        {
            using (YoklamaDbContext context = new YoklamaDbContext())
            {
                return filter == null ? context.Set<Ders>().ToList()
                          : context.Set<Ders>().Where(filter).ToList();
            }
        }
    }
}
