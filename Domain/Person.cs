using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Person : BaseEntity
{
    public string IdPerson {get;set;}
    public string NamePerson {get;set;}
    public int IdGenderFk {get;set;}
    public Gender Gender {get;set;}
    public int IdCityFk {get;set;}
    public City City {get;set;}
    public int IdTypePerFk {get;set;}

    public TypePerson TypePerson {get;set;}
    public ICollection<Tuition> Tuitions {get;set;}
    public ICollection<TrainerLounge> TrainerLounges {get;set;}

}