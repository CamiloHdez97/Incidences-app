using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Tuition : BaseEntity
{
    public int IdPerson {get;set;}
    public Person Person {get;set;}
    public int IdTeam {get;set;}
    public Team Team {get;set;}
    public int IdClassroom {get;set;}
    public Place Place {get;set;}

}