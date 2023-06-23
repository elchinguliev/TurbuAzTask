using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboTaskk.Entities.Mapping
{
    public class CarBanTypeMao : EntityTypeConfiguration<CarBanType>
    {
        public CarBanTypeMao()
        {
            this.HasKey(x => x.Id);

            this.Property(b => b.BanTypeName)
               .IsRequired()
               .HasMaxLength(30)
               .IsUnicode(true);

            this.HasMany(b => b.Cars)
             .WithOptional()
             .HasForeignKey(c => c.BanTypeId)
             .WillCascadeOnDelete(true);
        }
    }
}
