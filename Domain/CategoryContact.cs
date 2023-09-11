using System.ComponentModel.DataAnnotations;

namespace Domain;

public class CategoryContact : BaseEntity
{
    public string Description { get; set; }
    public ICollection<Contact> Contacts { get; set; }

}