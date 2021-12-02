using ConsoleTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ZC7ADM_HFT_2021221.Models;

namespace ZC7ADM_HFT_2021221.Client
{
    class Program
    {
        static void GuestDisplayer(RestService rest) 
        {
            var guests = rest.Get<Guest>("guest");
            foreach (var item in guests)
            {
                Console.WriteLine("---Guests---");
                Console.WriteLine("Guest's Name: "+item.Name);
                Console.WriteLine("Guest's Number: "+item.Number);
                Console.WriteLine("Guest's Email: "+item.Email);
            }
            Console.WriteLine("Press any button to return to main menu!");
            Console.ReadLine();
        }

        static void EmployeesDisplayer(RestService rest) 
        {
            var employees = rest.Get<Employee>("employee");
            var guests = employees.Select(x=>x.Guests).ToArray();
            foreach (var item in employees)
            {
                Console.WriteLine("----Employees----");
                Console.WriteLine("Employees Name: " + (item as Employee).Name);
                Console.WriteLine("Employees Salary: " + (item as Employee).Salary);
                item.Guests.ToList().ForEach(g => Console.WriteLine("Guest's served: "+g.Name));
            }
            Console.WriteLine("Press any button to return to main menu!");
            Console.ReadLine();
        }
        static void HadMoreThanOneGuestDisplayer(RestService rest) 
        {
            var employees = rest.Get<Employee>("/stat/hadmorethanoneguest");
            foreach (var item in employees)
            {
                Console.WriteLine("----Employees----");
                Console.WriteLine("Employees Name: " + (item as Employee).Name);
                Console.WriteLine("Employees Salary: " + (item as Employee).Salary);
                item.Guests.ToList().ForEach(g => Console.WriteLine("Guest's served: " + g.Name));
            }
            Console.WriteLine("Press any button to return to main menu!");
            Console.ReadLine();

        }
        static void KirsksGuestsDisplayer(RestService rest) 
        {
            var guests = rest.Get<Guest>("/stat/kirksguests");
            foreach (var item in guests)
            {
                Console.WriteLine("---Guests---");
                Console.WriteLine("Guest's Name: " + item.Name);
                Console.WriteLine("Guest's Number: " + item.Number);
                Console.WriteLine("Guest's Email: " + item.Email);
            }
            Console.WriteLine("Press any button to return to main menu!");
            Console.ReadLine();

        }
        static void RestaurantDisplayer(RestService rest) 
        {
            var restaurant = rest.Get<Restaurant>("restaurant");
            var employees = restaurant.Select(x=>x.Employees).ToArray();
            foreach (var item in restaurant)
            {
                Console.WriteLine("---Restaurant---");
                Console.WriteLine("Restaurants Name: "+item.RestaurantName);
                Console.WriteLine("Restaurants Rating: "+item.RestaurantName);
                item.Employees.ToList().ForEach(e => Console.WriteLine("Employee's Name: " +e.Name));
                
            }
            Console.WriteLine("Press any button to return to main menu!");
            Console.ReadLine();

        }

        static void ThreeStarsOrHigherRatedRestaurantWorkersDisplayer(RestService rest) 
        {
            var employees=rest.Get<Employee>("/stat/ThreeStarsOrHigherRatedRestaurantWorkers");
            foreach (var item in employees)
            {
                Console.WriteLine("----Employees----");
                Console.WriteLine("Employees Name: " + (item as Employee).Name);
                Console.WriteLine("Employees Salary: " + (item as Employee).Salary);
                item.Guests.ToList().ForEach(g => Console.WriteLine("Guest's served: " + g.Name));
            }
            Console.WriteLine("Press any button to return to main menu!");
            Console.ReadLine();

        }

        static void AVGFoodPriceByRestaurantDisplayer(RestService rest)
        {
            var avg = rest.Get<KeyValuePair<string,double>>("/stat/AVGFoodPriceByRestaurant");
            foreach (var item in avg)
            {
                Console.WriteLine("Restaurant: "+item.Key);
                Console.WriteLine("Average food price: "+item.Value);
            }
            Console.WriteLine("Press any key to return to menu!");
            Console.ReadLine();
        }

        static void ItalianoGuestNamesDisplayer(RestService rest) 
        {
            var names = rest.Get<string>("/stat/ItalianoGuestNames");
            foreach (var item in names)
            {
                Console.WriteLine("Name: "+item);
            }
            Console.WriteLine("Press any key to return to menu!");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(5000);

            RestService rest = new RestService("http://localhost:31877");

            var menu = new ConsoleMenu();
            menu.Add("Displays Restaurants",()=>Program.RestaurantDisplayer(rest));
            menu.Add("Displays Guests", () => GuestDisplayer(rest));
            menu.Add("Displays Employees", () => EmployeesDisplayer(rest));
            menu.Add("Displays Employee Kirk's Guests", () => KirsksGuestsDisplayer(rest));
            menu.Add("Displays Employees who had more than one Guest", () => HadMoreThanOneGuestDisplayer(rest));
            menu.Add("Displays Restaurant workers who work in a restaurant that has 3 or higher rating", () => ThreeStarsOrHigherRatedRestaurantWorkersDisplayer(rest));
            menu.Add("Displays Average food price by restaurant", () => AVGFoodPriceByRestaurantDisplayer(rest));
            menu.Add("Displays Guests in Italiano restaurant", () => ItalianoGuestNamesDisplayer(rest));

            menu.Show();


            
            

            
        }
    }
}
