using Basis.Desafio.Core.Domain.Aggregates.CommonAgg.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Basis.Desafio.Livraria.Domain.Aggregates.LivrariaAgg.Entities
{
    public partial class Assunto : Entity
    {
        [Key, Column("CodAs")]
        public override int Id { get; set; }

        [StringLength(20)]
        public string Descricao { get; set; }

        public List<Livro> Livros { get; set; }
    }
}
