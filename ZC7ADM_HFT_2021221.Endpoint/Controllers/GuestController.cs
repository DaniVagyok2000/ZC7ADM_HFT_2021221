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
    public class GuestController : ControllerBase
    {

        IGuestLogic gl;
        public GuestController(IGuestLogic guestLogic)
        {
            this.gl = guestLogic;
        }

        // GET: api/<GuestController>
        [HttpGet]
        public IEnumerable<Guest> Get()
        {
            return gl.ReadAll();
        }

        // GET api/<GuestController>/5
        [HttpGet("{id}")]
        public Guest Get(int id)
        {
            return gl.Read(id);
        }

        // POST api/<GuestController>
        [HttpPost]
        public void Post([FromBody] Guest value)
        {
            gl.Create(value);
        }

        // PUT api/<GuestController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Guest value)
        {
            gl.Update(value);
        }

        // DELETE api/<GuestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            gl.Delete(id);
        }
    }
}
