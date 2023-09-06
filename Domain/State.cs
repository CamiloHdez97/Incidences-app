using System.ComponentModel;

namespace Domain;
 public class State : BaseEntity {

    public string Description {get;set;}
    public ICollection<Incidence> Incidences {get;set;}

 }