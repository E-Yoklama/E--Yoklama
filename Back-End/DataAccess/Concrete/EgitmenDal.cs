using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace DataAccess.Concrete
{
    public class EgitmenDal : IEgitmenDal
    {
        public List<Egitmen> GetAll(Expression<Func<Egitmen, bool>> filter = null)
        {
            using (YoklamaDbContext context = new YoklamaDbContext())
            {
                return filter == null ? context.Set<Egitmen>().ToList()
                          : context.Set<Egitmen>().Where(filter).ToList();
            }
        }
    }
}
