using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Country : BaseEntity
{
    public string NameCountry {get;set;}
    public ICollection<Region> Regions {get;set;}

}