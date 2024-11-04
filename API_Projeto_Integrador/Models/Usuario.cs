using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Projeto_Integrador.Models;

public class Usuario
{
    public Usuario() => new Collection<Usuario>();

    public int UsuarioId { get; set; }

    [StringLength(40)]  //Anotação para limitar tamanho máximo de caracteres
    [Required]  //Anotação para dizer que o campo é obrigatório
    public string? Nome { get; set; }

    [StringLength(50)]
    [Required]
    public string? Email { get; set; }

    [StringLength(16)]
    [Required]
    public string? Senha { get; set; }

    [JsonIgnore]
    public ICollection<Registro>? registros { get; set; }
}
