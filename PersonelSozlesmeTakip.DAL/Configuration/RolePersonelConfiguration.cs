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
    public class RolePersonelConfiguration : IEntityTypeConfiguration<RolePersonel>
    {
        public void Configure(EntityTypeBuilder<RolePersonel> builder)
        {
            builder.HasKey(x => new { x.RoleId, x.PersonelId });
            builder.HasOne(x=>x.Role).WithMany(x=>x.Personels).HasForeignKey(x=>x.RoleId);
            builder.HasOne(x=>x.Personel).WithMany(x=>x.Roles).HasForeignKey(x=>x.PersonelId);
        }
    }
}
