using System.ComponentModel.DataAnnotations;

namespace ApiIncidences.Dtos;

public class TrainerClassroomDto
{
    public int Id { get; set; }
    public string CC_Trainer {get;set;}
    public int Salon {get;set;}

}