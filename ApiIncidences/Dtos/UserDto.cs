using System.ComponentModel.DataAnnotations;

namespace ApiIncidences.Dtos;

public class UserDto
{
   
    public int Id { get; set; }
    public string NameUser { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

}