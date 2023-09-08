using AutoMapper;
using Domain.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace ApiIncidences.Controllers;

 public class GenderController : BaseApiController
{

     private readonly IUnitOfWork unitofwork;
     private readonly IMapper mapper;

    public GenderController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitofwork = unitOfWork;
        this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Gender>>> Get()
    {
        var Con = await  unitofwork.Genders.GetAllAsync();
        return Ok(Con);
    }

     [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
      public async Task<IActionResult> Get(int id)
    {
        var byidC = await  unitofwork.Genders.GetByIdAsync(id);
        return Ok(byidC);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Gender>> Post(Gender gender){
        this.unitofwork.Genders.Add(gender);
        await unitofwork.SaveAsync();
        if(gender == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post),new {id= gender.Id}, gender);
    }

     [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Gender>> Put(int id, [FromBody]Gender gender){
        if(gender == null)
            return NotFound();
        unitofwork.Genders.Update(gender);
        await unitofwork.SaveAsync();
        return gender;
    }
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
        var G = await unitofwork.Genders.GetByIdAsync(id);
        if(G == null){
            return NotFound();
        }
        unitofwork.Genders.Remove(G);
        await unitofwork.SaveAsync();
        return NoContent();
    }


   
}