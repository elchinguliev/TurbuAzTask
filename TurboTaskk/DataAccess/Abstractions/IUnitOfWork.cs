using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboTaskk.DataAccess.Abstractions
{
    public interface IUnitOfWork
    {
        IBanTypeRepository bodyTypeRepository { get; }
        IBrandRepository brandRepository { get; }
        ICarRepository carRepository { get; }
        IColorRepository colorRepository { get; }
        IModelRepository modelRepository { get; }
        IFuelTypeRepository fuelTypeRepository { get; }
    }
}
