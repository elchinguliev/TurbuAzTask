using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboTaskk.DataAccess.Abstractions;
using TurboTaskk.Entities;

namespace TurboTaskk.DataAccess.Concretes
{
    public class ModelRepository : IModelRepository
    {
        TurboTaskContext turboTaskContext = new TurboTaskContext();

        public void AddData(CarModel data)
        {
            turboTaskContext.Models.Add(data);
            turboTaskContext.SaveChanges();
        }

        public void DeleteData(CarModel data)
        {
            throw new NotImplementedException();
        }

        public ICollection<CarModel> GetAll()
        {
            return turboTaskContext.Models.ToList();
        }

        public ICollection<CarModel> GetAllId(int id)
        {
            return turboTaskContext.Models.Where(m => m.BrandId == id).ToList();
        }

        public CarModel GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(CarModel data)
        {
            throw new NotImplementedException();
        }
    }
}
