using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Contact : BaseEntity
{
    public int IdPerson { get; set; }
    public Person Person { get; set; }

    public int Id_TypeCon { get; set; }
    public ContactType TypeOfContact { get; set; }

    public int Id_CategoryContact { get; set; }
    public CategoryContact CategoryContact { get; set; }

    public string Description_Contact { get; set; }
}