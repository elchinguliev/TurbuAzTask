using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboTaskk.Entities
{
    public class CarBrand
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public virtual ICollection<CarModel> Models { get; set; }

        public override string ToString()
        {
            return BrandName;
        }
    }
}
