using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using B_Commerce.Common.DomainClass;

namespace B_Commerce.Common.Repository.Abstract
{
    public interface IRepository<T> where T: BaseEntity,new()
    {
        void Add(T Tentity);
        void Update(T Tentity);
        void Delete(T Tentity);
        /// <summary>
        /// Filter Null verilirse Bütün table i getirir .
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        IQueryable<T> Get(Expression<Func<T, bool>> filter = null);
    }
}
