
using Basis.Desafio.Core.Domain.Aggregates.CommonAgg.Events;
using Basis.Desafio.CrossCutting.Infra.Log.Contexts;

namespace Basis.Desafio.Livraria.Domain.Aggregates.LivrariaAgg.Events;
using Entities;

public partial class AutorCreatedEvent : BaseEvent
{
    public AutorCreatedEvent(ILogRequestContext ctx, Autor data) 
        : base(ctx, data) { }
}
public partial class AutorDeletedEvent : BaseEvent
{
    public AutorDeletedEvent(ILogRequestContext ctx, Autor data) 
        : base(ctx, data) { }
}
public partial class AutorDeletedRangeEvent : BaseEvent
{
    public AutorDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Autor> data) 
        : base(ctx, data) { }
}
public partial class AutorActivatedEvent : BaseEvent
{
    public AutorActivatedEvent(ILogRequestContext ctx, Autor data) 
        : base(ctx, data) { }
}
public partial class AutorUpdatedEvent : BaseEvent
{
    public AutorUpdatedEvent(ILogRequestContext ctx, Autor data) 
        : base(ctx, data) { }
}
public partial class AutorUpdatedRangeEvent : BaseEvent
{
    public AutorUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Autor> data) 
        : base(ctx, data) { }
}
public partial class AutorDeactivatedEvent : BaseEvent
{
    public AutorDeactivatedEvent(ILogRequestContext ctx, Autor data) 
        : base(ctx, data) { }
}
