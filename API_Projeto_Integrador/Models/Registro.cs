using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Projeto_Integrador.Models;

public class Registro
{
    public int RegistroId { get; set; }

    public int EmpreendimentoId { get; set; }

    [JsonIgnore]
    public Empreendimento? Empreendimento { get; set; }

    public int LojistaId { get; set; }

    [JsonIgnore]
    public Lojista? Lojista { get; set; }

    public int UsuarioId { get; set; }

    [JsonIgnore]
    public Usuario? Usuario { get; set; }

    public int Tipo_RegistroId { get; set; }

    [JsonIgnore]
    public Tipo_Registro? Tipo_Registro { get; set; }

    public DateTime DataRegistro {get; set; }

    [Required]
    [Column(TypeName = "decimal(10, 3)")]
    public decimal Valor_Registro { get; set; }
}
