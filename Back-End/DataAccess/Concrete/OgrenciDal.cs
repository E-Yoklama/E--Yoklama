using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete
{
    public class OgrenciDal : IOgrenciDal
    {
        public List<Ogrenci> GetAll(Expression<Func<Ogrenci, bool>> filter = null)
        {
            using (YoklamaDbContext context = new YoklamaDbContext())
            {
                return filter == null ? context.Set<Ogrenci>().ToList()
                          : context.Set<Ogrenci>().Where(filter).ToList();
            }
        }
    }
}

