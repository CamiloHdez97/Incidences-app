using System.ComponentModel.DataAnnotations;

namespace ApiIncidences.Dtos;

public class RegionDto
{
    public int Id { get; set; }
    public string NameRegion {get;set;}
    public string IdCountry {get;set;}

}