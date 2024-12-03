
namespace Basis.Desafio.Livraria.Api {
    public static partial class IoCFactory {
       
		public static void InjectDependencies(this IServiceCollection services, IConfiguration configuration) {
            Basis.Desafio.Livraria.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
            Basis.Desafio.Core.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
		}

        public static void OnAppInitialized(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var logProvider = scope.ServiceProvider.GetRequiredService<Basis.Desafio.CrossCutting.Infra.Log.Providers.ILogProvider>();
                logProvider.Write(new Basis.Desafio.CrossCutting.Infra.Log.Entries.LogEntry("------> APP | Livraria.Api | STARTED <------", action: "OnAppInitialized"));
            }
        }
    }
}