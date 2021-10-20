using System.Linq;
using ZC7ADM_HFT_2021221.Models;

namespace ZC7ADM_HFT_2021221.Repository
{
    interface IGuestRepository
    {
        void Create(Guest rest);
        void Delete(int id);
        Guest Read(int id);
        IQueryable<Guest> ReadAll();
        void Update(Guest rest);
    }
}