using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Person : BaseEntity
{
    public int IdDocumentType { get; set; }
    public TypeDocument TypeDocument { get; set; }
    public string NamePerson {get;set;}
    public string LastNamePerson {get;set;}
    public int IdGender {get;set;}
    public Gender Gender {get;set;}
    public int IdCity {get;set;}
    public City City {get;set;}
    public int IdTypePer {get;set;}
    public TypePerson TypePerson {get;set;}
    public ICollection<Contact> Contacts { get; set; }
    public ICollection<Tuition> Tuitions {get;set;}
    public ICollection<TrainerClassroom> TrainerClassrooms {get;set;}

}