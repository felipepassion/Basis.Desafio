using Basis.Desafio.CrossCutting.Infra.Log.Contexts;
using Newtonsoft.Json;

namespace Basis.Desafio.Core.Domain.Aggregates.CommonAgg.Commands
{
    public abstract class BaseSearchableCommand<T> : BaseCommand
        where T : class
    {
        [JsonIgnore]
        public T Query { get; private set; }

        protected BaseSearchableCommand(ILogRequestContext ctx, T query)
            : base(ctx)
        {
            this.Query = query;
        }
    }
}
