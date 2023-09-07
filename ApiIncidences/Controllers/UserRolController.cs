using AutoMapper;
using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ApiIncidences.Dtos;

namespace API.Controllers;

[ApiVersion("1.0")]
[ApiVersion("1.1")]

 public class UserRolController : BaseApiController
{

     private readonly IUnitOfWork _unitofwork;
     private readonly IMapper _mapper;

    public UserRolController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this._unitofwork = unitOfWork;
        _mapper = mapper;
    }

   [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<RegionDto>>> Get()
    {
        var Con = await  _unitofwork.UserRols.GetAllAsync();
        return _mapper.Map<List<RegionDto>>(Con);
    }


    [HttpGet]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    // public async Task<ActionResult<IEnumerable<RegionxCityDto>>> Get11()
    //     var Con = await  _unitofwork.UserRols.GetAllAsync();
    //     return _mapper.Map<List<RegionxCityDto>>(Con);
    // }

     [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
      public async Task<IActionResult> Get(int id)
    {
        var byidC = await  _unitofwork.UserRols.GetByIdAsync(id);
        return Ok(byidC);
    }




    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<UserRol>> Post(RegionDto regionDto){
        var userRol = _mapper.Map<Country>(regionDto);
        this._unitofwork.Countries.Add(userRol);
        await _unitofwork.SaveAsync();
        if(userRol == null)
        {
            return BadRequest();
        }
        regionDto.Id = userRol.Id.ToString();
        return CreatedAtAction(nameof(Post),new {id= regionDto.Id}, regionDto);
    }
    
   
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<UserRol>> Put(int id, [FromBody]UserRol userRol){
        if(userRol == null)
            return NotFound();
        _unitofwork.UserRols.Update(userRol);
        await _unitofwork.SaveAsync();
        return userRol;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
        var D = await _unitofwork.UserRols.GetByIdAsync(id);
        if(D == null){
            return NotFound();
        }
        _unitofwork.UserRols.Remove(D);
        await _unitofwork.SaveAsync();
        return NoContent();
    }



}