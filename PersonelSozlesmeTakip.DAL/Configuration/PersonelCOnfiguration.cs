using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonelSozlesmeTakip.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSozlesmeTakip.DAL.Configuration
{
    public class PersonelCOnfiguration : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Email).HasMaxLength(100).IsRequired(false);
            builder.Property(x=>x.Phone).HasMaxLength(20).IsRequired(false);
            builder.Property(x=>x.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(x=>x.LastName).HasMaxLength(50).IsRequired(true);
            builder.HasOne(x=>x.Faculty).WithMany(x1=>x1.Personels).HasForeignKey(x => x.Id);
            

        }
    }
}
