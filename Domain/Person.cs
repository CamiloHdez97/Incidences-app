using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Person : BaseEntity
{
    public string IdPerson {get;set;}
    public int IdDocumentTypeFk { get; set; }
    public DocumentType DocumentType { get; set; }
    public string NamePerson {get;set;}
    public string LastNamePerson {get;set;}
    public int IdGenderFk {get;set;}
    public Gender Gender {get;set;}
    public int IdCityFk {get;set;}
    public City City {get;set;}
    public int IdTypePerFk {get;set;}
    public TypePerson TypePerson {get;set;}
    public ICollection<Contact> Contacts { get; set; }
    public ICollection<Tuition> Tuitions {get;set;}
    public ICollection<TrainerClassroom> TrainerClassrooms {get;set;}

}