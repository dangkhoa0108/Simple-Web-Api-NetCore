using System;
using System.Linq;
using System.Linq.Expressions;
using SimpleWebApiNetCore.Interface;
using Microsoft.EntityFrameworkCore;
using SimpleWebApiNetCore.Entity;

namespace SimpleWebApiNetCore.Implementation
{
    public class EFRepository <T, K> :IRepository<T, K> where T:KeyEntity<K>
    {
        private readonly AppDbContext _context;
        public EFRepository(AppDbContext context)
        {
            _context = context;
        }
        public IQueryable<T> FindAll(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> items = _context.Set<T>();
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    items = items.Include(includeProperty);
                }
            }
            return items;
        }

        public T FindById(K id, params Expression<Func<T, object>>[] includeProperties)
        {
            return FindAll(includeProperties).SingleOrDefault(x=>x.Id.Equals(id));
        }

        public void Remove(K id)
        {
            var item = FindById(id);
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
        }

        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
