using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Contact : BaseEntity
{
    public int IdPerson { get; set; }
    public Person Person { get; set; }
    public int IdTypeCon { get; set; }
    public TypeContact TypeContact { get; set; }
    public int IdCategoryContact { get; set; }
    public CategoryContact CategoryContact { get; set; }
    public string DescriptionContact { get; set; }
    
}