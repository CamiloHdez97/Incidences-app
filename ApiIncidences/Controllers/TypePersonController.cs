using AutoMapper;
using Domain;
using Domain.Interfaces;
using Persistence;
using Microsoft.AspNetCore.Mvc;


namespace ApiIncidences.Controllers;

 public class TypePersonController : BaseApiController
{

     private readonly IUnitOfWork unitofwork;
     private readonly IMapper mapper;

    public TypePersonController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitofwork = unitOfWork;
        this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<TypePerson>>> Get()
    {
        var Con = await  unitofwork.TypePersons.GetAllAsync();
        return Ok(Con);
    }

     [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
      public async Task<IActionResult> Get(int id)
    {
        var byidC = await  unitofwork.TypePersons.GetByIdAsync(id);
        return Ok(byidC);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TypePerson>> Post(TypePerson typePerson){
        this.unitofwork.TypePersons.Add(typePerson);
        await unitofwork.SaveAsync();
        if(typePerson == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post),new {id= typePerson.Id}, typePerson);
    }

     [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TypePerson>> Put(int id, [FromBody]TypePerson typePerson){
        if(typePerson == null)
            return NotFound();
        unitofwork.TypePersons.Update(typePerson);
        await unitofwork.SaveAsync();
        return typePerson;
    }
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
        var D = await unitofwork.TypePersons.GetByIdAsync(id);
        if(D == null){
            return NotFound();
        }
        unitofwork.TypePersons.Remove(D);
        await unitofwork.SaveAsync();
        return NoContent();
    }


   
}