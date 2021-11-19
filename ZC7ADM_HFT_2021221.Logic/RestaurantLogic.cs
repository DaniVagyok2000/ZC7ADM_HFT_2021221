using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZC7ADM_HFT_2021221.Repository;
using ZC7ADM_HFT_2021221.Models;

namespace ZC7ADM_HFT_2021221.Logic
{
    public class RestaurantLogic : IRestaurantLogic
    {
        IRestaurantRepository restRepo;

        public RestaurantLogic(IRestaurantRepository restrepo)
        {
            this.restRepo = restrepo;
        }

        public void Create(Restaurant rest)
        {
            if (rest.RestaurantName == "")
            {
                throw new ArgumentNullException("A restaurant must have a name!");
            }
            restRepo.Create(rest);
        }

        public Restaurant Read(int id)
        {
            return restRepo.Read(id);
        }

        public IEnumerable<Restaurant> ReadAll()
        {
            return restRepo.ReadAll();
        }
        public void Delete(int id)
        {
            restRepo.Delete(id);
        }

        public void Update(Restaurant rest)
        {
            restRepo.Update(rest);
        }

        //non-crud methods

        public IEnumerable<KeyValuePair<string, double>> AVGFoodPriceByRestaurant()
        {
            return from x in restRepo.ReadAll()
                   group x by x into g
                   select new KeyValuePair<string, double>(g.Key.RestaurantName, g.Key.Foodlist.Average(p => p.Price));
        }

    }
}
