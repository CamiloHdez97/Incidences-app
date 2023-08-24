using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Gender :BaseEntity {
    public int IdGender {get;set;}
    public string NameGender {get;set;}
    public ICollection<Person> Persons {get;set;}

}