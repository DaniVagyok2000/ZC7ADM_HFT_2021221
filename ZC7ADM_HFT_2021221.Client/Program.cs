using System;
using ZC7ADM_HFT_2021221.Data;
using System.Linq;

namespace ZC7ADM_HFT_2021221.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantDbContext ctx = new RestaurantDbContext();
            var jh = ctx.Employees.ToArray();


            foreach (var item in jh)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
