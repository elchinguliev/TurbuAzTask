using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboTaskk.DataAccess.Abstractions;
using TurboTaskk.Entities;

namespace TurboTaskk.DataAccess.Concretes
{
    public class UnitOfWork : IUnitOfWork
    {
        public IBanTypeRepository bodyTypeRepository =>  new BanTypeRepositroy();

        public IBrandRepository brandRepository =>  new BrandRepository();

        public ICarRepository carRepository =>  new CarRepository();

        public IColorRepository colorRepository =>  new ColorRepository();

        public IModelRepository modelRepository =>  new ModelRepository();

        public IFuelTypeRepository fuelTypeRepository =>  new FuelRepository();
    }
}
