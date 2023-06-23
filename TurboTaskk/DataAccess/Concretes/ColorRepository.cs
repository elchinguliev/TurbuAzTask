using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboTaskk.DataAccess.Abstractions;
using TurboTaskk.Entities;

namespace TurboTaskk.DataAccess.Concretes
{
    public class ColorRepository : IColorRepository
    {
        TurboTaskContext turboTaskContext = new TurboTaskContext();

        public void AddData(CarColor data)
        {
            turboTaskContext.Colors.Add(data);
            turboTaskContext.SaveChanges();
         }

        public void DeleteData(CarColor data)
        {
            throw new NotImplementedException();
        }

        public ICollection<CarColor> GetAll()
        {
            return turboTaskContext.Colors.ToList();

        }

        public CarColor GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(CarColor data)
        {
            throw new NotImplementedException();
        }
    }
}
