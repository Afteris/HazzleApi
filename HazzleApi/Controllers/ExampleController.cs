using System.Collections.Generic;
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
        public ExampleModel Get(int id)
        {
           return exampleService.GetExampleModel(id);
        }

        // POST api/<ExampleController>
        [HttpPost]
        public void Post([FromBody] ExampleModel model)
        {
                       
            exampleService.CreateExampleModel(model);
        
        }

        // PUT api/<ExampleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ExampleModel model)
        {
            exampleService.UpdateExampleModel(model);
        }

        // DELETE api/<ExampleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            exampleService.DeleteExampleModel(id);
        }
    }
}
