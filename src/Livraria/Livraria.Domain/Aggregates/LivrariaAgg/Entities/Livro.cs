using Basis.Desafio.Core.Application.DTO.Attributes;
using Basis.Desafio.Core.Domain.Aggregates.CommonAgg.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Basis.Desafio.Livraria.Domain.Aggregates.LivrariaAgg.Entities;

public partial class Livro : Entity
{
    [Key, Column("Codl")]
    public override int Id { get; set; }

    [Required]
    [StringLength(40)]
    public string Titulo { get; set; }

    [Required]
    [StringLength(40)]
    public string Editora { get; set; }

    public int? Edicao { get; set; } = 1;

    [Required]
    public DateTime AnoPublicacao { get; set; }

    public List<Autor> Autores { get; set; } = new();

    public List<Assunto> Assuntos { get; set; } = new();
}
