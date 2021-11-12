using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZC7ADM_HFT_2021221.Data;
using ZC7ADM_HFT_2021221.Models;

namespace ZC7ADM_HFT_2021221.Repository
{
    public class GuestRepository : IGuestRepository
    {

        RestaurantDbContext db;

        public GuestRepository(RestaurantDbContext db)
        {
            this.db = db;
        }


        public void Create(Guest rest)
        {
            db.Guests.Add(rest);
            db.SaveChanges();
        }

        public Guest Read(int id)
        {
            return db.Guests.FirstOrDefault(f => f.GuestId == id);
        }

        public IQueryable<Guest> ReadAll()
        {
            return db.Guests;
        }
        public void Delete(int id)
        {
            db.Guests.Remove(Read(id));
            db.SaveChanges();
        }

        public void Update(Guest rest)
        {
            var oldrest = Read(rest.GuestId);
            oldrest.Name = rest.Name;
            oldrest.DeliveredFood = rest.DeliveredFood;
            oldrest.Email = rest.Email;
            oldrest.Employee = rest.Employee;
            oldrest.GuestId = rest.GuestId;
            oldrest.Number = rest.Number;
            oldrest.OrderId = rest.OrderId;
            db.SaveChanges();

        }

    }
}
