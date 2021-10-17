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
            var jh = ctx.Guests.Where(x => x.Name.Equals("James Hetfield")).Select(x => new { Name = x.Name, Email = x.Email });


            foreach (var item in jh)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
