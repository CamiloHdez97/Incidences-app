using Microsoft.Net.Http.Headers;

namespace Domain;

public class Gender {

    public int IdGender {get;set;}
    public string NameGender {get;set;}
    public ICollection<Person> Persons {get;set;}

}