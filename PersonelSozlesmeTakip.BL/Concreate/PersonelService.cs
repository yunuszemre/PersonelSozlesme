using PersonelSozlesmeTakip.BL.Abstract;
using PersonelSozlesmeTakip.DAL.Context;
using PersonelSozlesmeTakip.Entities.Concreate;
using PersonelSozlesmeTakip.Repositories.Abstract;
using PersonelSozlesmeTakip.Repositories.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.BL.Concreate
{
    public class PersonelService : IPersonelService
    {
        private readonly PersonelSozlesmeContext _context;
        private readonly IPersonelRepository _repo;

        public PersonelService(PersonelSozlesmeContext context, IPersonelRepository repo)
        {
            this._context = context;
            this._repo = repo;
        }
        public void Add(Personel entiy)
        {
           _repo.Add(entiy);
            _context.SaveChanges();
        }

        public void Delete(Personel entiy)
        {
            _repo.Delete(entiy);
            _context.SaveChanges();
        }

        public ICollection<Personel> GetAll()
        {
            return _repo.GetAll();

        }

        public IQueryable<Personel> GetAll(params Expression<Func<Personel, object>>[] include)
        {
            return _repo.GetAll(include);

        }

        public Personel GetById(Guid id)
        {
            return _repo.GetById(id);
        }

        public List<Personel> GetDefault(Expression<Func<Personel, bool>> predicate)
        {
            return _repo.GetDefault(predicate);
        }

        public void Update(Personel entity)
        {
            _repo.Update(entity);
            _context.SaveChanges();
        }
    }
}
