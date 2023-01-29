using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonelSozlesmeTakip.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.DAL.Configuration
{
    public class DepartmenPersonConfiguration : IEntityTypeConfiguration<DepartmentPerson>
    {
        public void Configure(EntityTypeBuilder<DepartmentPerson> builder)
        {
            builder.HasKey(x => new { x.PersonelId, x.DepartmentId });
            builder.HasOne(x=>x.Personel).WithMany(x=>x.Departments).HasForeignKey(x=>x.PersonelId);
            builder.HasOne(x=>x.Department).WithMany(x=>x.Personels).HasForeignKey(x=>x.DepartmentId);
        }
    }
}
