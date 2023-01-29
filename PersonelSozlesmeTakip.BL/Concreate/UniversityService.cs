using PersonelSozlesmeTakip.BL.Abstract;
using PersonelSozlesmeTakip.DAL.Context;
using PersonelSozlesmeTakip.Entities.Concreate;
using PersonelSozlesmeTakip.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.BL.Concreate
{
    public class UniversityService : IUniversityService
    {
        private readonly IUniversityRepository _repo;
        private readonly PersonelSozlesmeContext context;

        public UniversityService(IUniversityRepository repo, PersonelSozlesmeContext context)
        {
            this._repo = repo;
            this.context = context;
        }
        public void Add(University entiy)
        {
            _repo.Add(entiy);
            context.SaveChanges();
        }

        public void Delete(University entiy)
        {
           _repo.Delete(entiy);
            context.SaveChanges();
        }

        public ICollection<University> GetAll()
        {
            return _repo.GetAll();
        }

        public University GetById(Guid id)
        {
            return _repo.GetById(id);
        }

        public List<University> GetDefault(Expression<Func<University, bool>> predicate)
        {
            return _repo.GetDefault(predicate);
        }

        public void Update(University entity)
        {
            _repo.Update(entity);
        }
    }
}
