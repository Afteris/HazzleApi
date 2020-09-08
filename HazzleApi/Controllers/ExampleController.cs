using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HazzleApi.Models;
using HazzleApi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HazzleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly IExampleService exampleService;
        public ExampleController(IExampleService _exampleService) 
        {
            exampleService = _exampleService;
        }
        // GET: api/<ExampleController>
        [HttpGet]
        public IEnumerable<ExampleModel> Get()
        {
            return exampleService.GetExampleModels();
           
        }

        // GET api/<ExampleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ExampleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ExampleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExampleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            exampleService.DeleteExampleModel(id);
        }
    }
}
