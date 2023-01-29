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
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity<T>
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

        public Guid GetById(Guid Id)
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

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }
    }
}
