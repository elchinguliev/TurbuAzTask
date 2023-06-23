using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using TurboTaskk.Commands;
using TurboTaskk.Domain.Views;
using TurboTaskk.Entities;

namespace TurboTaskk.Domain.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        public RelayCommand ShowCommand { get; set; }
        public RelayCommand AllCarsCommand { get; set; }
        public RelayCommand NewCommand { get; set; }
        public RelayCommand DrivenCommand { get; set; }
       public RelayCommand BrandSelectionChangedCommand { get; set; }
       public RelayCommand ModelSelectionChangedCommand { get; set; }
       public RelayCommand BanTypeSelectionChangedCommand { get; set; }
        public RelayCommand ColorTypeSelectionChanged { get; set; }

        private CarBrand selectedBrand;

        public CarBrand SelectedBrand
        {
            get { return selectedBrand; }
            set { selectedBrand = value; }
        }
        private CarColor selectedColor;

        public CarColor SelectedColor
        {
            get { return selectedColor; }
            set { selectedColor = value; }
        }


        private CarModel selectedModel;

        public CarModel SelectedModel
        {
            get { return selectedModel; }
            set { selectedModel = value; }
        }

        private CarBanType selectedBanType;

        public CarBanType SelectedBanType
        {
            get { return selectedBanType; }
            set { selectedBanType = value; OnPropertyChanged(); }
        }

        private ObservableCollection<CarBrand> brands;

        public ObservableCollection<CarBrand> Brands
        {
            get { return brands; }
            set { brands = value; OnPropertyChanged(); }
        }

        private ObservableCollection<CarModel> models;

        public ObservableCollection<CarModel> Models
        {
            get { return models; }
            set { models = value; }
        }






        private ObservableCollection<CarBanType> banTypes;

        public ObservableCollection<CarBanType> BanTypes
        {
            get { return banTypes; }
            set { banTypes = value; OnPropertyChanged(); }
        }
        private ObservableCollection<CarColor> colors;

        public ObservableCollection<CarColor> Colors
        {
            get { return colors; }
            set { colors = value; OnPropertyChanged(); }
        }
        private ObservableCollection<CarFuelType> fuelTypes;

        public ObservableCollection<CarFuelType> FuelTypes
        {
            get { return fuelTypes; }
            set { fuelTypes = value; OnPropertyChanged(); }
        }
        public bool isAll { get; set; } = true;
        public bool isNew { get; set; } = false;
        public bool IsModelSelected { get; set; } = false;

        private bool isBrandSelected = false;

        public bool IsBrandSelected
        {
            get { return isBrandSelected; }
            set { isBrandSelected = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Car> cars;

        public ObservableCollection<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }

        public void CallCarUc(List<Car> cars)
        {
            App.CarWrapPanel.Children.Clear();
            CarUserControl carUC;
            CarUcViewModel carUCViewModel;
            for (int i = 0; i < cars.Count(); i++)
            {
                carUC = new CarUserControl();
                carUCViewModel = new CarUcViewModel();
                carUCViewModel.SelectedCar = cars[i];
                carUCViewModel.CarImagePath = cars[i].ImagePath;
                carUCViewModel.CarPrice = $"{cars[i].Price} ₼";
                carUCViewModel.CarModelBrandInfo = $"{cars[i].Model.Brand.BrandName} {cars[i].Model.ModelName}";
                carUCViewModel.CarKmYearInfo = $"{cars[i].CreatedYear.Year}, {cars[i].Engine}, {cars[i].DistanceKM} km";
                carUC.DataContext = carUCViewModel;
                App.CarWrapPanel.Children.Add(carUC);
            }
        }
        public MainViewModel()
        {
            Brands = new ObservableCollection<CarBrand>(App.DB.brandRepository.GetAll());
            Models=new ObservableCollection<CarModel>(App.DB.modelRepository.GetAll());
            BanTypes = new ObservableCollection<CarBanType>(App.DB.bodyTypeRepository.GetAll());
            Colors = new ObservableCollection<CarColor>(App.DB.colorRepository.GetAll());
            FuelTypes = new ObservableCollection<CarFuelType>(App.DB.fuelTypeRepository.GetAll());
            Cars = new ObservableCollection<Car>(App.DB.carRepository.GetAll());
            CallCarUc(cars.ToList());


            BrandSelectionChangedCommand = new RelayCommand((obj) =>
            {
                var id = SelectedBrand.Id;
                Models = new ObservableCollection<CarModel>(App.DB.modelRepository.GetAllId(id));
                IsBrandSelected = true;
                IsModelSelected = false;
            });


            ModelSelectionChangedCommand = new RelayCommand((obj) =>
            {
                IsModelSelected = true;
            });

            ShowCommand = new RelayCommand((obj) =>
            {
                
                if (!IsBrandSelected && isNew)
                {
                    var allCars = Cars.Where(c => c.IsNew).ToList();
                    CallCarUc(allCars);
                };
                if (!IsBrandSelected && !isNew)
                {
                    var allCars = Cars.Where(c => c.IsNew == false).ToList();
                    CallCarUc(allCars);
                }
                if (!IsModelSelected && IsBrandSelected || isAll)
                {

                    var allCars = Cars.Where(c => c.Model.BrandId == SelectedBrand.Id).ToList();
                    CallCarUc(allCars);
                }
                if (isNew && IsBrandSelected)
                {
                    var allCars = Cars.Where(c => c.Model.BrandId == SelectedBrand.Id && c.IsNew == true).ToList();
                    CallCarUc(allCars);
                }
                else if (!isNew && !isAll && IsBrandSelected)
                {
                    var allCars = Cars.Where(c => c.Model.BrandId == SelectedBrand.Id && c.IsNew == false).ToList();
                    CallCarUc(allCars);
                }
                if (IsModelSelected)
                {
                    var allCars = Cars.Where(c => c.ModelId == SelectedModel.Id).ToList();
                    CallCarUc(allCars);

                }
            });
            AllCarsCommand = new RelayCommand((obj) =>
            {
                var cars = Cars.ToList();
            });

            NewCommand = new RelayCommand((obj) =>
            {
              var cars=Cars.Where(c=>c.IsNew==true).ToList();
            });

            DrivenCommand = new RelayCommand((obj) =>
            {
                var cars = Cars.Where(c => c.IsNew==true).ToList();
            });

        }

    }
}
