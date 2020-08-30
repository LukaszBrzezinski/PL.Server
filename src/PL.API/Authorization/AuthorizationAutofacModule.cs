using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using PL.Authorization.Application;
using PL.Authorization.Infrastructure;

namespace PL.API.Authorization
{
    internal class AuthorizationAutofacModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AuthorizationModule>()
                .As<IAuthorizationModule>()
                .InstancePerLifetimeScope();
        }
    }
}
