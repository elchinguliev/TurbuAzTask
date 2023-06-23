using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboTaskk.Entities;

namespace TurboTaskk.DataAccess.Abstractions
{
    public interface IModelRepository : IRepository<CarModel>
    {
        ICollection<CarModel> GetAllId(int id);
    }
}
