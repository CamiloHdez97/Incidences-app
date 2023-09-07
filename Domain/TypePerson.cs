using System.ComponentModel.DataAnnotations;

namespace Domain;

public class TypePerson : BaseEntity
{
    public string DescriptionTypePerson {get;set;}
    public ICollection<Person> Persons {get;set;}

}