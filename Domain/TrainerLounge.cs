using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Domain;

public class TrainerLounge : BaseEntity
{
    public string IdPerTrainerFk {get;set;}
    public Person Person {get;set;}
    public int IdLoungeFk {get;set;}
    public Lounge Lounge {get;set;}

}