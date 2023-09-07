using AutoMapper;
using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers;

 public class TypeContactController : BaseApiController
{

     private readonly IUnitOfWork unitofwork;
     private readonly IMapper mapper;

    public TypeContactController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitofwork = unitOfWork;
        this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<TypeContact>>> Get()
    {
        var Con = await  unitofwork.TypeContacts.GetAllAsync();
        return Ok(Con);
    }

     [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
      public async Task<IActionResult> Get(int id)
    {
        var byidC = await  unitofwork.TypeContacts.GetByIdAsync(id);
        return Ok(byidC);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TypeContact>> Post(TypeContact typeContact){
        this.unitofwork.TypeContacts.Add(typeContact);
        await unitofwork.SaveAsync();
        if(typeContact == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post),new {id= typeContact.Id}, typeContact);
    }

     [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TypeContact>> Put(int id, [FromBody]TypeContact typeContact){
        if(typeContact == null)
            return NotFound();
        unitofwork.TypeContacts.Update(typeContact);
        await unitofwork.SaveAsync();
        return typeContact;
    }
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
        var D = await unitofwork.TypeContacts.GetByIdAsync(id);
        if(D == null){
            return NotFound();
        }
        unitofwork.TypeContacts.Remove(D);
        await unitofwork.SaveAsync();
        return NoContent();
    }


   
}