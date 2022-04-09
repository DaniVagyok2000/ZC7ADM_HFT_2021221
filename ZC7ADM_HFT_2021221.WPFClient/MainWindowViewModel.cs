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
    public class MainWindowViewModel : ObservableRecipient
    {
        #region Employees
        public RestCollection<Employee> Employees { get; set; }

        private Employee selectedEmployee;

        public Employee SelectedEmployee
        {
            get { return selectedEmployee; }
            set
            {
                if (value != null)
                {
                    selectedEmployee = new Employee()
                    {
                        Name = value.Name,
                        EmployeeId = value.EmployeeId,
                        Salary = value.Salary,
                        Guests = value.Guests,
                        Restaurant = new Restaurant() { RestaurantName = "ASD" },
                        RestaurantId = value.RestaurantId
                    };
                    OnPropertyChanged();
                    (DeleteEmployee as RelayCommand).NotifyCanExecuteChanged();
                    //(UpdateEmployee as RelayCommand).NotifyCanExecuteChanged();
                }
            }
        }

        public ICommand CreateEmployee { get; set; }
        public ICommand DeleteEmployee { get; set; }
        public ICommand UpdateEmployee { get; set; }
        #endregion

        #region Restaurants

        public RestCollection<Restaurant> Restaurants { get; set; }

        private Restaurant selectedRestaurant;

        public Restaurant SelectedRestaurant
        {
            get { return selectedRestaurant; }
            set
            {
                if (value != null)
                {
                    selectedRestaurant = new Restaurant()
                    {
                        RestaurantName = value.RestaurantName,
                        Restaurant_id = value.Restaurant_id,
                        Foodlist = value.Foodlist,
                        Employees = value.Employees,
                        Rating = value.Rating
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



        #endregion

        #region Guests

        public RestCollection<Guest> Guests { get; set; }

        private Guest selectedGuest;

        public Guest SelectedGuest
        {
            get { return selectedGuest; }
            set
            {
                if (value != null)
                {
                    selectedGuest = new Guest()
                    {
                        DeliveredFood = value.DeliveredFood,
                        Email = value.Email,
                        Employee = value.Employee,
                        GuestId = value.GuestId,
                        Name = value.Name,
                        Number = value.Number,
                        OrderId = value.OrderId
                    };
                    OnPropertyChanged();
                    (DeleteGuest as RelayCommand).NotifyCanExecuteChanged();
                    //(UpdateEmployee as RelayCommand).NotifyCanExecuteChanged();
                }
            }
        }

        public ICommand CreateGuest { get; set; }
        public ICommand DeleteGuest { get; set; }
        public ICommand UpdateGuest { get; set; }



        #endregion

        public MainWindowViewModel()
        {
            #region Seting up Employees
            Employees = new RestCollection<Employee>("http://localhost:31877/", "employee");
            CreateEmployee = new RelayCommand(() =>
            {
                Employees.Add(new Employee()
                {
                    Name = "Enter new Employee's Name here!",
                    RestaurantId = 1
                });
            });

            DeleteEmployee = new RelayCommand(() =>
            Employees.Delete(SelectedEmployee.EmployeeId),
            () => { return SelectedEmployee != null; }
            );
            UpdateEmployee = new RelayCommand(() =>
            Employees.Update(SelectedEmployee)
            );
            #endregion

            #region Setting up Restaurants

            Restaurants = new RestCollection<Restaurant>("http://localhost:31877/", "restaurant");
            CreateRestaurant = new RelayCommand(() =>
            {
                Restaurants.Add(new Restaurant()
                {
                    RestaurantName = "Enter new Restauran's Name here!",
                });
            });

            DeleteRestaurant = new RelayCommand(() =>
            Restaurants.Delete(SelectedRestaurant.Restaurant_id),
            () => { return SelectedRestaurant != null; }
            );
            Updaterestaurant = new RelayCommand(() => Restaurants.Update(SelectedRestaurant));


            #endregion

            #region Setting up Guests

            Guests = new RestCollection<Guest>("http://localhost:31877/", "guest");
            CreateGuest = new RelayCommand(() =>
            {
                Guests.Add(new Guest()
                {
                    Name = "Enter new Guest's Name here!",
                    OrderId=1
                });
            });

            DeleteGuest = new RelayCommand(() =>
            Guests.Delete(SelectedGuest.GuestId),
            () => { return SelectedGuest != null; }
            );
            UpdateGuest = new RelayCommand(() => Guests.Update(SelectedGuest));


            #endregion
        }
    }
}
