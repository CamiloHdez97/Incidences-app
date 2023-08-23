using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Classroom : BaseEntity
{

    public int IdClassroom {get;set;}
    public string NameClassroom {get;set;}
    public int Capacity {get;set;}
    public ICollection<Tuition> Tuitions {get;set;}
    public ICollection<TrainerClassroom> TrainerClassrooms {get;set;}

}