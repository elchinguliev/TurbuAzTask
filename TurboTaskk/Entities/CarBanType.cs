using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboTaskk.Entities
{
    public class CarBanType
    {
        public int Id { get; set; }
        public string BanTypeName { get; set; }
        public virtual ICollection<Car> Cars { get; set; }

        public override string ToString()
        {
            return BanTypeName;
        }
    }
}
