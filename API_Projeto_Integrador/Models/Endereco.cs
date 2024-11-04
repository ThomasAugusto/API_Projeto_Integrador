using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Projeto_Integrador.Models;

public class Endereco
{
    public Endereco() => new Collection<Empreendimento>();

    public int EnderecoId { get; set; }

    [Required]
    [StringLength(20)]
    public string? Cidade { get; set; }

    [Required]
    [StringLength(2)]
    public string? Estado { get; set; }

    [Required]
    [StringLength(50)]
    public string? Logadrouro { get; set; }

    [JsonIgnore]
    public ICollection<Empreendimento>? Empreendimentos { get; set; }
}
