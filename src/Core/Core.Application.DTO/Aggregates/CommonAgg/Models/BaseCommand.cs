using MediatR;
using Basis.Desafio.Core.Application.DTO.Http.Models.Responses;

namespace Basis.Desafio.Core.Application.DTO.Aggregates.CommonAgg.Models
{
    public class BaseCommand : IRequest<DomainResponse>
    {
        public string LoggedUserId { get; set; }
    }
}
