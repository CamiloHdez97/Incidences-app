namespace Domain;

public class TypePerson{

    public int IdTypePerson {get;set;}
    public string DescriptionTypePerson {get;set;}
    public ICollection<Person> Persons {get;set;}

}