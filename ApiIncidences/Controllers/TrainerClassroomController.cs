using AutoMapper;
using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace ApiIncidences.Controllers;

 public class TrainerClassroomController : BaseApiController
{

     private readonly IUnitOfWork unitofwork;
     private readonly IMapper mapper;

    public TrainerClassroomController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitofwork = unitOfWork;
        this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<TrainerClassroom>>> Get()
    {
        var Con = await  unitofwork.TrainerClassrooms.GetAllAsync();
        return Ok(Con);
    }

     [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
      public async Task<IActionResult> Get(int id)
    {
        var byidC = await  unitofwork.TrainerClassrooms.GetByIdAsync(id);
        return Ok(byidC);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TrainerClassroom>> Post(TrainerClassroom trainerClassroom){
        this.unitofwork.TrainerClassrooms.Add(trainerClassroom);
        await unitofwork.SaveAsync();
        if(trainerClassroom == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post),new {id= trainerClassroom.Id}, trainerClassroom);
    }

     [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TrainerClassroom>> Put(int id, [FromBody]TrainerClassroom trainerClassroom){
        if(trainerClassroom == null)
            return NotFound();
        unitofwork.TrainerClassrooms.Update(trainerClassroom);
        await unitofwork.SaveAsync();
        return trainerClassroom;
    }
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
        var D = await unitofwork.TrainerClassrooms.GetByIdAsync(id);
        if(D == null){
            return NotFound();
        }
        unitofwork.TrainerClassrooms.Remove(D);
        await unitofwork.SaveAsync();
        return NoContent();
    }


   
}