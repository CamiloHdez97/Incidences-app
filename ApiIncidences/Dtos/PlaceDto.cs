using System.ComponentModel.DataAnnotations;
namespace ApiIncidences.Dtos;

public class PlaceDto
{
    public int Id { get; set; }
    public string Lugar {get;set;}
    public int Capacidad {get;set;}
    public int Area {get; set;}

}