using System.ComponentModel.DataAnnotations;

namespace ApiIncidences.Dtos;

public class RolDto
{
    public int Id { get; set; }
    public string Rol { get; set;}
    public string Descripcion { get; set; }
}