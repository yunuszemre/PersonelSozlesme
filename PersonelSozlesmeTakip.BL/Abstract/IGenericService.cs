using PersonelSozlesmeTakip.Entities.Abstract;
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
        Guid GetById(Guid id);

        List<T> GetDefault(Expression<Func<T, bool>> predicate);

       ICollection<T> GetAll();

        void Add(T entiy);

        void Update(T entity);
        void Delete(T entiy);

    }
}
