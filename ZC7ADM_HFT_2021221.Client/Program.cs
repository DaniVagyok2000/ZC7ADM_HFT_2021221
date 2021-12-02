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
        //static void GuestDisplayer(RestService rest) 
        //{
        //    var guests = rest.Get<Guest>("guest");
        //    foreach (var item in guests)
        //    {
        //        Console.WriteLine("---Guests---");
        //        Console.WriteLine("Guest's Name: "+item.Name);
        //        Console.WriteLine("Guest's Number: "+item.Number);
        //        Console.WriteLine("Guest's Email: "+item.Email);
        //        Console.WriteLine("Guest's GuestId: "+item.GuestId);
        //    }
        //    Console.WriteLine("Press any button to return to main menu!");
        //    Console.ReadLine();
        //}
        //static void EmployeesDisplayer(RestService rest) 
        //{
        //    var employees = rest.Get<Employee>("employee");
        
        //    foreach (var item in employees)
        //    {
        //        Console.WriteLine("----Employees----");
        //        Console.WriteLine("Employees Name: " + (item as Employee).Name);
        //        Console.WriteLine("Employees Salary: " + (item as Employee).Salary);
        //        Console.WriteLine("Employee's Id: "+item.EmployeeId);
        //        item.Guests.ToList().ForEach(g => Console.WriteLine("Guest's served: "+g.Name));
        //    }
        //    Console.WriteLine("Press any button to return to main menu!");
        //    Console.ReadLine();
        //}
        //static void HadMoreThanOneGuestDisplayer(RestService rest) 
        //{
        //    var employees = rest.Get<Employee>("/stat/hadmorethanoneguest");
        //    foreach (var item in employees)
        //    {
        //        Console.WriteLine("----Employees----");
        //        Console.WriteLine("Employees Name: " + (item as Employee).Name);
        //        Console.WriteLine("Employees Salary: " + (item as Employee).Salary);
        //        item.Guests.ToList().ForEach(g => Console.WriteLine("Guest's served: " + g.Name));
        //    }
        //    Console.WriteLine("Press any button to return to main menu!");
        //    Console.ReadLine();

        //}
        //static void KirsksGuestsDisplayer(RestService rest) 
        //{
        //    var guests = rest.Get<Guest>("/stat/kirksguests");
        //    foreach (var item in guests)
        //    {
        //        Console.WriteLine("---Guests---");
        //        Console.WriteLine("Guest's Name: " + item.Name);
        //        Console.WriteLine("Guest's Number: " + item.Number);
        //        Console.WriteLine("Guest's Email: " + item.Email);
        //    }
        //    Console.WriteLine("Press any button to return to main menu!");
        //    Console.ReadLine();

        //}
        //static void RestaurantDisplayer(RestService rest) 
        //{
        //    var restaurant = rest.Get<Restaurant>("restaurant");

        //    foreach (var item in restaurant)
        //    {
        //        Console.WriteLine("---Restaurant---");
        //        Console.WriteLine("Restaurants Name: "+item.RestaurantName);
        //        Console.WriteLine("Restaurants Rating: "+item.RestaurantName);
        //        Console.WriteLine("Restaurant's Id: "+ item.Restaurant_id);
        //        item.Employees.ToList().ForEach(e => Console.WriteLine("Employee's Name: " +e.Name));
                
        //    }
        //    Console.WriteLine("Press any button to return to main menu!");
        //    Console.ReadLine();

        //}

        //static void ThreeStarsOrHigherRatedRestaurantWorkersDisplayer(RestService rest) 
        //{
        //    var employees=rest.Get<Employee>("/stat/ThreeStarsOrHigherRatedRestaurantWorkers");
        //    foreach (var item in employees)
        //    {
        //        Console.WriteLine("----Employees----");
        //        Console.WriteLine("Employees Name: " + (item as Employee).Name);
        //        Console.WriteLine("Employees Salary: " + (item as Employee).Salary);
        //        item.Guests.ToList().ForEach(g => Console.WriteLine("Guest's served: " + g.Name));
        //    }
        //    Console.WriteLine("Press any button to return to main menu!");
        //    Console.ReadLine();

        //}

        //static void AVGFoodPriceByRestaurantDisplayer(RestService rest)
        //{
        //    var avg = rest.Get<KeyValuePair<string,double>>("/stat/AVGFoodPriceByRestaurant");
        //    foreach (var item in avg)
        //    {
        //        Console.WriteLine("Restaurant: "+item.Key);
        //        Console.WriteLine("Average food price: "+item.Value);
        //    }
        //    Console.WriteLine("Press any key to return to menu!");
        //    Console.ReadLine();
        //}

        //static void ItalianoGuestNamesDisplayer(RestService rest) 
        //{
        //    var names = rest.Get<string>("/stat/ItalianoGuestNames");
        //    foreach (var item in names)
        //    {
        //        Console.WriteLine("Name: "+item);
        //    }
        //    Console.WriteLine("Press any key to return to menu!");
        //    Console.ReadLine();
        //}

        //static Employee MakeEmployee()
        //{
        //    Employee e = new Employee();
        //    Console.WriteLine("Insert Employee's Name: ");
        //    string name = Console.ReadLine();
        //    e.Name = name;
        //    Console.WriteLine("Insert Employee's Salary: ");
        //    int salary = int.Parse(Console.ReadLine());
        //    e.Salary = salary;
        //    Console.WriteLine("Restaurant's id: ");
        //    e.RestaurantId = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Would you like to insert Guests? y/n");
        //    char ans = char.Parse(Console.ReadLine());
        //    if (ans == 'y')
        //    {
        //        Console.WriteLine("How many?");
        //        int number = int.Parse(Console.ReadLine());
        //        for (int i = 0; i < number; i++)
        //        {
        //            e.Guests.Add(MakeGuest());
        //        }
        //    }
        //    return e;
        //}
        //static void CreateEmployeeMethod(RestService rest)
        //{
        //    Employee e=MakeEmployee();
        //    rest.Post<Employee>(e, "employee");        
        //}
        //static void CreateGuestMethod(RestService rest)
        //{
        //    Guest g = MakeGuest();
        //    ;
        //    rest.Post<Guest>(g, "guest");

        //}
        //static Guest MakeGuest() 
        //{
        //    Guest g = new Guest();

        //    Console.WriteLine("Insert Name: ");
        //    string name = Console.ReadLine();
        //    g.Name = name;

        //    Console.WriteLine("Insert Email: ");
        //    string email = Console.ReadLine();
        //    g.Email = email;

        //    Console.WriteLine("Insert number: ");
        //    string number = Console.ReadLine();
        //    g.Number = number;

        //    Console.WriteLine("Insert OrderId: ");
        //    g.OrderId = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Insert Food name:");

        //    Food f = new Food();
        //    f.Name = Console.ReadLine();
        //    Console.WriteLine("Insert Food's price: ");
        //    f.Price = int.Parse(Console.ReadLine());

        //    g.DeliveredFood = f;


        //    return g;
        //}
        //private static void DeleteGuestMethod(RestService rest)
        //{
        //    Console.WriteLine("Insert an Id to delete a Guest:");
        //    int number = int.Parse(Console.ReadLine());
        //    rest.Delete(number,"guest");
        //}
        //private static void DeleteRestaurantMethod(RestService rest)
        //{
        //    Console.WriteLine("Insert an Id to delete a Restaurant:");
        //    int number = int.Parse(Console.ReadLine());
        //    rest.Delete(number, "restaurant");
        //}
        //private static void DeleteEmployeeMethod(RestService rest)
        //{
        //    Console.WriteLine("Insert an Id to delete an Employee:");
        //    int number = int.Parse(Console.ReadLine());
        //    rest.Delete(number, "employee");
        //}

        //static void CreateRestaurantMethod(RestService rest)
        //{
        //    Restaurant r = new Restaurant();

        //    Console.WriteLine("Insert Name: ");
        //    r.RestaurantName = Console.ReadLine();

        //    Console.WriteLine("Insert rating: ");
        //    r.Rating = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Would you like to add foods? y/n");
        //    char ans =char.Parse(Console.ReadLine());
        //    if (ans=='y')
        //    {
        //        Console.WriteLine("How many?");
        //        int number = int.Parse(Console.ReadLine());
        //        for (int i = 0; i < number; i++)
        //        {
        //            Food f = new Food();
        //            Console.WriteLine("Insert Food's Name");
        //            f.Name = Console.ReadLine();
        //            Console.WriteLine("Insert Food's price");
        //            f.Price = int.Parse(Console.ReadLine());
        //            r.Foodlist.Add(f);
        //        }
        //    }             
            
        //    Console.WriteLine("Would you like to add Employees? y/n");
        //    ans = ' ';
        //    ans = char.Parse(Console.ReadLine());
        //    if (ans=='y')
        //    {
        //        Console.WriteLine("How many?");
        //        int number = int.Parse(Console.ReadLine());
        //        for (int i = 0; i < number; i++)
        //        {
        //            r.Employees.Add(MakeEmployee());
        //        }
        //    }
        //    rest.Post<Restaurant>(r,"restaurant");
        //}
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(5000);

            RestService rest = new RestService("http://localhost:31877");

            var menu = new ConsoleMenu();
            //Get
            menu.Add("Displays Restaurants",()=>Displayer.RestaurantDisplayer(rest));
            menu.Add("Displays Guests", () => Displayer.GuestDisplayer(rest));
            menu.Add("Displays Employees", () => Displayer.EmployeesDisplayer(rest));
            //Get non-crud
            menu.Add("Displays Employee Kirk's Guests", () => Displayer.KirsksGuestsDisplayer(rest));
            menu.Add("Displays Employees who had more than one Guest", () => Displayer.HadMoreThanOneGuestDisplayer(rest));
            menu.Add("Displays Restaurant workers who work in a restaurant that has 3 or higher rating", () => Displayer.ThreeStarsOrHigherRatedRestaurantWorkersDisplayer(rest));
            menu.Add("Displays Average food price by restaurant", () => Displayer.AVGFoodPriceByRestaurantDisplayer(rest));
            menu.Add("Displays Guests in Italiano restaurant", () => Displayer.ItalianoGuestNamesDisplayer(rest));
            //Create
            menu.Add("Create a new Employee", () => Displayer.CreateEmployeeMethod(rest));
            menu.Add("Create a new Guest", () => Displayer.CreateGuestMethod(rest));
            menu.Add("Create a new Restaurant", () => Displayer.CreateRestaurantMethod(rest));
            //Delete
            menu.Add("Delete an Employee", () => Displayer.DeleteEmployeeMethod(rest));
            menu.Add("Delete a Guest", () => Displayer.DeleteGuestMethod(rest));
            menu.Add("Delete a Restaurant", () => Displayer.DeleteRestaurantMethod(rest));
            //Update
            menu.Add("Update a Restaurant", () => Displayer.UpdateRestaurantMethod(rest));
            menu.Add("Update a Guest", () => Displayer.UpdateGuestMethod(rest));
            menu.Add("Update an Employee", () => Displayer.UpdateEmployeeMethod(rest));

            menu.Show();


            
            

            
        }

        
    }
}
