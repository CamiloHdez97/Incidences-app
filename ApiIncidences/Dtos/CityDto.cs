using System.ComponentModel.DataAnnotations;

namespace ApiIncidences.Dtos;

public class CityDto
{
    public int Id { get; set; }
    public string IdCity {get;set;}
    public string NameCity {get;set;}
    public string IdRegion {get;set;}

}