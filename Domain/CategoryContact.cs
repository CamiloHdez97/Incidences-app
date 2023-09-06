using System.ComponentModel.DataAnnotations;

namespace Domain;

public class CategoryContact : BaseEntity
{
 
    public Contact Contact { get; set; }
    public int Id_Category { get; set; }
    public string Name_CategoryContact { get; set; }
     public ICollection<Contact> Contacts { get; set; }

}