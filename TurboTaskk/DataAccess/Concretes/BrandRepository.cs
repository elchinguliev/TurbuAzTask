using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboTaskk.DataAccess.Abstractions;
using TurboTaskk.Entities;

namespace TurboTaskk.DataAccess.Concretes
{
    public class BrandRepository : IBrandRepository
    {
        TurboTaskContext turboTaskContext = new TurboTaskContext();

        public void AddData(CarBrand data)
        {
             turboTaskContext.Brands.Add(data);
            turboTaskContext.SaveChanges();
        }

        public void DeleteData(CarBrand data)
        {
            throw new NotImplementedException();
        }

        public ICollection<CarBrand> GetAll()
        {
            return turboTaskContext.Brands.ToList();
        }

        public CarBrand GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(CarBrand data)
        {
            throw new NotImplementedException();
        }
    }
}
