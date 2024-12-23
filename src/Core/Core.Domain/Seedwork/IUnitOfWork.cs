﻿using Basis.Desafio.Core.Application.DTO.Http.Models.Responses;
using Basis.Desafio.Core.Domain.Aggregates.CommonAgg.Entities;

namespace Basis.Desafio.Core.Domain.Seedwork
{
    public interface IUnitOfWork
    {
        Task<bool> ExecuteNpCommand(string rawText);
        Task<bool> Commit(object? data = null);
        void ResolveAttaches<T>(T entity) where T : Entity;
        void ResolveAttachesOnUpdate<T, K>(T entity, K entityDTO) where T : Entity, new() where K : Entity, new();
        Task<DomainResponse> CommitAsync(object? data = null);
        bool IsEmpty<T>(T entity) where T : class;
    }
}
