using ZC7ADM_HFT_2021221.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZC7ADM_HFT_2021221.Data
{
    public class RestaurantDbContext: DbContext
    {

        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseLazyLoadingProxies()
                    .UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>()
                .HasMany(r=>r.Employees)
                .WithOne(e=>e.Restaurant)
                .HasForeignKey(fk=>fk.RestaurantId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<Employee>()
                .HasMany(g => g.Guests)
                .WithOne(r => r.Employee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasForeignKey(fk=>fk.GuestId);
           
            #region filling database with datas


            Food GulyasSoup = new Food()
            { Name = "Gulyás leves",
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
                RestaurantName = "Soupaurant",
                Foodlist = new List<Food>(),
                Rating = 4,
                Restaurant_id=1                
            };

            Soupaurant.Foodlist.Add(GulyasSoup);
            Soupaurant.Foodlist.Add(MeatSoup);

            Restaurant Italiano = new Restaurant()
            {
                RestaurantName = "Italiano",
                Foodlist = new List<Food>(),
                Rating = 5,
                Restaurant_id = 2
            };

            Italiano.Foodlist.Add(Pizza);
            Italiano.Foodlist.Add(Pasta);

            Employee ItalianoBob = new Employee()
            {
                EmployeeId = 0,
                Restaurant = Italiano,
                Name = "Bob",
                Salary = 250000,
            };

            Employee ItalianoMario = new Employee()
            {
                EmployeeId = 1,
                Restaurant = Italiano,
                Name = "Mario",
                Salary = 255000,
            };

            Employee SoupDan = new Employee()
            {
                EmployeeId = 0,
                Restaurant = Soupaurant,
                Name = "Dan",
                Salary = 300000,
            };

            Employee SoupKirk = new Employee()
            {
                EmployeeId = 1,
                Restaurant = Soupaurant,
                Name = "Kirk",
                Salary = 350000,
            };

            Guest JH = new Guest()
            {
                Name = "James Hetfield",
                Number = "06201111213",
                Email = "metallica.james.hetfield@gmail.com",
                Employee = SoupKirk,
                DeliveredFood = MeatSoup,
                GuestId = 0,
                OrderId = 0
            };

            Guest LU = new Guest()
            {
                Name = "Lars Ulrich",
                Number = "06203451134",
                Email = "metallica.lars.ulrich@gmail.com",
                Employee = SoupKirk,
                DeliveredFood = GulyasSoup,
                GuestId = 1,
                OrderId = 1
            };

            Guest SG = new Guest()
            {
                Name = "Synister Gates",
                Number = "06 20 123 4432",
                Email = "avengedsevenfold.synister.gates@gmail.com",
                Employee = ItalianoMario,
                DeliveredFood = Pizza,
                GuestId = 0,
                OrderId = 0
            };

            Guest MS = new Guest()
            {
                Name = "Matt Shadows",
                Number = "06 20 678 9945",
                Email = "avengedsevenfold.synister.gates@gmail.com",
                Employee = ItalianoBob,
                DeliveredFood = Pasta,
                GuestId = 1,
                OrderId = 1
            };

            #endregion

            modelBuilder.Entity<Restaurant>().HasData(Italiano,Soupaurant);
            modelBuilder.Entity<Employee>().HasData(ItalianoBob,ItalianoMario,SoupDan,SoupKirk);
            modelBuilder.Entity<Guest>().HasData(JH,LU,SG,MS);
        }

        public RestaurantDbContext()
        {
            this.Database.EnsureCreated();
        }

    }
}
