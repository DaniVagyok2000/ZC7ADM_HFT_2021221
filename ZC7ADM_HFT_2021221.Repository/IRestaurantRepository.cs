using System.Linq;
using ZC7ADM_HFT_2021221.Models;

namespace ZC7ADM_HFT_2021221.Repository
{
    interface IRestaurantRepository
    {
        void Create(Restaurant rest);
        void Delete(int id);
        Restaurant Read(int id);
        IQueryable<Restaurant> ReadAll();
        void Update(Restaurant rest);
    }
}