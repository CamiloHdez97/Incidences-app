using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Rol : BaseEntity
{
 
    public string ?NameRol { get; set; }
    public ICollection<User> ?Users { get; set; } = new HashSet<User>();
    public ICollection<UserRol> ?UserRols { get; set; } = new HashSet<UserRol>();
    public string ?DescriptionRol { get; set; }
}