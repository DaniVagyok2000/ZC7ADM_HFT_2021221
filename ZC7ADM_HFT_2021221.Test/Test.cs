using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZC7ADM_HFT_2021221.Data;
using NUnit.Framework;
using ZC7ADM_HFT_2021221.Logic;
using ZC7ADM_HFT_2021221.Repository;
using ZC7ADM_HFT_2021221.Models;
using Moq;

namespace ZC7ADM_HFT_2021221.Test
{
    [TestFixture]
    public class Test
    {
        EmployeeLogic eLogic;
        RestaurantLogic rLogic;
        GuestLogic gLogic;
        public Test()
        {

            var employees = new List<Employee>().AsQueryable();
            var restaurants = new List<Restaurant>().AsQueryable();
            var guests = new List<Guest>().AsQueryable();

            List<Employee> emps = new List<Employee>();
            List<Guest> gue = new List<Guest>();
            List<Restaurant> res = new List<Restaurant>();

            #region filling lists with datas



            Food GulyasSoup = new Food()
            {
                Name = "Gulyás leves",
                Price = 2500
            };
            Food MeatSoup = new Food()
            {
                Name = "Húsleves",
                Price = 2000
            };
            Food Pizza = new Food()
            {
                Name = "Pizza",
                Price = 1800
            };
            Food Pasta = new Food()
            {
                Name = "Pasta",
                Price = 1200
            };

            Restaurant Soupaurant = new Restaurant()
            {
                Restaurant_id = 1,
                RestaurantName = "Soupaurant",
                Foodlist = new List<Food>(),
                Rating = 4
            };

            Soupaurant.Foodlist.Add(GulyasSoup);
            Soupaurant.Foodlist.Add(MeatSoup);

            Restaurant Italiano = new Restaurant()
            {
                Restaurant_id = 2,
                RestaurantName = "Italiano",
                Foodlist = new List<Food>(),
                Rating = 5,                
            };

            Italiano.Foodlist.Add(Pizza);
            Italiano.Foodlist.Add(Pasta);

            Employee ItalianoBob = new Employee()
            {
                EmployeeId = 1,
                Restaurant = Italiano,
                Name = "Bob",
                Salary = 250000,
                RestaurantId = Italiano.Restaurant_id
            };

            Employee ItalianoMario = new Employee()
            {
                EmployeeId = 2,
                RestaurantId = Italiano.Restaurant_id,
                Restaurant = Italiano,
                Name = "Mario",
                Salary = 255000,
            };

            Employee SoupDan = new Employee()
            {
                EmployeeId = 3,
                Name = "Dan",
                Salary = 300000,
                RestaurantId = Soupaurant.Restaurant_id
            };

            Employee SoupKirk = new Employee()
            {
                EmployeeId = 4,
                Name = "Kirk",
                Salary = 350000,
                RestaurantId = Soupaurant.Restaurant_id
            };

            Guest JH = new Guest()
            {
                Name = "James Hetfield",
                Number = "06201111213",
                Email = "metallica.james.hetfield@gmail.com",
                Employee = SoupKirk,
                DeliveredFood = MeatSoup,
                GuestId = 4,
                OrderId = SoupKirk.EmployeeId
            };

            Guest LU = new Guest()
            {
                Name = "Lars Ulrich",
                Number = "06203451134",
                Email = "metallica.lars.ulrich@gmail.com",
                Employee = SoupKirk,
                DeliveredFood = GulyasSoup,
                GuestId = 3,
                OrderId = SoupKirk.EmployeeId
            };

            Guest SG = new Guest()
            {
                Name = "Synyster Gates",
                Number = "06 20 123 4432",
                Email = "avengedsevenfold.synister.gates@gmail.com",
                 Employee = ItalianoMario,
                DeliveredFood = Pizza,
                GuestId = 2,
                OrderId = ItalianoMario.EmployeeId
            };

            Guest MS = new Guest()
            {
                Name = "Matt Shadows",
                Number = "06 20 678 9945",
                Email = "avengedsevenfold.synister.gates@gmail.com",
                Employee = ItalianoBob,
                DeliveredFood = Pasta,
                GuestId = 1,
                OrderId = ItalianoBob.EmployeeId
            };

            emps.Add(SoupKirk);
            emps.Add(SoupDan);
            emps.Add(ItalianoBob);
            emps.Add(ItalianoMario);

            gue.Add(JH);
            gue.Add(LU);
            gue.Add(SG);
            gue.Add(MS);

            res.Add(Italiano);
            res.Add(Soupaurant);

            #endregion

            employees=emps.AsQueryable();
            restaurants = res.AsQueryable();
            guests = gue.AsQueryable();

            var mockEmployeeRepo = new Mock<IEmployeeRepository>();
            var mockRestaurantRepo = new Mock<IRestaurantRepository>();
            var mockGuestRepo = new Mock<IGuestRepository>();

            mockEmployeeRepo.Setup(e => e.ReadAll()).Returns(employees);
            mockRestaurantRepo.Setup(r => r.ReadAll()).Returns(restaurants);
            mockGuestRepo.Setup(g=>g.ReadAll()).Returns((IQueryable<Guest>)guests);

            eLogic = new EmployeeLogic(mockEmployeeRepo.Object);
            rLogic = new RestaurantLogic(mockRestaurantRepo.Object);
            gLogic = new GuestLogic(mockGuestRepo.Object);
        }
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

        [Test]
        public void HadMoreThanOneGuestTest() 
        {
            var employee = eLogic.HadMoreThanOneGuest().ToArray();

            Assert.That(employee[0].Name, Is.EqualTo("Kirk"));
        
        }

        public void AVGFoodPriceByRestaurantTest() 
        {
            var prices=rLogic.AVGFoodPriceByRestaurant().ToArray();
            ;
            //Assert.That();
            //Assert.That();
            //Assert.That();
        }



    }
}
