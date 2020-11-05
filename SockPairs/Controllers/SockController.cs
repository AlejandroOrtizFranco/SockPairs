using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SockPairs.Models;
using SockPairs.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SockPairs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SockController : ControllerBase
    {
        private readonly ISockService _service;

        public SockController(ISockService service)
        {
            _service = service;
        }
        // GET: api/<SockController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SockController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SockController>
        [HttpPost]
        public ActionResult<int> Post(SockDto pairs)
        {
            return Ok(new {Result = _service.PostPairs(pairs.Pairs)});
        }

        // PUT api/<SockController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SockController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
