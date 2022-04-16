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
    public class EmployeeController : ControllerBase
    {
        IEmployeeLogic eLogic;
        public EmployeeController(IEmployeeLogic employeeLogic
            )
        {
            this.eLogic = employeeLogic;
        }

        // GET: /employee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return eLogic.ReadAll();
        }

        // GET employees/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return eLogic.Read(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Employee value)
        {
            eLogic.Create(value);
        }

        // PUT api/<ValuesController>/5
        //[HttpPut("{id}")]
        public void Put([FromBody] Employee value)
        {
            eLogic.Update(value);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            eLogic.Delete(id);
        }
    }
}
