using AutoMapper;
using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers;

 public class TeamController : BaseApiController
{

     private readonly IUnitOfWork unitofwork;
     private readonly IMapper mapper;

    public TeamController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitofwork = unitOfWork;
        this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Team>>> Get()
    {
        var Con = await  unitofwork.Teams.GetAllAsync();
        return Ok(Con);
    }

     [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
      public async Task<IActionResult> Get(int id)
    {
        var byidC = await  unitofwork.Teams.GetByIdAsync(id);
        return Ok(byidC);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Team>> Post(Team team){
        this.unitofwork.Teams.Add(team);
        await unitofwork.SaveAsync();
        if(team == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post),new {id= team.Id}, team);
    }

     [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Team>> Put(int id, [FromBody]Team team){
        if(team == null)
            return NotFound();
        unitofwork.Teams.Update(team);
        await unitofwork.SaveAsync();
        return team;
    }
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
        var D = await unitofwork.Teams.GetByIdAsync(id);
        if(D == null){
            return NotFound();
        }
        unitofwork.Teams.Remove(D);
        await unitofwork.SaveAsync();
        return NoContent();
    }


   
}
