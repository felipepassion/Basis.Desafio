using FluentValidation.Results;
using MediatR;
using Basis.Desafio.Core.Application.DTO.Http.Models.Responses;
using Basis.Desafio.Core.Domain.Aggregates.CommonAgg.Entities;
using Basis.Desafio.Core.Domain.Aggregates.CommonAgg.Notifications;
using Basis.Desafio.CrossCutting.Infra.Log.Contexts;
using System.Text.Json.Serialization;

namespace Basis.Desafio.Core.Domain.Aggregates.CommonAgg.Commands
{
    public abstract class BaseCommand : BaseNotification, IRequest<DomainResponse>, IBaseRequest
    {
        protected BaseCommand(ILogRequestContext ctx) 
            : base(ctx)
        {
        }

        [JsonIgnore]
        public ValidationResult? ValidationResult { get; set; }
        public IEntity? Entity { get; set; }

        public virtual bool IsValid()
        {
            return this.ValidationResult?.Errors.Any() != true;
        }
    }
}
