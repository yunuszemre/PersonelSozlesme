using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using PersonelSozlesmeTakip.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.DAL
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PersonelSozlesmeContext>
    {
        public PersonelSozlesmeContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PersonelSozlesmeContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-VA3Q2CE\\YUNUS; Database=UniDb; uid = sa; pwd=1234;");

            return new PersonelSozlesmeContext(optionsBuilder.Options);
        }
    }
}
