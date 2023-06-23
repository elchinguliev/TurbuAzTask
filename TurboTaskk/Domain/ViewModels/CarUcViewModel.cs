using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboTaskk.Commands;
using TurboTaskk.Domain.Views;
using TurboTaskk.Entities;

namespace TurboTaskk.Domain.ViewModels
{
    public class CarUcViewModel:BaseViewModel
    {
        public RelayCommand SelectedCarCommand { get; set; }

        private Car selectedCar;

        public Car SelectedCar
        {
            get { return selectedCar; }
            set { selectedCar = value; OnPropertyChanged(); }
        }


        private string carImagePath;

        public string CarImagePath
        {
            get { return carImagePath; }
            set { carImagePath = value; OnPropertyChanged(); }
        }

        private string carPrice;

        public string CarPrice
        {
            get { return carPrice; }
            set { carPrice = value; OnPropertyChanged(); }
        }

        private string carModelBrandInfo;

        public string CarModelBrandInfo
        {
            get { return carModelBrandInfo; }
            set { carModelBrandInfo = value; OnPropertyChanged(); }
        }

        private string carKmYearInfo;

        public string CarKmYearInfo
        {
            get { return carKmYearInfo; }
            set { carKmYearInfo = value; OnPropertyChanged(); }
        }

        public CarUcViewModel()
        {
            SelectedCarCommand = new RelayCommand((obj) =>
            {
                App.CarWrapPanel.Children.Clear();
                CarInfoUserControl carInfoUC = new CarInfoUserControl();
                CarInfoUcViewModel carInfoUCViewModel = new CarInfoUcViewModel();
                carInfoUCViewModel.CarPrice = $"{SelectedCar.Price} ₼";
                carInfoUCViewModel.CarBrand = SelectedCar.Model.Brand.BrandName;
                carInfoUCViewModel.CarYear = SelectedCar.CreatedYear.Year.ToString();
                carInfoUCViewModel.CarModel = SelectedCar.Model.ModelName;
                carInfoUCViewModel.CarColor = SelectedCar.Color.ColorName;
                carInfoUC.DataContext = carInfoUCViewModel;
                App.CarWrapPanel.Children.Add(carInfoUC);
            });
        }
    }
}
