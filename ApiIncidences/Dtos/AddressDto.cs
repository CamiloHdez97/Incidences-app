namespace ApiIncidences.Dtos;

public class AddressDto
{
    public int Id { get; set; }
    public string Barrio { get; set; }
    public string TipoVia  {get; set;}
    public string PerfixCuadrante {get; set;}
    public string NumVia {get; set;}
    public string Carrera {get; set;}
    public string NumPlaca {get; set;}
    public int CC_Persona {get; set;}
    public int Ciudad {get; set;}

}