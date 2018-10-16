using System;
using System.Linq;
using System.Linq.Expressions;

namespace SimpleWebApiNetCore.Interface
{
    public interface IRepository<T, K> where T: class 
    {
        IQueryable<T> FindAll(params Expression<Func<T, object>>[] includeProperties);
        T FindById(K id, params Expression<Func<T, object>>[] includeProperties);
        void Remove(K id);
    }
}
