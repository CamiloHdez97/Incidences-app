using AutoMapper;
using Domain;
using Domain.Interfaces;
using Persistence;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers;

 public class TypeDocumentController : BaseApiController
{

     private readonly IUnitOfWork unitofwork;
     private readonly IMapper mapper;

    public TypeDocumentController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitofwork = unitOfWork;
        this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<TypeDocument>>> Get()
    {
        var Con = await  unitofwork.TypeDocuments.GetAllAsync();
        return Ok(Con);
    }

     [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
      public async Task<IActionResult> Get(int id)
    {
        var byidC = await  unitofwork.TypeDocuments.GetByIdAsync(id);
        return Ok(byidC);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TypeDocument>> Post(TypeDocument typeDocument){
        this.unitofwork.TypeDocuments.Add(typeDocument);
        await unitofwork.SaveAsync();
        if(typeDocument == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post),new {id= typeDocument.Id}, typeDocument);
    }

     [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TypeDocument>> Put(int id, [FromBody]TypeDocument typeDocument){
        if(typeDocument == null)
            return NotFound();
        unitofwork.TypeDocuments.Update(typeDocument);
        await unitofwork.SaveAsync();
        return typeDocument;
    }
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
        var D = await unitofwork.TypeDocuments.GetByIdAsync(id);
        if(D == null){
            return NotFound();
        }
        unitofwork.TypeDocuments.Remove(D);
        await unitofwork.SaveAsync();
        return NoContent();
    }


   
}