using Microsoft.EntityFrameworkCore;
using PersonelSozlesmeTakip.DAL.Configuration;
using PersonelSozlesmeTakip.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.DAL.Context
{
    public class PersonelSozlesmeContext : DbContext
    {
        

        public DbSet<Personel> Personels { get; set; }
        public DbSet<Faculty> Faculties { get; set; }

        public DbSet<Campus> Campuses { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<University> Universities { get; set; }

        public PersonelSozlesmeContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-VA3Q2CE\\YUNUS; Database=UniDb; uid = sa; pwd = 1234;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            

            modelBuilder.ApplyConfiguration(new PersonelCOnfiguration());
            modelBuilder.ApplyConfiguration(new UniversityConfiguration());
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new FacultyConfiguration());
            modelBuilder.ApplyConfiguration(new CampusConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmenPersonConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
