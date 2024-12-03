using Basis.Desafio.Core.Domain.Aggregates.CommonAgg.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Basis.Desafio.Livraria.Domain.Aggregates.LivrariaAgg.Entities
{
    public partial class Autor : Entity
    {
        [Key, Column("CodAu")]
        public override int Id { get; set; }

        [StringLength(40)]
        public string Nome { get; set; }

        public List<Livro> Livros { get; set; }
    }
}
