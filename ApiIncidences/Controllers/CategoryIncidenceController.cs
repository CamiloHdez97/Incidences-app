using AutoMapper;
using Domain;
using Domain.Interfaces;
using Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiIncidences.Controllers;

 public class CategoryIncidenceController : BaseApiController
{

     private readonly IUnitOfWork unitofwork;
     private readonly IMapper mapper;

    public CategoryIncidenceController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitofwork = unitOfWork;
        this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<CategoryIncidence>>> Get()
    {
        var Con = await  unitofwork.CategoryIncidences.GetAllAsync();
        return Ok(Con);
    }

     [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
      public async Task<IActionResult> Get(int id)
    {
        var byidC = await  unitofwork.CategoryIncidences.GetByIdAsync(id);
        return Ok(byidC);
    }

 [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<CategoryIncidence>> Post(CategoryIncidence CategoryIncidence){
        this.unitofwork.CategoryIncidences.Add(CategoryIncidence);
        await unitofwork.SaveAsync();
        if(CategoryIncidence == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post),new {id= CategoryIncidence.Id}, CategoryIncidence);
    }

     [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<CategoryIncidence>> Put(int id, [FromBody]CategoryIncidence CategoryIncidence){
        if(CategoryIncidence == null)
            return NotFound();
        unitofwork.CategoryIncidences.Update(CategoryIncidence);
        await unitofwork.SaveAsync();
        return CategoryIncidence;
    }
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
        var TC = await unitofwork.CategoryIncidences.GetByIdAsync(id);
        if(TC == null){
            return NotFound();
        }
        unitofwork.CategoryIncidences.Remove(TC);
        await unitofwork.SaveAsync();
        return NoContent();
    }


   
}