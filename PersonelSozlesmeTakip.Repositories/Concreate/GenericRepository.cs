using Microsoft.EntityFrameworkCore;
using PersonelSozlesmeTakip.DAL.Context;
using PersonelSozlesmeTakip.Entities.Abstract;
using PersonelSozlesmeTakip.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Repositories.Concreate
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly PersonelSozlesmeContext _context;
        private DbSet<T> _dbSet;
        public GenericRepository(PersonelSozlesmeContext context)
        {
            this._context = context;
            _dbSet = _context.Set<T>();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public ICollection<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(Guid Id)
        {
            return _dbSet.Find(Id);
        }

        public List<T> GetDefault(Expression<Func<T, bool>> predicate)
        {
            if (predicate !=null)
            {
                return _dbSet.Where(predicate).ToList();
            }
            else
            {
                return _dbSet.ToList();
            }
        }

        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            var query = _context.Set<T>().AsQueryable();
            if (includes != null)
            {
                query = includes.Aggregate(query, (current, include) => current.Include(include));
            }
            return query;
        }

        

        
        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }
    }
}
