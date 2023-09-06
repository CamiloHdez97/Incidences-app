namespace Domain;

public class Area : BaseEntity {

    public string NameArea { get; set; }
    public ICollection<Place> Places { get; set; }

}