using AutoMapper;
using Newtonsoft.Json;
using Basis.Desafio.CrossCutting.Infra.Log.Entries;
using Basis.Desafio.CrossCutting.Infra.Log.SeedWork;
using Basis.Desafio.Core.Domain.Aggregates.CommonAgg.Events;
using Basis.Desafio.Core.Domain.Aggregates.CommonAgg.Notifications;

namespace Basis.Desafio.Core.Domain.Aggregates.CommonAgg.Profiles
{
    public partial class LoggerProfile : Profile
    {
        public LoggerProfile()
        {
            CreateMap<BaseNotification, LogEntry>()
                .ForMember(x => x.Title, opt => opt.MapFrom(notification => $"[{notification.Context.ShortLogId}] {notification.Title}"))
                .ForMember(x => x.Action, opt => opt.MapFrom(notification => notification.GetType().Name))
                .ForMember(x => x.Level, opt => opt.MapFrom(notification => notification.LogType))
                .ForMember(x => x.Properties, opt => opt.Ignore())
                .ForMember(x => x.LogId, opt => opt.MapFrom(notification => notification.Context.LogId != Guid.Empty ? notification.Context.LogId : LoggerFactory.ExecutionKey))
                .ForMember(x => x.Content, opt => opt.MapFrom(notification =>
                    JsonConvert.DeserializeObject<object>(JsonConvert.SerializeObject(notification, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects }))
                ))
            .PreserveReferences()
            .IncludeAllDerived();

            CreateMap<ErrorEvent, LogEntry>().ForMember(x=>x.Content, opt => opt.Ignore());
        }
    }
}
 