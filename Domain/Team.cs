namespace Domain;

public class Team : BaseEntity {

    public string NameTeam {get;set;}

    public ICollection<Tuition> Tuitions {get;set;}

}