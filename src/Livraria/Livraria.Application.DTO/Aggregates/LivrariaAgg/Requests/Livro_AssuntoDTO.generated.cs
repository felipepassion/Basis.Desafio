
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Basis.Desafio.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests;

using Core.Application.DTO.Aggregates.CommonAgg.Models;
using Core.Application.DTO.Attributes;

public partial class Livro_AssuntoDTO 
	{
	    public  int Livro_Codl { get; set; }
	    public  int Assunto_CodAut { get; set; }
	    public Basis.Desafio.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.AssuntoDTO? Assunto { get; set; } 
	    public Basis.Desafio.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.LivroDTO? Livro { get; set; } 
	}
