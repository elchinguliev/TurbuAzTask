using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboTaskk.DataAccess.Abstractions;
using TurboTaskk.Entities;

namespace TurboTaskk.DataAccess.Concretes
{
    public class CarRepository : ICarRepository
    {
        TurboTaskContext turboTaskContext = new TurboTaskContext();

        public void AddData(Car data)
        {
            turboTaskContext.Cars.Add(data);
            turboTaskContext.SaveChanges();
        }

        public void DeleteData(Car data)
        {
            throw new NotImplementedException();
        }

        public ICollection<Car> GetAll()
        {
            return turboTaskContext.Cars.ToList();
        }

        public Car GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Car data)
        {
            throw new NotImplementedException();
        }
    }
}
