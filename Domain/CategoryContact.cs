using System.ComponentModel.DataAnnotations;

namespace Domain;

public class CategoryContact : BaseEntity
{
 
    public Contact Contact { get; set; }
    public int IdCategory { get; set; }
    public string NameCategoryContact { get; set; }
     public ICollection<Contact> Contacts { get; set; }

}