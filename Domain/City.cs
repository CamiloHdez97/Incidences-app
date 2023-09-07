using System.ComponentModel.DataAnnotations;

namespace Domain;

public class City : BaseEntity {

    public string IdCity {get;set;}
    public string NameCity {get;set;}
    public string IdReg {get;set;}
    public Region Region {get;set;}
    public ICollection<Person> Persons {get;set;}

}