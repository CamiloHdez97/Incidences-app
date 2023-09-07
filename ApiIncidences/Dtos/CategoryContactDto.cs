using System.ComponentModel.DataAnnotations;

namespace ApiIncidences.Dtos;

public class CategoryContactDto
{
 
    public int IdCategoryContact { get; set; }
    public int IdDeCategoria { get; set; }
    public string Descripcion { get; set; }

}