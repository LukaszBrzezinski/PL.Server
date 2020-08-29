using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace PL.Authorization.Infrastructure.Configuration
{
    public class AuthorizationStartup
    {

        public static void Initialize(IConfiguration configuration, ILogger logger)
        {

        }

        private static void ConfigureCompositionRoot()
        {
            var containerBuilder = new ContainerBuilder();

        }
    }
}
