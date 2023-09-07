using AutoMapper;
using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

 public class PriorityController : BaseApiController
{

     private readonly IUnitOfWork unitofwork;
     private readonly IMapper mapper;

    public PriorityController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitofwork = unitOfWork;
        this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Priority>>> Get()
    {
        var Con = await  unitofwork.Priorities.GetAllAsync();
        return Ok(Con);
    }

     [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
      public async Task<IActionResult> Get(int id)
    {
        var byidC = await  unitofwork.Priorities.GetByIdAsync(id);
        return Ok(byidC);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Priority>> Post(Priority priority){
        this.unitofwork.Priorities.Add(priority);
        await unitofwork.SaveAsync();
        if(priority == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post),new {id= priority.Id}, priority);
    }

     [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Priority>> Put(int id, [FromBody]Priority priority){
        if(priority == null)
            return NotFound();
        unitofwork.Priorities.Update(priority);
        await unitofwork.SaveAsync();
        return priority;
    }
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
        var D = await unitofwork.Priorities.GetByIdAsync(id);
        if(D == null){
            return NotFound();
        }
        unitofwork.Priorities.Remove(D);
        await unitofwork.SaveAsync();
        return NoContent();
    }


   
}