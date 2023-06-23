using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboTaskk.Entities
{
    public class CarModel
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public int BrandId { get; set; }

        public virtual CarBrand Brand { get; set; }
        public virtual ICollection<Car> Cars { get; set; }

        public override string ToString()
        {
            return ModelName;
        }
    }
}
