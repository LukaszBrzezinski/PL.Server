using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Microsoft.Extensions.Configuration;
using PL.Authorization.Infrastructure.Configuration.Pipeline;
using Serilog;

namespace PL.Authorization.Infrastructure.Configuration
{
    public class AuthorizationStartup
    {
        private static IContainer _container;

        public static void Initialize(IConfiguration configuration, ILogger logger)
        {
            ConfigureCompositionRoot();
        }

        private static void ConfigureCompositionRoot()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterModule(new ProcessingModule());

            _container = containerBuilder.Build();
            AuthorizationCompositionRoot.SetContainer(_container);
        }
    }
}
