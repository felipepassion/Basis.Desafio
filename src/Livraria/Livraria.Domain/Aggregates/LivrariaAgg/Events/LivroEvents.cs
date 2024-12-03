
using Basis.Desafio.Core.Domain.Aggregates.CommonAgg.Events;
using Basis.Desafio.CrossCutting.Infra.Log.Contexts;

namespace Basis.Desafio.Livraria.Domain.Aggregates.LivrariaAgg.Events;
using Entities;

public partial class LivroCreatedEvent : BaseEvent
{
    public LivroCreatedEvent(ILogRequestContext ctx, Livro data) 
        : base(ctx, data) { }
}
public partial class LivroDeletedEvent : BaseEvent
{
    public LivroDeletedEvent(ILogRequestContext ctx, Livro data) 
        : base(ctx, data) { }
}
public partial class LivroDeletedRangeEvent : BaseEvent
{
    public LivroDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Livro> data) 
        : base(ctx, data) { }
}
public partial class LivroActivatedEvent : BaseEvent
{
    public LivroActivatedEvent(ILogRequestContext ctx, Livro data) 
        : base(ctx, data) { }
}
public partial class LivroUpdatedEvent : BaseEvent
{
    public LivroUpdatedEvent(ILogRequestContext ctx, Livro data) 
        : base(ctx, data) { }
}
public partial class LivroUpdatedRangeEvent : BaseEvent
{
    public LivroUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Livro> data) 
        : base(ctx, data) { }
}
public partial class LivroDeactivatedEvent : BaseEvent
{
    public LivroDeactivatedEvent(ILogRequestContext ctx, Livro data) 
        : base(ctx, data) { }
}
