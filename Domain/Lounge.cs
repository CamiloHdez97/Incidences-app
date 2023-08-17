using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Lounge : BaseEntity
{

    public int IdLounge {get;set;}
    public string NameLounge {get;set;}
    public int Capacity {get;set;}
    public ICollection<Tuition> Tuitions {get;set;}
    public ICollection<TrainerLounge> TrainerLounges {get;set;}

}