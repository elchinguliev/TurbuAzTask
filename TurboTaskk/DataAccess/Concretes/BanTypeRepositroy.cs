using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboTaskk.DataAccess.Abstractions;
using TurboTaskk.Entities;

namespace TurboTaskk.DataAccess.Concretes
{
    public class BanTypeRepositroy:IBanTypeRepository
    {
        TurboTaskContext turboTaskContext = new TurboTaskContext();
        public void AddData(CarBanType data)
        {
            turboTaskContext.BodyTypes.Add(data);
            turboTaskContext.SaveChanges();
        }

        public void DeleteData(CarBanType data)
        {
            throw new NotImplementedException();
        }

        public ICollection<CarBanType> GetAll()
        {
            return turboTaskContext.BodyTypes.ToList();
        }

        public CarBanType GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(CarBanType data)
        {
            throw new NotImplementedException();
        }
    }
}
