namespace Domain;

public class Priority : BaseEntity
{
    public string Description {get;set;}
    public ICollection<Incidence> Incidences {get;set;}
    
}