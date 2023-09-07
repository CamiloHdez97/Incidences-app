using System.ComponentModel.DataAnnotations;

namespace ApiIncidences.Dtos;

public class IncidenceDto
{
    public int Id { get; set; }
    public int CC_Persona { get; set; }
    public int IdDeLugar { get; set; }
    public int IdDeEstado { get; set; }
    public int Priority { get; set;}
    public DateTime Fecha { get; set; }
    public string Descripcion {get; set;}
    

}
