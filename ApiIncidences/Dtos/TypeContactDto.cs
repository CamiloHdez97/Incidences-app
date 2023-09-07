using System.ComponentModel.DataAnnotations;

namespace ApiIncidences.Dtos;

public class TypeContactDto
{
    public int Id { get; set; }
    public string Contact { get; set; }
    public string Descricion { get; set; }
}