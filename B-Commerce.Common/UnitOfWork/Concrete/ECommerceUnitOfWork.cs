using System;
using System.Collections.Generic;
using System.Text;
using B_Commerce.Common.UnitOfWork.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace B_Commerce.Common.UnitOfWork.Concrete
{
    public class ECommerceUnitOfWork : IUnitOfWork
    {
        private DbContext _dbContext;
        private IDbContextTransaction _transaction;
        public ECommerceUnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
            _transaction = _dbContext.Database.BeginTransaction();
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }

        /// <summary>
        /// 1 Dönerse işlem hatasız gerçekleşmiştir. 0 Dönerse Hata oluşmuştur
        /// </summary>
        /// <returns></returns>
        public int Save()
        {
            try
            {
                _dbContext.SaveChanges();
                _transaction.Commit();
                return 1;
            }
            catch (Exception)
            {
                _transaction.Rollback();
                return 0;
            }
            finally
            {
                _transaction.Dispose();
            }
                
        }
    }
}
