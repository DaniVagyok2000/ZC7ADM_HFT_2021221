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
            menu.Add("Displays Max Average salary by Restaurants", () => Displayer.RestaurantWorkerAVGSalaryMax(rest));
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
