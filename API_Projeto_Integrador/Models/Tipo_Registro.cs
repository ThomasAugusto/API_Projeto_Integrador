using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Projeto_Integrador.Models;

public class Tipo_Registro
{
    public Tipo_Registro() => new Collection<Registro>();
    public int Tipo_RegistroId { get; set; }

    [Required]
    [StringLength(10)]
    public string? Tipo { get; set; }

    [JsonIgnore]
    public virtual ICollection<Registro>? Registros { get; set; }
}
