using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TurboTaskk.Entities.Mapping
{
    public class CarColorMap : EntityTypeConfiguration<CarColor>
    {
        public CarColorMap()
        {
            this.HasKey(x => x.Id);

            this.Property(c => c.ColorName)
              .IsRequired()
              .HasMaxLength(30)
              .IsUnicode(true);

            this.HasMany(c => c.Cars)
            .WithOptional()
            .HasForeignKey(c => c.ColorId)
            .WillCascadeOnDelete(true);
        }
    }
}
