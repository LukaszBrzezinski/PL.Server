﻿using System;
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
                var dbContextOptionsBuilder = CreateDbContextOptionsBuilder(_databaseConnectionString);
                return new AuthorizationDbContext(dbContextOptionsBuilder.Options);
            })
            .AsSelf()
            .As<DbContext>()
            .InstancePerLifetimeScope();

            var infrastructureAssembly = typeof(AuthorizationDbContext).Assembly;

            builder.RegisterAssemblyTypes(infrastructureAssembly)
                .Where(type => type.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }

        internal static DbContextOptionsBuilder<AuthorizationDbContext> CreateDbContextOptionsBuilder(string connectionString)
        {
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<AuthorizationDbContext>();
            dbContextOptionsBuilder.UseSqlite(connectionString, opt =>
            {
                opt.MigrationsAssembly(typeof(AuthorizationDbContext).Assembly.GetName().Name);
                opt.MigrationsHistoryTable("ef_migrationHistory");
            });

            return dbContextOptionsBuilder;
        }
    }
}
