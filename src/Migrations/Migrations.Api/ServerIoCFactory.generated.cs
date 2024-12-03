

using Basis.Desafio.Core.Infra.Data.Contexts;
using Basis.Desafio.Core.Infra.IoC;
using Microsoft.EntityFrameworkCore;
    
namespace Basis.Desafio.Migrations.Api {
    public static partial class IoCFactory {
       
		public static void InjectDependencies(this IServiceCollection services, IConfiguration configuration) {

            Basis.Desafio.Livraria.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
			
            Basis.Desafio.Core.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
		}

        public static void Migrate(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var contexts = (from asm in AppDomain.CurrentDomain.GetAssemblies()
                                from type in asm.GetTypes()
                                where type.IsClass && type.BaseType == typeof(BaseContext)
                                select type).ToArray();

                foreach (var item in contexts)
                {
                    (scope.ServiceProvider.GetRequiredService(item) as DbContext)
                        .Database.Migrate();
                }
                // Task.Run(async () => await TablesCsvSeeder.SeedDatabase(scope));
            }
        }

        public static void OnAppInitialized(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var logProvider = scope.ServiceProvider.GetRequiredService<Basis.Desafio.CrossCutting.Infra.Log.Providers.ILogProvider>();
                logProvider.Write(new Basis.Desafio.CrossCutting.Infra.Log.Entries.LogEntry("------> APP | Migrations.Api | STARTED <------", action: "OnAppInitialized"));
            }
        }
    }
}