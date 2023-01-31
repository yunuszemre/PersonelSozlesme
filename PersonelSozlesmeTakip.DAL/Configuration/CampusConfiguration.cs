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
    public class CampusConfiguration : IEntityTypeConfiguration<Campus>
    {
        public void Configure(EntityTypeBuilder<Campus> builder)
        {
            builder.HasKey(x => x.Id);  

            builder.Property(x => x.Name).HasMaxLength(128).IsRequired();

            builder.HasOne(x=>x.University).WithMany(x1=>x1.Campuses).HasForeignKey(x => x.UniversityId);

        }
    }
}
