using System;
using IdentityServer4.AspNetIdentity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PL.API.Authorization;
using PL.Authorization.Configurations;
using PL.Authorization.Models;
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

            // add identity
            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<AuthorizationDbContext>()
                .AddDefaultTokenProviders();

            // TODO: Configure Identity options and password complexity
            services.Configure<IdentityOptions>(options =>
            {
                // UserAccount settings
                options.User.RequireUniqueEmail = true;

                //    //// Password settings
                //    //options.Password.RequireDigit = true;
                //    //options.Password.RequiredLength = 8;
                //    //options.Password.RequireNonAlphanumeric = false;
                //    //options.Password.RequireUppercase = true;
                //    //options.Password.RequireLowercase = false;

                //    //// Lockout settings
                //    //options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                //    //options.Lockout.MaxFailedAccessAttempts = 10;
            });

            // Adds IdentityServer.
            services.AddIdentityServer()
                // The AddDeveloperSigningCredential extension creates temporary key material for signing tokens.
                // This might be useful to get started, but needs to be replaced by some persistent key material for production scenarios.
                // See http://docs.identityserver.io/en/release/topics/crypto.html#refcrypto for more information.
                .AddDeveloperSigningCredential()
                .AddInMemoryPersistedGrants()
                // To configure IdentityServer to use EntityFramework (EF) as the storage mechanism for configuration data (rather than using the in-memory implementations),
                // see https://identityserver4.readthedocs.io/en/release/quickstarts/8_entity_framework.html
                .AddInMemoryIdentityResources(IdentityServerConfig.GetIdentityResources())
                .AddInMemoryApiResources(IdentityServerConfig.GetApiResources())
                .AddInMemoryClients(IdentityServerConfig.GetClients())
                .AddAspNetIdentity<ApplicationUser>()
                .AddProfileService<ProfileService>();
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
