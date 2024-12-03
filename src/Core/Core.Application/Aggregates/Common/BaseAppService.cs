using Basis.Desafio.Core.Domain.Aggregates.CommonAgg.Commands;
using Basis.Desafio.CrossCutting.Infra.Log.Contexts;
using MediatR;

namespace Basis.Desafio.Core.Application.Aggregates.Common
{
    public interface IBaseAppService : IDisposable 
    {
    }

    public class BaseAppService(ILogRequestContext logRequestContext, IMediator mediator)
    {
        protected readonly IMediator _mediator = mediator;
        protected readonly ILogRequestContext _logRequestContext = logRequestContext;

        protected void SendCommand<T>(T command)
            where T : BaseCommand
        {
            _mediator.Send(command);
        }
    }
}
