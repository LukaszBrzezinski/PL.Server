using Autofac;
using MediatR.Extensions.Autofac.DependencyInjection;
using PL.Authorization.Application;
using PL.Authorization.Infrastructure.Processing;
using PL.BuildingBlocks.Application;

namespace PL.Authorization.Infrastructure.Configuration.Processing
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

            builder.RegisterDecorator(
                typeof(UnitOfWorkCommandBusDecorator),
                typeof(ICommandBus));
        }
    }
}
