using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Projeto_Integrador.Models;

public class Tipo_Empreendimento
{
    public Tipo_Empreendimento() => new Collection<Empreendimento>();

    public int Tipo_EmpreendimentoId { get; set; }

    [Required]
    [StringLength(10)]
    public string? Tipo { get; set; }

    [JsonIgnore]
    public ICollection<Empreendimento>? Empreendimentos { get; set; }
}
