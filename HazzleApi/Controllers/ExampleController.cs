using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public async Task<IActionResult> Put(int id, [FromBody] ExampleVM model)
        {
            var exampleModel = _mapper.Map<ExampleModel>(model);
            await _exampleService.UpdateExampleModelAsync(exampleModel);

            return Ok();
        }

        // DELETE api/<ExampleController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Delete(int id)
        {
            if (_exampleService.GetExampleModel(id) == null)
            {
                return NotFound();
            }
            if (_exampleService.DeleteExampleModel(id))
            {
                return NoContent();
            }
            return BadRequest();
        }
    }
}
