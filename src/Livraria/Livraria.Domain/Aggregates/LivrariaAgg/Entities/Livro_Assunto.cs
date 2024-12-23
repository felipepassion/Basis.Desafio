using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Basis.Desafio.Livraria.Domain.Aggregates.LivrariaAgg.Entities;

public partial class Livro_Assunto
{
    [Required]
    [ForeignKey(nameof(Livro))]
    public int Livro_Codl { get; set; }

    [Required]
    [ForeignKey(nameof(Assunto))]
    public int Assunto_CodAut { get; set; }

    public Assunto Assunto { get; set; }

    public Livro Livro { get; set; }
}