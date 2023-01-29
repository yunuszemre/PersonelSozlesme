using Microsoft.EntityFrameworkCore;
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
    public class UniversityRepository : GenericRepository<University>,IUniversityRepository
    {
        private readonly PersonelSozlesmeContext context;

        public UniversityRepository(PersonelSozlesmeContext context) : base(context)
        {

            this.context = context;
        }
    }
}
