using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Incidence : BaseEntity
{
    public int IdPerson { get; set; }
    public Person Person { get; set; }
    public int IdPlace { get; set; }
    public Place Place { get; set; }
    public int IdState { get; set; }
    public State State { get; set; }
    public int IdPriority { get; set;}
    public Priority Priority {get; set;}
    public DateTime Date { get; set; }
    public int IdCategoryIncidence { get; set; }
    public CategoryIncidence CategoryIncidence { get; set; }
    public string Description {get; set;}
    

}
