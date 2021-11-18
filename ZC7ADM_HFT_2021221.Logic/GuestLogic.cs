using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZC7ADM_HFT_2021221.Repository;
using ZC7ADM_HFT_2021221.Models;

namespace ZC7ADM_HFT_2021221.Logic
{
    public class GuestLogic : IGuestLogic
    {
        IGuestRepository guestRepo;

        public GuestLogic(IGuestRepository gr)
        {
            this.guestRepo = gr;
        }

        public void Create(Guest guest)
        {
            guestRepo.Create(guest);
        }

        public Guest Read(int id)
        {
            return guestRepo.Read(id);
        }

        public IEnumerable<Guest> ReadAll()
        {
            return guestRepo.ReadAll();
        }
        public void Delete(int id)
        {
            guestRepo.Delete(id);
        }

        public void Update(Guest guest)
        {
            guestRepo.Update(guest);
        }

        //non-crud methods

        //Gives back the names of the guests who ate at Italiano
        public IEnumerable<string> ItalianoGuestNames()
        {
            return guestRepo.ReadAll().Where(x => x.Employee.Restaurant.RestaurantName.Equals("Italiano")).Select(g => g.Name);
        }
    }
}
