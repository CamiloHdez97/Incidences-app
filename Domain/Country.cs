using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Country
{
    [Key]
    public string IdCountry {get;set;}
    public string NameCountry {get;set;}
    public ICollection<Region> Regions {get;set;}

}