using PersonelSozlesmeTakip.DAL.Context;
using PersonelSozlesmeTakip.Entities.Concreate;
using PersonelSozlesmeTakip.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.Repositories.Concreate
{
    public class PersonelRepository : GenericRepository<Personel>,IPersonelRepository
    {
        private readonly PersonelSozlesmeContext context;

        public PersonelRepository(PersonelSozlesmeContext context) : base(context)
        {
            
this.context = context;
        }
    }
}
