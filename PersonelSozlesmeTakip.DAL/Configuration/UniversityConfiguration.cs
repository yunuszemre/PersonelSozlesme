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
    public class UniversityConfiguration : IEntityTypeConfiguration<University>
    {
        public void Configure(EntityTypeBuilder<University> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(150).IsRequired(true);
            builder.Property(x => x.City).HasMaxLength(50).IsRequired(true);
            builder.HasOne(x => x.Admin).WithMany(x1 => x1.Universities).HasForeignKey(x => x.Id);
        }
    }
}
