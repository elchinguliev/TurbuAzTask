using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using TurboTaskk.Entities;
using TurboTaskk.Entities.Mapping;

namespace TurboTaskk.DataAccess
{
    public class TurboTaskContext:DbContext
    {
        public TurboTaskContext():base("TurboTaskkDB")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CarBrandMap());
            modelBuilder.Configurations.Add(new CarModelMap());
            modelBuilder.Configurations.Add(new CarBanTypeMao());
            modelBuilder.Configurations.Add(new CarMap());
            modelBuilder.Configurations.Add(new CarColorMap());
            modelBuilder.Configurations.Add(new CarFuelTypeMap());
        }


        public DbSet<CarBrand> Brands { get; set; }
        public DbSet<CarModel> Models { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarColor> Colors { get; set; }
        public DbSet<CarBanType> BodyTypes { get; set; }
        public DbSet<CarFuelType> FuelTypes { get; set; }
    }
}
