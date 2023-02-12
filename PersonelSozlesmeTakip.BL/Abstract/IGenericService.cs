using PersonelSozlesmeTakip.Entities.Abstract;
using PersonelSozlesmeTakip.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.BL.Abstract
{
    public interface IGenericService<T> 

    {
        T GetById(Guid id);

        List<T> GetDefault(Expression<Func<T, bool>> predicate);

       ICollection<T> GetAll();
        IQueryable<T> GetAll(params Expression<Func<T, object>>[] include);

        void Add(T entiy);

        void Update(T entity);
        void Delete(T entiy);

    }
}
