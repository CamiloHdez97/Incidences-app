namespace Domain;

public class Address : BaseEntity
{
    public string Neigborhood { get; set; }
    public string TypeWay  {get; set;}
    public string QuadrantPrefix {get; set;}
    public string NumberWay {get; set;}
    public string NumberVenereableWay {get; set;}
    public string NumberPlate {get; set;}
    public int IdPerson {get; set;}
    public Person Person {get; set;}
    public int IdCity {get; set;}
    public City City  {get; set;}

}