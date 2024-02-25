using System.ComponentModel.DataAnnotations;

namespace ApiFilmes.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }
    //data notations
    [Required(ErrorMessage ="O Titulo do filme é obrigatório")]
    [MaxLength(80, ErrorMessage = "Tamanho máximo de caracteres inválidos")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O Titulo do genero é obrigatório")]
    [MaxLength(50,ErrorMessage ="Tamanho máximo de caracteres inválidos")]
    public string Genero { get; set; }

    [Required]
    [Range(70, 600, ErrorMessage ="O filme deve ter entre 70 e 600 segundos")]
    public int Duracao { get; set;}
    
}
