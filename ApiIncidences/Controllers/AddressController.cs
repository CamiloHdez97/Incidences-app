using AutoMapper;
using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace ApiIncidences.Controllers;

 public class AddressController : BaseApiController
{
     private readonly IUnitOfWork unitofwork;
     private readonly IMapper mapper;

    public AddressController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitofwork = unitOfWork;
        this.mapper = mapper;
    }



    //Retorna Registros de la Tabla
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Address>>> Get()
    {
        var Con = await  unitofwork.Addresses.GetAllAsync();
        return Ok(Con);
    }




    //Retorna Registro de la Tabla, apartir del ID
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
      public async Task<IActionResult> Get(int id)
    {
        var byidC = await  unitofwork.Addresses.GetByIdAsync(id);
        return Ok(byidC);
    }


    //Recibe un Post
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Address>> Post(Address address){
        this.unitofwork.Addresses.Add(address);                                 //Agrega Información al Contexto
        await unitofwork.SaveAsync();                                           //Envia la Info del contexto a la DB
        if(address == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post),new {id= address.Id}, address);     //Retorna el id del Valor generado
    }


    //Recibe un Put
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Address>> Put(int id, [FromBody]Address address){ //Contiene la info a actualizar
        if(address == null)
            return NotFound();
        unitofwork.Addresses.Update(address);                                        //Actua en el context
        await unitofwork.SaveAsync();                                                //Guarda la actualización
        return address;                                                              //Efectua el update en la DB
    }



    //Recibe un Delete
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
        var Dir = await unitofwork.Addresses.GetByIdAsync(id); //Busca y almacena el Registro a eliminar
        if(Dir == null){                                       //Valida si se encontro el registro
            return NotFound();                                 //Retorna NotFound
        }
        unitofwork.Addresses.Remove(Dir);
        await unitofwork.SaveAsync();
        return NoContent();                                    //No retorna nada
    }


   
}