using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZC7ADM_HFT_2021221.Logic;
using ZC7ADM_HFT_2021221.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZC7ADM_HFT_2021221.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {

        IRestaurantLogic rl;

        public RestaurantController(IRestaurantLogic restaurantLogic)
        {
            this.rl = restaurantLogic;
        }

        // GET: api/<RestaurantController>
        [HttpGet]
        public IEnumerable<Restaurant> Get()
        {
            return rl.ReadAll();
        }

        // GET api/<RestaurantController>/5
        [HttpGet("{id}")]
        public Restaurant Get(int id)
        {
            return rl.Read(id);
        }

        // POST api/<RestaurantController>
        [HttpPost]
        public void Post([FromBody] Restaurant value)
        {


        }

        // PUT api/<RestaurantController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RestaurantController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
