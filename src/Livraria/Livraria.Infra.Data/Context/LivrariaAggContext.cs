﻿
using Basis.Desafio.Livraria.Domain.Aggregates.LivrariaAgg.Entities; 
using Basis.Desafio.Livraria.Infra.Data.Aggregates.LivrariaAgg.Mappings; 
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Basis.Desafio.Core.Infra.Data.Contexts;

namespace Basis.Desafio.Livraria.Infra.Data.Context
{
	public partial class LivrariaAggContext : BaseContext
	{
		public DbSet<Livro_Autor> Livro_Autor { get; set; }
		public DbSet<Livro> Livro { get; set; }
		public DbSet<Assunto> Assunto { get; set; }
		public DbSet<Livro_Assunto> Livro_Assunto { get; set; }
		public DbSet<Autor> Autor { get; set; }

		public LivrariaAggContext (MediatR.IMediator mediator, DbContextOptions<LivrariaAggContext> options, IServiceProvider scope)
            : base(mediator, options, scope)
        {
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new Livro_AutorMapping());
			builder.ApplyConfiguration(new LivroMapping());
			builder.ApplyConfiguration(new AssuntoMapping());
			builder.ApplyConfiguration(new Livro_AssuntoMapping());
			builder.ApplyConfiguration(new AutorMapping());
		
			ApplyAdditionalMappings(builder);
			base.OnModelCreating(builder);
		}
		partial void ApplyAdditionalMappings(ModelBuilder modelBuilder);
	}
}
