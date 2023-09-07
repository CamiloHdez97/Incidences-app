using System.ComponentModel.DataAnnotations;
namespace ApiIncidences.Dtos;

public class TuitionDto
{
    public int Matricula {get;set;}
    public string CC_Camper {get;set;}
    public int IdTeam {get;set;}
    public int Salon {get;set;}


}