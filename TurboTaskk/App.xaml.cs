using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using TurboTaskk.DataAccess.Abstractions;
using TurboTaskk.DataAccess.Concretes;
using TurboTaskk.Entities;
using static System.Net.WebRequestMethods;

namespace TurboTaskk
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static WrapPanel CarWrapPanel { get; set; } = new WrapPanel();
        public static IUnitOfWork DB;
        public App()
        {

            DB = new UnitOfWork();

            if (DB.brandRepository.GetAll().Count == 0)
            {

                DB.brandRepository.AddData(new CarBrand { BrandName = "BMW" });
                DB.brandRepository.AddData(new CarBrand { BrandName = "Mercedes" });
                DB.brandRepository.AddData(new CarBrand { BrandName = "Lexus" });
                DB.brandRepository.AddData(new CarBrand { BrandName = "Toyota" });
                DB.brandRepository.AddData(new CarBrand { BrandName = "Lada" });
                DB.brandRepository.AddData(new CarBrand { BrandName = "Kia" });
            }

            if (DB.modelRepository.GetAll().Count == 0)
            {

                DB.modelRepository.AddData(new CarModel { ModelName = "M5", BrandId = 1 });
                DB.modelRepository.AddData(new CarModel { ModelName = "X6", BrandId = 1 });
                DB.modelRepository.AddData(new CarModel { ModelName = "F30", BrandId = 1 });
                DB.modelRepository.AddData(new CarModel { ModelName = "CLS 350", BrandId = 2 });
                DB.modelRepository.AddData(new CarModel { ModelName = "GLE 450", BrandId = 2 });
                DB.modelRepository.AddData(new CarModel { ModelName = "E 200", BrandId = 2 });
                DB.modelRepository.AddData(new CarModel { ModelName = "LX 570", BrandId = 3 });
                DB.modelRepository.AddData(new CarModel { ModelName = "GX 460", BrandId = 3 });
                DB.modelRepository.AddData(new CarModel { ModelName = "ES 300", BrandId = 3 });
                DB.modelRepository.AddData(new CarModel { ModelName = "Corolla", BrandId = 4 });
                DB.modelRepository.AddData(new CarModel { ModelName = "Camry", BrandId = 4 });
                DB.modelRepository.AddData(new CarModel { ModelName = "Prius", BrandId = 4 });
                DB.modelRepository.AddData(new CarModel { ModelName = "Niva", BrandId = 5 });
                DB.modelRepository.AddData(new CarModel { ModelName = "2107", BrandId = 5 });
                DB.modelRepository.AddData(new CarModel { ModelName = "Priora", BrandId = 5 });
                DB.modelRepository.AddData(new CarModel { ModelName = "Optima", BrandId = 6 });
                DB.modelRepository.AddData(new CarModel { ModelName = "Rio", BrandId = 6 });
            }

            if (DB.bodyTypeRepository.GetAll().Count == 0)
            {

                DB.bodyTypeRepository.AddData(new CarBanType { BanTypeName = "JEEP" });
                DB.bodyTypeRepository.AddData(new CarBanType { BanTypeName = "Sedan" });
                DB.bodyTypeRepository.AddData(new CarBanType { BanTypeName = "Off-Roader" });
            }

            if (DB.colorRepository.GetAll().Count == 0)
            {
                DB.colorRepository.AddData(new CarColor { ColorName = "Black" });
                DB.colorRepository.AddData(new CarColor { ColorName = "White" });
                DB.colorRepository.AddData(new CarColor { ColorName = "Blue" });
                DB.colorRepository.AddData(new CarColor { ColorName = "Red" });
                DB.colorRepository.AddData(new CarColor { ColorName = "Gray" });
                DB.colorRepository.AddData(new CarColor { ColorName = "Brown" });
            }


            if (DB.fuelTypeRepository.GetAll().Count == 0)
            {
                DB.fuelTypeRepository.AddData(new CarFuelType { FuelName = "Diesel" });
                DB.fuelTypeRepository.AddData(new CarFuelType { FuelName = "Benzin" });
                DB.fuelTypeRepository.AddData(new CarFuelType { FuelName = "Hybrid" });
            }

            if (DB.carRepository.GetAll().Count == 0)
            {
                DB.carRepository.AddData(new Car
                {
                    ModelId = 1,
                    BanTypeId = 2,
                    Engine = "2.0T",
                    ImagePath = "https://turbo.azstatic.com/uploads/full/2020%2F05%2F29%2F16%2F06%2F38%2F20bd8838-c3fe-4833-b736-e027fd94c5d6%2F88333_XPWBUO8ALAmRWikWgG9RAA.jpg",
                    ColorId = 1,
                    IsNew = false,
                    DistanceKM = 184000,
                    Price = 38500,
                    CreatedYear = new DateTime(2012, 1, 1),
                    FuelTypeId = 2,
                });

                DB.carRepository.AddData(new Car
                {
                    ModelId = 2,
                    BanTypeId = 3,
                    Engine = "3.0L",
                    ImagePath = "https://turbo.azstatic.com/uploads/full/2022%2F12%2F26%2F17%2F41%2F36%2Fe0a8ab6a-b9da-4202-b674-56d2852cb4a9%2F10938_506hTJFAPNzLvGFPFfB6dw.jpg",
                    ColorId = 5,
                    IsNew = false,
                    DistanceKM = 56000,
                    Price = 98600,
                    CreatedYear = new DateTime(2017, 1, 1),
                    FuelTypeId = 2,
                });


                DB.carRepository.AddData(new Car
                {
                    ModelId = 3,
                    BanTypeId = 2,
                    Engine = "2.0L",
                    ImagePath = "https://turbo.azstatic.com/uploads/full/2023%2F06%2F21%2F17%2F03%2F51%2Ff85ba856-cd46-4a19-bbbd-58223f45f305%2F60356_dHIaOCD6rQHA0sMyghPqzA.jpg",
                    ColorId = 2,
                    IsNew = false,
                    DistanceKM = 120000,
                    Price = 35360,
                    CreatedYear = new DateTime(2015, 1, 1),
                    FuelTypeId = 2,
                });


                DB.carRepository.AddData(new Car
                {
                    ModelId = 4,
                    BanTypeId = 3,
                    Engine = "3.5L",
                    ImagePath = "https://turbo.azstatic.com/uploads/full/2023%2F06%2F15%2F17%2F15%2F54%2F94622d8f-dd09-4f8c-a5de-8a7eac84d68b%2F60373_pmpDjcs15HuBMiaut5vgBA.jpg",
                    ColorId = 2,
                    IsNew = false,
                    DistanceKM = 299000,
                    Price = 23700,
                    CreatedYear = new DateTime(2007, 1, 1),
                    FuelTypeId = 2,
                });

                DB.carRepository.AddData(new Car
                {
                    ModelId = 5,
                    BanTypeId = 1,
                    Engine = "3.0L",
                    ImagePath = "https://turbo.azstatic.com/uploads/full/2023%2F06%2F22%2F11%2F40%2F48%2F126f44af-0347-4de5-83b7-e0af4c71b64d%2F60360_ULH0wSekdtA7aupvus65qQ.jpg",
                    ColorId = 5,
                    IsNew = true,
                    DistanceKM = 0,
                    Price = 200430,
                    CreatedYear = new DateTime(2023, 1, 1),
                    FuelTypeId = 2,
                });

                DB.carRepository.AddData(new Car
                {
                    ModelId = 6,
                    BanTypeId = 3,
                    Engine = "2.0L",
                    ImagePath = "https://turbo.azstatic.com/uploads/full/2023%2F06%2F18%2F15%2F20%2F02%2Fcdf0c6c3-5a7b-4b2d-a6ee-6383714b2684%2F94146_9PUOZG9JZr6FUwt8B0I77A.jpg",
                    ColorId = 1,
                    IsNew = true,
                    DistanceKM = 0,
                    Price = 94690,
                    CreatedYear = new DateTime(2023, 1, 1),
                    FuelTypeId = 2,
                });


                DB.carRepository.AddData(new Car
                {
                    ModelId = 7,
                    BanTypeId = 3,
                    Engine = "5.7L",
                    ImagePath = "https://turbo.azstatic.com/uploads/full/2023%2F02%2F27%2F09%2F44%2F19%2F71ccdec7-6cba-4264-83b7-8678855570b0%2F64488_xeNwV6YRJJZOxmiNMIB2Ww.jpg",
                    ColorId = 1,
                    IsNew = false,
                    DistanceKM = 166469,
                    Price = 93500,
                    CreatedYear = new DateTime(2014, 1, 1),
                    FuelTypeId = 2,
                });

                DB.carRepository.AddData(new Car
                {
                    ModelId = 8,
                    BanTypeId = 3,
                    Engine = "4.6L",
                    ImagePath = "https://turbo.azstatic.com/uploads/full/2023%2F02%2F27%2F09%2F44%2F19%2F71ccdec7-6cba-4264-83b7-8678855570b0%2F64488_xeNwV6YRJJZOxmiNMIB2Ww.jpg",
                    ColorId = 2,
                    IsNew = false,
                    DistanceKM = 148000,
                    Price = 62050,
                    CreatedYear = new DateTime(2012, 1, 1),
                    FuelTypeId = 2,
                });

                DB.carRepository.AddData(new Car
                {
                    ModelId = 9,
                    BanTypeId = 2,
                    Engine = "4.6L",
                    ImagePath = "https://turbo.azstatic.com/uploads/full/2022%2F12%2F23%2F14%2F03%2F52%2F9cef35af-0523-4935-b417-c8fa305ec8dc%2F29322_r8ol5Jr8x2gILn5VepUuBg.jpg",
                    ColorId = 2,
                    IsNew = true,
                    DistanceKM = 0,
                    Price = 116450,
                    CreatedYear = new DateTime(2022, 1, 1),
                    FuelTypeId = 2,
                });

                DB.carRepository.AddData(new Car
                {
                    ModelId = 10,
                    BanTypeId = 2,
                    Engine = "1.8L",
                    ImagePath = "https://turbo.azstatic.com/uploads/full/2023%2F06%2F14%2F17%2F53%2F19%2F51469aa6-ae5f-45da-ae2f-03ebcad31179%2F98857_4aH-eaMY3O5uP_6pYBsPZw.jpg",
                    ColorId = 3,
                    IsNew = true,
                    DistanceKM = 0,
                    Price = 43010,
                    CreatedYear = new DateTime(2022, 1, 1),
                    FuelTypeId = 2,
                });

                DB.carRepository.AddData(new Car
                {
                    ModelId = 11,
                    BanTypeId = 2,
                    Engine = "2.5L",
                    ImagePath = "https://turbo.azstatic.com/uploads/full/2023%2F06%2F13%2F00%2F42%2F59%2Feeb1406d-2bd3-481a-82e1-b985c86bc775%2F15074_ojGKVHmGBPoe6EcnDCfBag.jpg",
                    ColorId = 1,
                    IsNew = true,
                    DistanceKM = 0,
                    Price = 79118,
                    CreatedYear = new DateTime(2023, 1, 1),
                    FuelTypeId = 3,
                });

                DB.carRepository.AddData(new Car
                {
                    ModelId = 12,
                    BanTypeId = 2,
                    Engine = "1.5L",
                    ImagePath = "https://turbo.azstatic.com/uploads/full/2023%2F06%2F10%2F18%2F47%2F59%2Fb272e40a-95a3-4641-968e-e85a8c76771d%2F79828_hc2GtHlRF5-VzSwEwnanYg.jpg",
                    ColorId = 4,
                    IsNew = false,
                    DistanceKM = 187000,
                    Price = 15000,
                    CreatedYear = new DateTime(2008, 1, 1),
                    FuelTypeId = 3,
                });

                DB.carRepository.AddData(new Car
                {
                    ModelId = 13,
                    BanTypeId = 3,
                    Engine = "1.7L",
                    ImagePath = "https://turbo.azstatic.com/uploads/full/2023%2F05%2F11%2F11%2F19%2F12%2F8f888978-16c0-4b86-9930-e245a6b8f567%2F36578_mR6DbZ9JCQMMg3Gffy0PFA.jpg",
                    ColorId = 6,
                    IsNew = true,
                    DistanceKM =1000 ,
                    Price = 22300,
                    CreatedYear = new DateTime(2022, 1, 1),
                    FuelTypeId = 2,
                });

                DB.carRepository.AddData(new Car
                {
                    ModelId = 14,
                    BanTypeId = 3,
                    Engine = "1.6L",
                    ImagePath = "https://turbo.azstatic.com/uploads/full/2023%2F05%2F30%2F02%2F24%2F52%2F6c1c6f61-171d-4f02-97aa-95d22e081eae%2F14298_KtpAX3EljkqgyqaCOrgG5g.jpg",
                    IsNew = false,
                    DistanceKM =58000,
                    Price = 20800,
                    CreatedYear = new DateTime(2018, 1, 1),
                    FuelTypeId = 2,
                });

                DB.carRepository.AddData(new Car
                {
                    ModelId = 15,
                    BanTypeId = 3,
                    Engine = "2.4L",
                    ImagePath = "https://turbo.azstatic.com/uploads/full/2023%2F03%2F10%2F14%2F53%2F19%2Fa869f179-d630-47c6-8b71-820e03821c27%2F67582_I5wPqUpIXncoWdFLbKVoFg.jpg",
                    DistanceKM =43000,
                    Price = 36900,
                    CreatedYear = new DateTime(2019, 1, 1),
                    FuelTypeId = 2,
                });

                DB.carRepository.AddData(new Car
                {
                    ModelId = 16,
                    BanTypeId = 3,
                    Engine = "1.4L",
                    ImagePath =" https://turbo.azstatic.com/uploads/full/2023%2F06%2F21%2F11%2F54%2F31%2F30bef7d8-b00b-455e-aa4b-6252b316ac6f%2F98748_KG-eOWP20WEeSc1CHyZbzg.jpg",
                    IsNew = false,
                    DistanceKM =188400,
                    Price = 17200,
                    CreatedYear = new DateTime(2012, 1, 1),
                    FuelTypeId = 1,
                });









            }
        }
    }
}
