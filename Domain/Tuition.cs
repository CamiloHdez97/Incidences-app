using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Tuition : BaseEntity
{
    public int IdTuition {get;set;}
    public string IdPersonFk {get;set;}
    public Person Person {get;set;}
<<<<<<< HEAD
    public int IdTeam {get;set;}
    public Team Team {get;set;}
    public int IdLoungeFk {get;set;}
    public Lounge Lounge {get;set;}
=======
    public int IdClassroomFk {get;set;}
    public Classroom Classroom {get;set;}
>>>>>>> 24678b7dbfc67b396012ea408b09b9841be5380c



}