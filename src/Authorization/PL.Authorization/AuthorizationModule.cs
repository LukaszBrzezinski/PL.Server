using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PL.API.Authorization;
using PL.Authorization.Configurations;
using PL.BuildingBlocks.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Storage;

namespace PL.Authorization
{
    public class AuthorizationModule : IModule
    {
        public void Setup(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AuthorizationDbContext>(options =>
                {
                    options.UseMySql(configuration.GetConnectionString("default"), serverOptions =>
                        {
                            serverOptions.ServerVersion(new ServerVersion(new Version(8, 0, 21), ServerType.MySql));
                            serverOptions.MigrationsAssembly(typeof(AuthorizationDbContext).AssemblyQualifiedName);
                            serverOptions.MigrationsHistoryTable(ModuleConstants.EF_MigrationsTable);
                        });
                });
        }

        public void Setup(IServiceCollection services)
        {
            throw new NotImplementedException();
        }

        public void Register(IServiceCollection services)
        {
            throw new NotImplementedException();
        }
    }
}
