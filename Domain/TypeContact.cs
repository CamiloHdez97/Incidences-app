using System.ComponentModel.DataAnnotations;

namespace Domain;

public class TypeContact : BaseEntity
{
    public string NameContact { get; set; }
     public ICollection<Contact> Contacts  { get; set; }
    public string Description { get; set; }
}