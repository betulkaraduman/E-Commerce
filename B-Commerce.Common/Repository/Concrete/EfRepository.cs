using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using B_Commerce.Common.DomainClass;
using B_Commerce.Common.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace B_Commerce.Common.Repository.Concrete
{
  public  class EfRepository<T> : IRepository<T> where T : BaseEntity, new()
  {
      
      private DbContext _dbContext;
      private DbSet<T> _dbset;
        public EfRepository(DbContext dbcontext)
        {
            _dbContext = dbcontext;
            _dbset = _dbContext.Set<T>();
        }
        public void Add(T Tentity)
        {
           _dbset.Add(Tentity);
        }

        public void Update(T Tentity)
        {
            _dbset.Update(Tentity);
        }

        public void Delete(T Tentity)
        {
            _dbset.Remove(Tentity);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? _dbset.AsQueryable() : _dbset.Where(filter).AsQueryable();
        }
    }
}
