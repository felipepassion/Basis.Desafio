namespace Basis.Desafio.Livraria.Infra.Data.Aggregates.LivrariaAgg.Repositories;

using Core.Infra.Data.Repositories;
using Context;
using Domain.Aggregates.LivrariaAgg.Entities;
using Basis.Desafio.Livraria.Domain.Aggregates.LivrariaAgg.Repositories;

	public partial class AssuntoRepository : Repository<Assunto>, IAssuntoRepository { public AssuntoRepository(LivrariaAggContext ctx) : base(ctx) { } }

