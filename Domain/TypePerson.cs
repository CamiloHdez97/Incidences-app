using System.ComponentModel.DataAnnotations;

namespace Domain;

public class TypePerson{

    [Key]
    public int IdTypePerson {get;set;}
    public string DescriptionTypePerson {get;set;}
    public ICollection<Person> Persons {get;set;}

}