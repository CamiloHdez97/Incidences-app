using AutoMapper;
using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers;

 public class TuitionController : BaseApiController
{

     private readonly IUnitOfWork unitofwork;
     private readonly IMapper mapper;

    public TuitionController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitofwork = unitOfWork;
        this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Tuition>>> Get()
    {
        var Con = await  unitofwork.Tuitions.GetAllAsync();
        return Ok(Con);
    }

     [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
      public async Task<IActionResult> Get(int id)
    {
        var byidC = await  unitofwork.Tuitions.GetByIdAsync(id);
        return Ok(byidC);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Tuition>> Post(Tuition tuition){
        this.unitofwork.Tuitions.Add(tuition);
        await unitofwork.SaveAsync();
        if(tuition == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post),new {id= tuition.Id}, tuition);
    }

     [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Tuition>> Put(int id, [FromBody]Tuition tuition){
        if(tuition == null)
            return NotFound();
        unitofwork.Tuitions.Update(tuition);
        await unitofwork.SaveAsync();
        return tuition;
    }
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
        var D = await unitofwork.Tuitions.GetByIdAsync(id);
        if(D == null){
            return NotFound();
        }
        unitofwork.Tuitions.Remove(D);
        await unitofwork.SaveAsync();
        return NoContent();
    }


   
}
