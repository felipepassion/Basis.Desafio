﻿namespace Basis.Desafio.Livraria.Infra.Data.Aggregates.LivrariaAgg.Mappings;

using Domain.Aggregates.LivrariaAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public partial class AutorMapping : IEntityTypeConfiguration<Autor>
{
    public void Configure(EntityTypeBuilder<Autor> builder)
    {
    }
}
