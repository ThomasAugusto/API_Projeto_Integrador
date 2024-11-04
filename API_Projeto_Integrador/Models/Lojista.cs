using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Projeto_Integrador.Models;

public class Lojista
{
    public int LojistaId { get; set; }

    [Required]
    [StringLength(40)]
    public string? Nome { get; set; }

    public int EmpreendimentoId { get; set; }

    [JsonIgnore]
    public Empreendimento? Empreendimento { get; set; }
}
