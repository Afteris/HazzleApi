using System.Collections.Generic;
using System.Net;
using System.Net.Mime;
using AutoMapper;
using HazzleApi.Models;
using HazzleApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HazzleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly IExampleService _exampleService;
        private readonly IMapper _mapper;

        public ExampleController(IExampleService exampleService, IMapper mapper) 
        {
            _exampleService = exampleService;
            _mapper = mapper;

        }
        // GET: api/<ExampleController>
        [HttpGet]
        public IEnumerable<ExampleModel> Get()
        {
            
            return _exampleService.GetExampleModels(); 

        }

        // GET api/<ExampleController>/5
        [HttpGet("{id}")]
        public ExampleModel GetById(int id)
        {
           return _exampleService.GetExampleModel(id);
        }

        // POST api/<ExampleController>
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] ExampleVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var exampleModel = _mapper.Map<ExampleModel>(model);
            _exampleService.CreateExampleModel(exampleModel);


            return CreatedAtAction(nameof(GetById), new { id = exampleModel.Id }, exampleModel);
        }

        // PUT api/<ExampleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ExampleVM model)
        {
            var exampleModel = _mapper.Map<ExampleModel>(model);
            _exampleService.UpdateExampleModel(exampleModel);
        }

        // DELETE api/<ExampleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _exampleService.DeleteExampleModel(id);
        }
    }
}
