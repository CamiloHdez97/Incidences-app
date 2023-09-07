using System.ComponentModel.DataAnnotations;

namespace ApiIncidences.Dtos;

public class TypeDocumentDto
{
    public int Id { get; set; }
    public string TipoDeDocumento { get; set; }
    public string Siglas { get; set; }
}