using PersonelSozlesmeTakip.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Repositories.Abstract
{
    public interface IGenericRepository<T> where T : BaseEntity<T>
    {
        List<T> GetDefault(Expression<Func<T, bool>> predicate);

        ICollection<T> GetAll();
        Guid GetById(Guid Id);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
