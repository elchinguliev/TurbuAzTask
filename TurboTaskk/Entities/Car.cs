using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TurboTaskk.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public bool IsNew { get; set; }
        public int BanTypeId { get; set; }
        public float DistanceKM { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedYear { get; set; }
        public string ImagePath { get; set; }
        public int FuelTypeId { get; set; }
        public string Engine { get; set; }


        public virtual CarColor Color { get; set; }
        public virtual CarModel Model { get; set; }
        public virtual CarBanType BanType { get; set; }
        public virtual CarFuelType FuelType { get; set; }
    }
}
