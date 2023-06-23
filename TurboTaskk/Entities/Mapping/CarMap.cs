using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboTaskk.Entities.Mapping
{
    public class CarMap : EntityTypeConfiguration<Car>
    {
        public CarMap()
        {
            this.HasKey(c => c.Id);

            this.Property(c => c.ColorId).HasColumnName("CarColorId");
            this.Property(c => c.ModelId).HasColumnName("CarModelId");
            this.Property(c => c.BanTypeId).HasColumnName("CarBanTypeId");

            this.Property(c => c.DistanceKM)
                .IsRequired();

            this.Property(c => c.Price)
                .IsRequired();

            this.Property(c => c.IsNew)
                .IsRequired();

            this.Property(c => c.Engine)
                .IsRequired();

        }
    }
}
