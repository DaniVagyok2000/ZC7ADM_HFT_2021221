using System;
using ZC7ADM_HFT_2021221.Data;
using System.Linq;

namespace ZC7ADM_HFT_2021221.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantDbContext db = new RestaurantDbContext();

            var q = db.Employees.Select(x => x.Name);
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
