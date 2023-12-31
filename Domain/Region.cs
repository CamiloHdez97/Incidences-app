using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Region : BaseEntity
{
    public string NameRegion {get;set;}
    public int IdCountry {get;set;}
    public Country Country {get;set;}
    public ICollection<City> Cities {get;set;}

}