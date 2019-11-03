using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrgMgmtServer.Controllers
{
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Imdb.Imdb.GetAllEmployees());
        }


        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(Imdb.Imdb.GetEmployeeById(id));
        }

        // GET api/<controller>/5
        [HttpGet("Manager/{id}")]
        public IActionResult GetManager(int id)
        {
            return Ok(Imdb.Imdb.GetManagerByEmp(id));
        }

        // GET api/<controller>/5
        [HttpGet("TasksByEmpId/{id}")]
        public IActionResult GetTasksByEmpId(int id)
        {
            return Ok(Imdb.Imdb.GetTasksByEmpId(id));
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
