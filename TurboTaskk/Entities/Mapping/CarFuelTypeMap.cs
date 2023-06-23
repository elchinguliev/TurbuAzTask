using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboTaskk.Entities.Mapping
{
    public class CarFuelTypeMap : EntityTypeConfiguration<CarFuelType>
    {
        public CarFuelTypeMap()
        {
            this.HasKey(x => x.FuelTypeId);

            this.Property(f => f.FuelName)
               .IsRequired()
               .HasMaxLength(30)
               .IsUnicode(true);

            this.HasMany(f => f.Cars)
              .WithOptional()
              .HasForeignKey(c => c.FuelTypeId)
              .WillCascadeOnDelete(true);
        }
    }
}
