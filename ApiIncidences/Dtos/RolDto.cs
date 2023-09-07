using System.ComponentModel.DataAnnotations;

namespace ApiIncidences.Dtos;

public class RolDto
{
    public int IdRol { get; set; }
    public string Rol { get; set;}
    public string Descripcion { get; set; }
}