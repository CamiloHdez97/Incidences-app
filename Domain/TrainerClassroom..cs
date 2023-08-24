using System.ComponentModel.DataAnnotations;

namespace Domain;

public class TrainerClassroom : BaseEntity
{
    public string IdPerTrainerFk {get;set;}
    public Person Person {get;set;}
    public int IdClassroomFk {get;set;}
    public Classroom Classroom {get;set;}

}