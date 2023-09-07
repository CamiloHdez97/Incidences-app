namespace Domain;

public class CategoryIncidence : BaseEntity 
{
    public string Description { get; set; }
    public ICollection<Incidence> Incidences { get; set; }
}