namespace Domain;

public class Country
{
    public string IdCountry {get;set;}
    public string NameCountry {get;set;}
    public ICollection<Region> Regions {get;set;}

}