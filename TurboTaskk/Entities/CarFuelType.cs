using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboTaskk.Entities
{
    public class CarFuelType
    {
        public int FuelTypeId { get; set; }
        public string FuelName { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

        public override string ToString()
        {
            return FuelName;
        }
    }
}
