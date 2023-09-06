using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Place : BaseEntity
{

    public int IdPlace {get;set;}
    public string NamePlace {get;set;}
    public int Capacity {get;set;}
    public int IdArea {get; set;}
    public Area Area {get;set;}
    public ICollection<Tuition> Tuitions {get;set;}
    public ICollection<TrainerClassroom> TrainerClassrooms {get;set;}
    public ICollection<Incidence> Incidences {get;set;}

}