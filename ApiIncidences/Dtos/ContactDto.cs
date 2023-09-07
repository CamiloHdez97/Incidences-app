using System.ComponentModel.DataAnnotations;

namespace ApiIncidences.Dtos;
public class ContactDto
{
    public int Id { get; set; }
    public int CC_Persona { get; set; }
    public int IdDeTypoContacto { get; set; }
    public int IdDeCategoryContact { get; set; }
    public string Description { get; set; }
}