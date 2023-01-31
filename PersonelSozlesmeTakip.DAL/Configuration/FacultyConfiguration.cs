using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonelSozlesmeTakip.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.DAL.Configuration
{
    public class FacultyConfiguration : IEntityTypeConfiguration<Faculty>
    {
        public void Configure(EntityTypeBuilder<Faculty> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Adress).HasMaxLength(500).IsRequired(false);

            builder.HasOne(x => x.Campus).WithMany(x1 => x1.Faculties).HasForeignKey(x => x.Id);

            builder.HasOne(x => x.University).WithMany(x1 => x1.Faculties).HasForeignKey(x => x.AdminId);

        }
    }
}
