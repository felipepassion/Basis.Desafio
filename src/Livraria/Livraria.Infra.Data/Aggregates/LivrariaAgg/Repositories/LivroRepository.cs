namespace Basis.Desafio.Livraria.Infra.Data.Aggregates.LivrariaAgg.Repositories;

using Core.Infra.Data.Repositories;
using Context;
using Domain.Aggregates.LivrariaAgg.Entities;
using Basis.Desafio.Livraria.Domain.Aggregates.LivrariaAgg.Repositories;

	public partial class LivroRepository : Repository<Livro>, ILivroRepository { public LivroRepository(LivrariaAggContext ctx) : base(ctx) { } }

