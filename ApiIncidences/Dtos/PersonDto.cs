using System.ComponentModel.DataAnnotations;

namespace ApiIncidences.Dtos;

public class PersonDto
{
    public int Id { get; set; }
    public int IdDocumentType { get; set; }
    public string NamePerson {get;set;}
    public string LastNamePerson {get;set;}
    public int IdGender {get;set;}
    public int IdCity {get;set;}
    public int IdTypePer {get;set;}

}