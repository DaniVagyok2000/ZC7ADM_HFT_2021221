using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZC7ADM_HFT_2021221.Data;
using System.Linq;
using NUnit.Framework;

namespace ZC7ADM_HFT_2021221.Test
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void DBHasData() 
        {
            RestaurantDbContext db = new RestaurantDbContext();

            var r = db.Restaurants.ToArray();
            var e = db.Employees.ToArray();
            var g = db.Guests.ToArray();

            Assert.That(e,Is.Not.Null);
            Assert.That(r,Is.Not.Null);
            Assert.That(g,Is.Not.Null);
        }

    }
}
