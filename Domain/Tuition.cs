using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Tuition : BaseEntity
{
    public int IdTuition {get;set;}
    public string IdPersonFk {get;set;}
    public Person Person {get;set;}
    public int IdTeam {get;set;}
    public Team Team {get;set;}
    public int IdClassroomFk {get;set;}
    public Classroom Classroom {get;set;}

}