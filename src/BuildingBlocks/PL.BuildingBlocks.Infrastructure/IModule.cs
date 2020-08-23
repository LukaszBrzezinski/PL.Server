using System;
using Microsoft.Extensions.DependencyInjection;

namespace PL.BuildingBlocks.Infrastructure
{
    public interface IModule
    {
        void Setup(IServiceCollection services);
        void Register(IServiceCollection services);
    }
}
