using System.ComponentModel.DataAnnotations;

namespace Domain;

public class City : BaseEntity {
    public string NameCity {get;set;}
    public int IdRegion {get;set;}
    public Region Region {get;set;}
    public ICollection<Person> Persons {get;set;}
    public ICollection<Address> Addresses {get;set;}

}