namespace Domain;

public class Tuition
{
    public int IdTuition {get;set;}
    public string IdPersonFk {get;set;}
    public Person Person {get;set;}
    public int IdLoungeFk {get;set;}
    public Lounge Lounge {get;set;}

}