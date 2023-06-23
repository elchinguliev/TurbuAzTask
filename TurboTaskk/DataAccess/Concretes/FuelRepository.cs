using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboTaskk.DataAccess.Abstractions;
using TurboTaskk.Entities;

namespace TurboTaskk.DataAccess.Concretes
{
    public class FuelRepository : IFuelTypeRepository
    {
        TurboTaskContext turboTaskContext = new TurboTaskContext();

        public void AddData(CarFuelType data)
        {
            turboTaskContext.FuelTypes.Add(data);
            turboTaskContext.SaveChanges();

        }

        public void DeleteData(CarFuelType data)
        {
            throw new NotImplementedException();
        }

        public ICollection<CarFuelType> GetAll()
        {
            return turboTaskContext.FuelTypes.ToList();
        }

        public CarFuelType GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(CarFuelType data)
        {
            throw new NotImplementedException();
        }
    }
}
