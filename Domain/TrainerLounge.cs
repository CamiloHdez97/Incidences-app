using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Domain;

public class TrainerLounge {

    [Key]
    public string IdPerTrainerFk {get;set;}
    public Person Person {get;set;}
    public int IdLoungeFk {get;set;}
    public Lounge Lounge {get;set;}

}