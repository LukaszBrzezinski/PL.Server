using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Microsoft.EntityFrameworkCore;

namespace PL.Authorization.Infrastructure.Configuration
{
    internal class DatabaseModule : Autofac.Module
    {
        private readonly string _databaseConnectionString;

        public DatabaseModule(string databaseConnectionString)
        {
            _databaseConnectionString = databaseConnectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c =>
            {
                var dbContextOptionsBuilder = new DbContextOptionsBuilder<AuthorizationDbContext>();
                dbContextOptionsBuilder.UseSqlite(_databaseConnectionString);

                return new AuthorizationDbContext(dbContextOptionsBuilder.Options);
            })
            .AsSelf()
            .As<DbContext>()
            .InstancePerLifetimeScope();
        }
    }
}
