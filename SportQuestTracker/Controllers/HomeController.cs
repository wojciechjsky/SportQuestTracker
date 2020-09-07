using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SportQuestTracker.Controllers
{
    /// <summary>
    /// This is API HomeController
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET: api/<IndexController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get a value
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<IndexController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<IndexController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<IndexController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IndexController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}