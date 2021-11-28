using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZC7ADM_HFT_2021221.Logic;
using ZC7ADM_HFT_2021221.Models;

namespace ZC7ADM_HFT_2021221.Endpoint.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class StatController : ControllerBase
    {
        IEmployeeLogic el;
        IGuestLogic gl;
        IRestaurantLogic rl;

        public StatController(IRestaurantLogic restaurantLogic,IEmployeeLogic employeeLogic,IGuestLogic guestLogic)
        {
            this.rl = restaurantLogic;
            this.gl = guestLogic;
            this.el = employeeLogic;
        }

        // /stat/hadmoretahoneguest
        public IEnumerable<Employee> HadMoreThanOneGuest()
        {
            return el.HadMoreThanOneGuest();
        }

        // /stat/ThreeStarsOrHigherRatedRestaurantWorkers
        public IEnumerable<Employee> ThreeStarsOrHigherRatedRestaurantWorkers()
        {
            return el.ThreeStarsOrHigherRatedRestaurantWorkers();
        }

        public IEnumerable<string> ItalianoGuestNames()
        {
            return gl.ItalianoGuestNames();
        }
        
        public IEnumerable<Guest> KirksGuests()
        {
            return gl.KirksGuests();
        }

        public IEnumerable<KeyValuePair<string, double>> AVGFoodPriceByRestaurant()
        {
            return rl.AVGFoodPriceByRestaurant();
        }

    }
}
