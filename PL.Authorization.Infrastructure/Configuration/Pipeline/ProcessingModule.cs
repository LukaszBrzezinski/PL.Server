using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using MediatR.Extensions.Autofac.DependencyInjection;
using PL.BuildingBlocks.Application;

namespace PL.Authorization.Infrastructure.Configuration.Pipeline
{
    internal class ProcessingModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //TODO: search Application layer assemblies 
            builder.AddMediatR();

            builder.RegisterType<ICommandBus>()
                .As<CommandBus>()
                .InstancePerLifetimeScope();

            builder.RegisterType<IQueryBus>()
                .As<QueryBus>()
                .InstancePerLifetimeScope();


        }
    }
}
