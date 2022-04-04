using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ZC7ADM_HFT_2021221.Models;

namespace ZC7ADM_HFT_2021221.WPFClient
{
    public class GuestViewModel : ObservableRecipient
    {
        public RestCollection<Restaurant> Restaurants { get; set; }

        private Restaurant selectedGuest;

        public Restaurant SelectedRestaurant
        {
            get { return selectedGuest; }
            set
            {
                if (value != null)
                {
                    selectedGuest = new Restaurant()
                    {
                         RestaurantName=value.RestaurantName,
                         Restaurant_id=value.Restaurant_id,
                         Foodlist=value.Foodlist,
                         Employees=value.Employees,
                         Rating=value.Rating
                    };
                    OnPropertyChanged();
                    (DeleteRestaurant as RelayCommand).NotifyCanExecuteChanged();
                    //(UpdateEmployee as RelayCommand).NotifyCanExecuteChanged();
                }
            }
        }

        public ICommand CreateRestaurant { get; set; }
        public ICommand DeleteRestaurant { get; set; }
        public ICommand Updaterestaurant { get; set; }


        public GuestViewModel()
        {

            Restaurants = new RestCollection<Restaurant>("http://localhost:31877/", "employee");
            CreateRestaurant = new RelayCommand(() =>
            {
                Restaurants.Add(new Restaurant()
                {
                    RestaurantName = "Enter new Employee's Name here!",
                });
            });

            DeleteRestaurant = new RelayCommand(() =>
            Restaurants.Delete(SelectedRestaurant.Restaurant_id),
            () => { return SelectedRestaurant != null; }
            );
            Updaterestaurant = new RelayCommand(() => Restaurants.Update(SelectedRestaurant));

        }
    }
}

