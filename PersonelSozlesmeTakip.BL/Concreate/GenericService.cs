using PersonelSozlesmeTakip.BL.Abstract;
using PersonelSozlesmeTakip.DAL.Context;
using PersonelSozlesmeTakip.Entities.Abstract;
using PersonelSozlesmeTakip.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.BL.Concreate
{
    public class GenericService<T> : IGenericService<T> where T : BaseEntity
    {
        private readonly IGenericRepository<T> _repo;
        

        public GenericService(IGenericRepository<T> repo)
        {
            this._repo = repo;
            
        }
        public void Add(T entiy)
        {
            _repo.Add(entiy);
        }

        public void Delete(T entiy)
        {
            _repo.Delete(entiy);
        }

        public ICollection<T> GetAll() => _repo.GetAll();

        public T GetById(Guid id)
        {
            return _repo.GetById(id);
        }

        public List<T> GetDefault(Expression<Func<T, bool>> predicate)
        {
            return _repo.GetDefault(predicate);
        }

        public void Update(T entity)
        {
            _repo.Update(entity);
        }

        
    }
}
