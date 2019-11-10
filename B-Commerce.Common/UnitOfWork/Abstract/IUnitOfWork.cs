using System;
using System.Collections.Generic;
using System.Text;

namespace B_Commerce.Common.UnitOfWork.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        int Save();
       
    }
}
