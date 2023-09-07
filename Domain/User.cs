using System.ComponentModel.DataAnnotations;

namespace Domain;

public class User : BaseEntity
{
   
    public string NameUser { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public ICollection<Rol> Rols { get; set; } = new HashSet<Rol>();
    public ICollection<UserRol> UserRols { get; set; } 

}