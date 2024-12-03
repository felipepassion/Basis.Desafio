
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Basis.Desafio.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests;

using Core.Application.DTO.Aggregates.CommonAgg.Models;
using Core.Application.DTO.Attributes;

public partial class AutorDTO : EntityDTO
	{
	    public  string? Nome { get; set; }
	    public List<Basis.Desafio.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.LivroDTO>? Livros { get; set; } = new List<Basis.Desafio.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.LivroDTO>();
	}
