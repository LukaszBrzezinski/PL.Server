using Autofac;
using PL.Authorization.Infrastructure.Configuration.Database;
using PL.Authorization.Infrastructure.Configuration.Processing;

namespace PL.Authorization.Infrastructure.Configuration.Authorization
{
    public class AuthorizationStartup
    {
        private static IContainer _container;

        public static void Initialize()
        {
            ConfigureCompositionRoot();
        }

        private static void ConfigureCompositionRoot()
        {
            var containerBuilder = new ContainerBuilder();
            var sqlLiteConnectionString = "Server=localhost;Database=pl_server_db;User Id=pl_server_user;Password=zaq1@WSX;";

            containerBuilder.RegisterModule(new ProcessingModule());
            containerBuilder.RegisterModule(new DatabaseModule(sqlLiteConnectionString));

            _container = containerBuilder.Build();
            AuthorizationCompositionRoot.SetContainer(_container);
        }
    }
}
