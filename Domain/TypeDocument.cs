using System.ComponentModel.DataAnnotations;

namespace Domain;

public class DocumentType : BaseEntity
{
    
    public string NameDocumentType { get; set; }
    public ICollection<Person> Persons { get; set; }
    public Contact Contact { get; set; }
    public string Abbreviation { get; set; }
}