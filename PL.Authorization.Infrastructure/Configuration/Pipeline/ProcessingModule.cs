using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using MediatR.Extensions.Autofac.DependencyInjection;
using PL.Authorization.Application;
using PL.BuildingBlocks.Application;

namespace PL.Authorization.Infrastructure.Configuration.Pipeline
{
    internal class ProcessingModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.AddMediatR(typeof(IAuthorizationModule).Assembly);

            builder.RegisterType<CommandBus>()
                .As<ICommandBus>()
                .InstancePerLifetimeScope();

            builder.RegisterType<QueryBus>()
                .As<IQueryBus>()
                .InstancePerLifetimeScope();
        }
    }
}
