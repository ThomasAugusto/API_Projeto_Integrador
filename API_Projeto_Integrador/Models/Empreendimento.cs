using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace API_Projeto_Integrador.Models;

public class Empreendimento
{
    public Empreendimento() => new Collection<Lojista>();

    public int EmpreendimentoId { get; set; }

    [Required]
    [StringLength(40)]
    public string? Nome { get; set; }

    public int Tipo_EmpreendimentoID { get; set; }
    public Tipo_Empreendimento? Tipo_Empreendimento { get; set; }

    public int EnderecoID { get; set; }
    
    [JsonIgnore]
    public Endereco? Endereco { get; set; }

    [JsonIgnore]
    public ICollection<Lojista>? Lojistas { get; set; }
}
