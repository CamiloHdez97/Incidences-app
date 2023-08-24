namespace Domain;

public class Team : BaseEntity {

    public int IdTeam {get;set;}
    public string NameTeam {get;set;}

    public ICollection<Tuition> Tuitions {get;set;}

}