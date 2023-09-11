using System.ComponentModel.DataAnnotations;

namespace Domain;

public class TypeDocument : BaseEntity
{
    
    public string NameDocumentType { get; set; }
    public ICollection<Person> Persons { get; set; }
    public string Abbreviation { get; set; }
}