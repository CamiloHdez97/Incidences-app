using System.ComponentModel.DataAnnotations;

namespace Domain;

public class TrainerClassroom : BaseEntity
{
    public int IdPerTrainer {get;set;}
    public Person Person {get;set;}
    public int IdClassroom {get;set;}
    public Place Place {get;set;}

}